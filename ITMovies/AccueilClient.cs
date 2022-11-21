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
    public partial class AccueilClient : Form
    {
        Client client;
        public AccueilClient()
        {
            InitializeComponent();
        }
        public AccueilClient(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ChangerMdp(client).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ListeFilms(client).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new HistoriqueClient(client).Show();
        }
    }
}
