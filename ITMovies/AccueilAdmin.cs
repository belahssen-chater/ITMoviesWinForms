using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMovies
{
    public partial class AccueilAdmin : Form
    {
        private Admin admin;
        public AccueilAdmin()
        {
            InitializeComponent();
        }
        public AccueilAdmin(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            if (admin.id == "super")
            {
                gererLesAdminsBtn.Enabled = true;
            }
        }

        private void changerMdpBtn_Click(object sender, EventArgs e)
        {
            new ChangerMdp(admin).Show();
        }

        private void gererLesFilms_Click(object sender, EventArgs e)
        {
            new GestionFilms2().Show();
        }

        private void gererLesClientsBtn_Click(object sender, EventArgs e)
        {
            new GestionClient2().Show();
        }

        private void gererLesAdminsBtn_Click(object sender, EventArgs e)
        {
            new GestionAdmin2().Show();
        }

        private void afficherHistoriqueBtn_Click(object sender, EventArgs e)
        {
            new GestionAchats().Show();
        }

        private void AccueilAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
