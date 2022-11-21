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
    public partial class GestionAchats : Form
    {
        public GestionAchats()
        {
            InitializeComponent();
            fillData();
        }
        private void fillData()
        {
            //Fill the data grid view with the films in the database
            //Use the connection object in the Database class
            string sql = "select a.id, f.titre Film, c.nom Client, a.dateAchat Date, f.prix Prix, f.stock Stock, a.etat Etat from achats a inner join films f on a.idFilm = f.id inner join clients c on a.idClient = c.id";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, Database.connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            //set all the columns readonly
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = true;
            }
            // set the Film column fill
            dataGridView1.Columns["Film"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // set the Client column fill
            dataGridView1.Columns["Client"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void validerBtn_Click(object sender, EventArgs e)
        {
            int idAchat = int.Parse(idField.Text);
            Achat achat = new Achat(idAchat);
            if (achat.validerAchat())
            {
                MessageBox.Show("Achat validé avec succès");
            }
            else
            {
                MessageBox.Show("Erreur lors de la validation");
            }
            dataGridView1.DataSource = null;
            fillData();
        }

        private void refuserBtn_Click(object sender, EventArgs e)
        {
            int idAchat = int.Parse(idField.Text);
            Achat achat = new Achat(idAchat);
            if (achat.refuserAchat())
            {
                MessageBox.Show("Achat refusé avec succès");
            }
            else
            {
                MessageBox.Show("Erreur lors du refus");
            }
        }

        private void GestionAchats_Load(object sender, EventArgs e)
        {

        }
    }
}
