using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ITMovies
{
    public class Achat
    {
        public int id;
        public int idFilm;
        public string idClient;
        public DateTime dateAchat;
        public string etat;
        public Achat(int id)
        {
            this.id = id;
        }
        public Achat(int idFilm, string idClient)
        {
            this.idFilm = idFilm;
            this.idClient = idClient;
        }
        public bool acheter()
        {
            string sql = "INSERT INTO Achats (idFilm, idClient) VALUES (@idFilm, @idClient)";
            SqlCommand command = new SqlCommand(sql, Database.connection);
            command.Parameters.AddWithValue("@idFilm", this.idFilm);
            command.Parameters.AddWithValue("@idClient", this.idClient);
            if (Database.connection.State == System.Data.ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            int rows = command.ExecuteNonQuery();
            Database.connection.Close();
            return rows > 0;
            
        }
        public bool validerAchat()
        {
            SqlCommand command;
            SqlDataReader reader;
            string sql = "UPDATE Achats SET etat = 'validé' WHERE id = @id";
            string sql2 = "UPDATE Films SET stock = stock - 1 WHERE id = @idFilm";
            // get the idFilm
            string sql3 = "SELECT idFilm FROM Achats WHERE id = @id";
            // get the stock of the film
            string sql4 = "SELECT stock FROM Films WHERE id = @idFilm";
            int rows;
            // film's id getting
            command = new SqlCommand(sql3, Database.connection);
            command.Parameters.AddWithValue("@id", this.id);
            if (Database.connection.State == System.Data.ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            reader = command.ExecuteReader();
            reader.Read();
            this.idFilm = int.Parse(reader["idFilm"].ToString());
            reader.Close();
            Database.connection.Close();
            // check the stock of the film
            command = new SqlCommand(sql4, Database.connection);
            command.Parameters.AddWithValue("@idFilm", this.idFilm);
            if (Database.connection.State == System.Data.ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            reader = command.ExecuteReader();
            reader.Read();
            int stock = int.Parse(reader["stock"].ToString());
            reader.Close();
            Database.connection.Close();
            if (stock <= 0)
            {
                MessageBox.Show("The stock is empty");
                return false;
            }
            // update the etat
            command = new SqlCommand(sql, Database.connection);
            command.Parameters.AddWithValue("@id", this.id);
            if (Database.connection.State == System.Data.ConnectionState.Closed)
            {
                Database.connection.Open();
            }
            rows = command.ExecuteNonQuery();
            Database.connection.Close();
            // update the stock
            if (rows > 0)
            {
                command = new SqlCommand(sql2, Database.connection);
                command.Parameters.AddWithValue("@idFilm", this.idFilm);
                Database.connection.Open();
                rows = command.ExecuteNonQuery();
                Database.connection.Close();
            }
            
            return rows > 0;
        }
        public bool refuserAchat()
        {
            string sql = "UPDATE Achats SET etat = 'refusé' WHERE id = @id";
            SqlCommand command = new SqlCommand(sql, Database.connection);
            command.Parameters.AddWithValue("@id", this.id);
            Database.connection.Open();
            int rows = command.ExecuteNonQuery();
            Database.connection.Close();
            return rows > 0;
        }


    }
}
