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
        public AccueilAdmin()
        {
            InitializeComponent();
        }
        public AccueilAdmin(Admin admin)
        {
            InitializeComponent();
            if (admin.id == "super")
            {
                gererLesAdminsBtn.Enabled = true;
            }
        }
    }
}
