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
    public partial class GestionClient : Form
    {
        public GestionClient()
        {
            InitializeComponent();
            fillData();
        }

        private void fillData()
        {
            //Fill the data grid view with the films in the database
            //Use the connection object in the Database class
            string sql = "SELECT id, nom, tel FROM Clients";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Database.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            string id = idFieldAdd.Text;
            string nom = nomField.Text;
            string tel = telField.Text;
            string mdp = Utilities.hashPwd(mdpField.Text);
            Client client = new Client(id, nom, tel, mdp);
            if (client.addCustomer())
            {
                MessageBox.Show("Client ajouté avec succès");
                fillData();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout du client");
            }

        }

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
            string id = idFieldSupprimer.Text;
            Client client = new Client(id);
            if (client.deleteCustomer())
            {
                MessageBox.Show("Client supprimé avec succès");
                fillData();
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression du client");
            }
        }
    }
}
