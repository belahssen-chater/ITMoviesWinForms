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
using System.Data.SqlClient;

namespace ITMovies
{
    public partial class GestionAdmins : Form
    {
        public GestionAdmins()
        {
            InitializeComponent();
            fillData();
        }

        private void fillData()
        {
            //Fill the data grid view with the films in the database
            //Use the connection object in the Database class
            string sql = "SELECT * FROM Admins";
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
            Admin admin = new Admin(id, nom, tel, mdp);
            if (admin.addAdmin())
            {
                MessageBox.Show("Admin ajouté avec succès");
                fillData();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout de l'admin");
            }

        }

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
            string id = idFieldSuppr.Text;
            Admin admin = new Admin(id);
            if (admin.deleteAdmin())
            {
                MessageBox.Show("Admin supprimé avec succès");
                fillData();
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression de l'admin");
            }
        }
    }
}
