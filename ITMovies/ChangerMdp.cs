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

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(oldPwdField.Text) || string.IsNullOrEmpty(newPwdField.Text) || string.IsNullOrEmpty(newPwdField2.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            string sql;
            SqlCommand command;
            SqlDataReader reader;
            string oldPwd = Utilities.hashPwd(oldPwdField.Text);
            string newPwd = Utilities.hashPwd(newPwdField.Text);
            string newPwdConf = Utilities.hashPwd(newPwdField2.Text);
            int rowsAffected = 0;
            if (newPwd != newPwdConf)
            {
                MessageBox.Show("Les mots de passe ne correspondent pas");
                return;
            }
            //check if a field is empty
            if (admin != null)
            {
                // check in the db if the old password is correct
                // if it is, change the password
                // else, show an error message
                sql = $"SELECT id FROM admins WHERE id='{admin.id}' AND mdp='{oldPwd}'";
                Database.connection.Open();
                command = new SqlCommand(sql, Database.connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    sql = $"UPDATE admins SET mdp='{newPwd}' WHERE id='{admin.id}'";
                    command = new SqlCommand(sql, Database.connection);
                    if (!reader.IsClosed)
                        reader.Close();
                    rowsAffected = command.ExecuteNonQuery();
                    Database.connection.Close();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect");
                }
                reader.Close();
            } else if (client != null)
            {
                // check in the db if the old password is correct
                // if it is, change the password
                // else, show an error message
                sql = $"SELECT id FROM clients WHERE id='{client.id}' AND mdp='{oldPwd}'";
                Database.connection.Open();
                command = new SqlCommand(sql, Database.connection);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    sql = $"UPDATE clients SET mdp='{newPwd}' WHERE id='{client.id}'";
                    command = new SqlCommand(sql, Database.connection);
                    rowsAffected = command.ExecuteNonQuery();
                    Database.connection.Close();
                }
                else
                {
                    MessageBox.Show("Mot de passe incorrect");
                }
                reader.Close();
            }
            if (rowsAffected > 0)
                MessageBox.Show("Mot de passe changé avec succès");
            Database.connection.Close();
        }
    }
}
