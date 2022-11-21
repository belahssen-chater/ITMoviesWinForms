using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMovies
{
    public partial class GestionClient2 : Form
    {
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmdbuilder;
        public GestionClient2()
        {
            InitializeComponent();
        }

        private void GestionClient2_Load(object sender, EventArgs e)
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            // don't show the row of the super admin
            // the super admin has super as id
            adap = new SqlDataAdapter("SELECT id, nom, tel FROM clients", Database.connection);
            // adap = new SqlDataAdapter("SELECT id, nom, tel FROM Admins", Database.connection);
            ds = new DataSet();
            adap.Fill(ds, "Clients");
            dataGridView1.DataSource = ds.Tables["Clients"];
            // set the nom column fill
            dataGridView1.Columns["nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            // search in the id, nom, tel columns
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("id LIKE '%{0}%' OR nom LIKE '%{0}%' OR tel LIKE '%{0}%'", searchField.Text);
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            // check that the cell is not empty
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "This cell cannot be empty";
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";
            }
            // check that the tel has the pattern +?\d{8,}
            if (e.ColumnIndex == 2)
            {
                if (!Regex.IsMatch(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), @"^(\+?\d{8,})$"))
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "The phone number must be in the format +12345678";
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";
                }
            }


        }

        private void validerBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ErrorText != "")
                    {
                        MessageBox.Show("There is an error in the datagridview");
                        return;
                    }
                }
            }

            //updating the database from the datagridview
            cmdbuilder = new SqlCommandBuilder(adap);
            adap.Update(ds, "Clients");
            MessageBox.Show("Updated");
            
        }

        private void resetPwdBtn_Click(object sender, EventArgs e)
        {
            // create a new client
            Client client = new Client(idField.Text);
            // show the reset password form
            new ReinitialisationMdp(client).Show();
        }
    }
}
