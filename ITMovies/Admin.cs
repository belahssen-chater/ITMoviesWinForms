using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ITMovies
{
    public class Admin
    {
        public string id { get; set; }
        public string nom { get; set; }
        public string mdp { get; set; }
        public string tel { get; set; }

        public Admin(string id, string nom, string mdp, string tel)
        {
            this.id = id;
            this.nom = nom;
            this.mdp = mdp;
            this.tel = tel;
        }
        public Admin(string id, string nom, string tel) { this.id = id; this.nom = nom; this.tel = tel; }

        public Admin(string id)
        {
            this.id=id;
        }
        public bool addAdmin()
        {
            //Add the admin to the database
            //Return true if the admin was added successfully
            //Return false if the admin was not added successfully
            string sql = "INSERT INTO Admins (id, nom, mdp, tel) VALUES (@id, @nom, @mdp, @tel)";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.Parameters.AddWithValue("@nom", this.nom);
            cmd.Parameters.AddWithValue("@mdp", this.mdp);
            cmd.Parameters.AddWithValue("@tel", this.tel);
            Database.connection.Open();
            int rows = cmd.ExecuteNonQuery();
            Database.connection.Close();
            return rows > 0;
            
        }
        public bool deleteAdmin()
        {
            //Delete the admin from the database
            //Return true if the admin was deleted successfully
            //Return false if the admin was not deleted successfully
            string sql = "DELETE FROM Admins WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@id", this.id);
            Database.connection.Open();
            int rows = cmd.ExecuteNonQuery();
            Database.connection.Close();
            return rows > 0;
            
        }
        public bool updateAdmin(Admin admin)
        {
            //Update the admin in the database
            //Return true if the admin was updated successfully
            //Return false if the admin was not updated successfully
            string sql;
            if (this.mdp != "")
            {
                sql = "UPDATE Admins SET nom = @nom, mdp = @mdp, tel = @tel WHERE id = @id";

            }
            else
            {
                sql = "UPDATE Admins SET nom = @nom, tel = @tel WHERE id = @id";
            }
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@id", this.id);
            cmd.Parameters.AddWithValue("@nom", admin.nom);
            cmd.Parameters.AddWithValue("@tel", admin.tel);
            if (this.mdp != "")
                cmd.Parameters.AddWithValue("@mdp", admin.mdp);
            Database.connection.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            Database.connection.Close();
            return rowsAffected > 0;
            


        }
        public bool equals(Admin admin)
        {
            // check if this admin is the same as the admin passed as parameter with the id
            return this.id == admin.id && this.nom == admin.nom && this.tel == admin.tel;
        }
        public static bool checkExistence(string id)
        {
            //Check if the admin with the id passed as parameter exists in the database
            //Return true if the admin exists
            //Return false if the admin does not exist
            string sql = "SELECT * FROM Admins WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            cmd.Parameters.AddWithValue("@id", id);
            Database.connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool exists = reader.HasRows;
            reader.Close();
            Database.connection.Close();
            return exists;
        }


    }
}
