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
    public partial class ListeFilms : Form
    {
        Client client;
        public ListeFilms()
        {
            InitializeComponent();
            
        }
        public ListeFilms(Client client)
        {
            InitializeComponent();
            
            this.client = client;
        }
        private void fillData()
        {
            //Fill the data grid view with the films in the database
            //Use the connection object in the Database class
            string sql = "SELECT * FROM Films";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Database.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
            }
            dataGridView1.Columns["titre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void acheterBtn_Click(object sender, EventArgs e)
        {
            int idFilm = int.Parse(idField.Text);
            string idClient = client.id;
            Achat achat = new Achat(idFilm, idClient);
            if (achat.acheter())
            {
                MessageBox.Show("Achat demandé avec succès, prière allez voir l'administrateur afin de finaliser la transaction");
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite lors de l'achat");
            }
        }

        private void ListeFilms_Load(object sender, EventArgs e)
        {
            fillData();
        }
    }
}
