using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMovies
{
    public partial class HistoriqueClient : Form
    {
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmdbuilder;
        Client client;
        public HistoriqueClient()
        {
            InitializeComponent();
        }
        public HistoriqueClient(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void HistoriqueClient_Load(object sender, EventArgs e)
        {
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            // don't show the row of the super admin
            // the super admin has super as id
            adap = new SqlDataAdapter("select f.titre Film, a.dateAchat Date, f.prix Prix, a.etat Etat from achats a inner join films f on a.idFilm = f.id inner join clients c on a.idClient = c.id WHERE c.id = '" + client.id + "'", Database.connection);
            
            DataSet ds = new DataSet();
            adap.Fill(ds, "Achats");
            dataGridView1.DataSource = ds.Tables["Achats"];
            // set the nom column fill
            dataGridView1.Columns["Film"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //set all columns to read only
            dataGridView1.ReadOnly = true;
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            // search in f.titre, a.dateAchat, f.prix, a.etat columns
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Film LIKE '%{0}%' OR Etat LIKE '%{0}%'", searchField.Text);
        }
    }
}
