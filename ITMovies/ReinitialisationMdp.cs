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
    public partial class ReinitialisationMdp : Form
    {
        Admin admin;
        Client client;
        public ReinitialisationMdp()
        {
            InitializeComponent();
        }
        public ReinitialisationMdp(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }
        public ReinitialisationMdp(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if the admin is not null the name of the table will be admins
            // else the name of the table will be clients
            string table = admin != null ? "admins" : "clients";
            // if the admin is not null the id of the admin will be used
            // else the id of the client will be used
            string id = admin != null ? admin.id : client.id;
            
            if (admin != null && admin.id == "super")
            {
                MessageBox.Show("Vous ne pouvez pas changer le mot de passe de l'administrateur principal");
                return;
            }
            // test that the pwd and the confirm pwd are the same
            if (confirmPwdField.Text != pwdField.Text)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas");
                return;
            }
            // test that the pwd is not empty
            if (pwdField.Text == "")
            {
                MessageBox.Show("Le mot de passe ne peut pas être vide");
                return;
            }
            // reset the password
            // before opening the connection, check if it's open or not
            if (Database.connection.State == ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            // create the command
            SqlCommand cmd = new SqlCommand($"UPDATE {table} SET mdp = @mdp WHERE id = @id", Database.connection);
            // add the parameters
            string hashedPwd = Utilities.hashPwd(pwdField.Text);
            cmd.Parameters.AddWithValue("@mdp", hashedPwd);
            cmd.Parameters.AddWithValue("@id", id);
            // execute the command
            
            int rowsAffected = cmd.ExecuteNonQuery();
            // close the connection
            Database.connection.Close();
            // check if the command was executed successfully
            if (rowsAffected > 0)
            {
                MessageBox.Show("Le mot de passe a été changé avec succès");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite");
            }
              
            
        }
    }
}
