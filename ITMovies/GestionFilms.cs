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

namespace ITMovies
{
    public partial class GestionFilms : Form
    {
        public GestionFilms()
        {
            InitializeComponent();
            fillData();
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
        }

        private void ajouterBtn_Click(object sender, EventArgs e)
        {
            string titre = titreField.Text;
            string realisateur = realField.Text;
            string langue = langueField.Text;
            string duree = dureeField.Text;
            double prix = double.Parse(prixField.Text);
            Film film = new Film(titre, realisateur, langue, duree, prix);

            if (film.addFilm())
            {
                MessageBox.Show("Film ajouté avec succès");
                fillData();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'ajout du film");
            }
        }

        private void supprimerBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idField.Text);
            Film film = new Film(id);

            if (film.deleteFilm())
            {
                MessageBox.Show("Film supprimé avec succès");
                fillData();
            }
            else
            {
                MessageBox.Show("Erreur lors de la suppression du film");
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
