using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ITMovies
{
    public class Client
    {
        public string id { get; set; }
        public string nom { get; set; }
        //public string email { get; set; }
        public string tel { get; set; }
        public string mdp { get; set; }

        public Client(string id, string nom, string tel, string mdp)
        {
            this.id = id;
            this.nom = nom;
            this.tel = tel;
            this.mdp = mdp;
        }
        public Client(string id, string nom, string tel)
        {
            this.id=id;
            this.nom = nom;
            this.tel=tel;
        }
        public Client(string id)
        {
            this.id = id;
        }
        public bool addCustomer()
        {
            // add this film to the database
            // using the connection object in the Database class
            // return true if the film was added successfully
            // return false if the film was not added successfully
            string sql = "INSERT INTO Clients (id, nom, tel, mdp) VALUES (@id, @nom, @tel, @mdp)";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.Parameters.AddWithValue("@nom", this.nom);
            cmd.Parameters.AddWithValue("@tel", this.tel);
            cmd.Parameters.AddWithValue("@mdp", this.mdp);
            Database.connection.Open();
            int rows = cmd.ExecuteNonQuery();
            Database.connection.Close();
            return rows > 0;
            
        }
        public bool deleteCustomer()
        {
            //Delete the customer from the database
            //Return true if the customer was deleted successfully
            //Return false if the customer was not deleted successfully
            string sql = "DELETE FROM Clients WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@id", this.id);
            Database.connection.Open();
            int rows = cmd.ExecuteNonQuery();
            Database.connection.Close();
            return rows > 0;
            
        }
        public bool updateCustomer()
        {
            //Update the customer in the database
            //Return true if the customer was updated successfully
            //Return false if the customer was not updated successfully
            string sql = "UPDATE Clients SET nom = @nom, tel = @tel, mdp = @mdp WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.Parameters.AddWithValue("@nom", this.nom);
            cmd.Parameters.AddWithValue("@tel", this.tel);
            cmd.Parameters.AddWithValue("@mdp", this.mdp);
            Database.connection.Open();
            int rows = cmd.ExecuteNonQuery();
            Database.connection.Close();
            return rows > 0;
            
        }
        public bool equals(Client client)
        {
            // check if this client is the same as the client passed as parameter with the id
            return this.id == client.id && this.nom == client.nom && this.tel == client.tel;
        }
        public static bool checkExistence(string id)
        {
            //Check if the client exists in the database
            //Return true if the client exists
            //Return false if the client does not exist
            string sql = "SELECT * FROM Clients WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@id", id);
            Database.connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool exists = reader.HasRows;
            reader.Close();
            Database.connection.Close();
            return exists;
        }
        public static List<Client> getAllCustomers()
        {
            string sql = "SELECT id, nom, tel FROM clients";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            Database.connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Client> clients = new List<Client>();
            while (reader.Read())
            {
                Client client = new Client(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                clients.Add(client);
            }
            reader.Close();
            Database.connection.Close();
            return clients;

        }


    }
}
