using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITMovies
{
    public partial class GestionFilms2 : Form
    {
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmdbuilder;
        public GestionFilms2()
        {
            InitializeComponent();
        }

        private void GestionFilms2_Load(object sender, EventArgs e)
        {
            // check if the connection is open or not
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            adap = new SqlDataAdapter("SELECT id, titre, realisateur, langue, duree, prix, stock FROM films", Database.connection);
            ds = new DataSet();
            adap.Fill(ds, "films");
            dataGridView1.DataSource = ds.Tables["films"];
            dataGridView1.Columns["id"].Visible = false;
            // set the titre column fill
            dataGridView1.Columns["titre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
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
            adap.Update(ds, "films");
            MessageBox.Show("Updated");
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //get the current cell value

            string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            string val = cell.Value.ToString();
            if (headerText.Equals("titre"))
            {
                if (string.IsNullOrWhiteSpace(val))
                {
                    //MessageBox.Show("titre cannot be empty");
                    cell.ErrorText = "titre cannot be empty";
                    // set the focus to the current cell
                    //stop the default action
                }
                else if (val.Length > 50)
                {
                    //MessageBox.Show("titre cannot be empty");
                    cell.ErrorText = "titre cannot be more than 50 characters";
                    // set the focus to the current cell
                    //stop the default action
                }
                else
                {
                    cell.ErrorText = "";
                }

            }
            //check if the duree column as the pattern hours+h+minutes
            if (headerText.Equals("duree"))
            {
                string regex = @"^(0?\d|1[0-9]|2[0-4])h0?[0-5][0-9]?$";
                
                if (!Regex.IsMatch(val, regex))
                {
                    cell.ErrorText = "duree should be in the format hh+h+mm";
                }
                else
                {
                    cell.ErrorText = "";
                }

            }
            // check if the other columns are empty
            if (headerText.Equals("realisateur") || headerText.Equals("langue") || headerText.Equals("prix"))
            {
                if (string.IsNullOrWhiteSpace(val))
                {
                    cell.ErrorText = headerText + " cannot be empty";
                }
                else
                {
                    cell.ErrorText = "";
                }
            }
            // check if the prix is a number with the format 0,0+ or 0+ or 0,0+
            if (headerText.Equals("prix"))
            {
                string regex = @"^[0-9]+(\.[0-9]{1,2})?$";
                if (!Regex.IsMatch(val, regex))
                {
                    cell.ErrorText = "prix should be a number with the format 0+,0+ or 0+";
                }
                else
                {
                    cell.ErrorText = "";
                }
            }
            // check if the stock is a number
            if (headerText.Equals("stock"))
            {
                string regex = @"^[0-9]+$";
                if (!Regex.IsMatch(val, regex))
                {
                    cell.ErrorText = "stock should be a number";
                }
                else
                {
                    cell.ErrorText = "";
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // search in all the columns
            string search = textBox1.Text;
            string query = "SELECT id, titre, realisateur, langue, duree, prix FROM films WHERE titre LIKE '%" + search + "%' OR realisateur LIKE '%" + search + "%' OR langue LIKE '%" + search + "%' OR duree LIKE '%" + search + "%' OR prix LIKE '%" + search + "%'";
            adap = new SqlDataAdapter(query, Database.connection);
            ds = new DataSet();
            adap.Fill(ds, "films");
            dataGridView1.DataSource = ds.Tables["films"];
            dataGridView1.Columns["id"].Visible = false;
            // set the titre column fill
            dataGridView1.Columns["titre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // reset the error text
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.ErrorText = "";
                }
            }
        }
    }
}
