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
    public partial class ChangerMdp : Form
    {
        private Admin admin;
        private Client client;
        public ChangerMdp()
        {
            InitializeComponent();
        }
        public ChangerMdp(Client client)
        {
            InitializeComponent();
            this.client = client;
        }
        public ChangerMdp(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }
    }
}
