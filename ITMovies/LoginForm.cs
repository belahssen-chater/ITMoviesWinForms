using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ITMovies
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id;
            Database.connection.Open();
            SqlCommand command;
            SqlDataReader reader;
            string pwd = Utilities.hashPwd(passwordField.Text);
            string customerQuery = $"SELECT id FROM clients WHERE id='{loginField.Text}' AND mdp='{pwd}'";
            string adminQuery = $"SELECT id FROM admins WHERE id='{loginField.Text}' AND mdp='{pwd}'";
            

            //Client check
            command = new SqlCommand(customerQuery, Database.connection);
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                id = reader.GetString(0);
                Client client = new Client(id);
                reader.Close();
                MessageBox.Show($"Bienvenue client {id}");

            }
            else
            {
                //Admin check
                if (!reader.IsClosed)
                    reader.Close();
                command = new SqlCommand(adminQuery, Database.connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    id = reader.GetString(0);
                    Admin admin = new Admin(id);
                    if (!reader.IsClosed)
                        reader.Close();
                    new AccueilAdmin(admin).Show();
          
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe incorrect");
                }
                if (!reader.IsClosed)
                    reader.Close();
            }
            Database.connection.Close();
            if (!reader.IsClosed)
                reader.Close();


        }

    }
}
