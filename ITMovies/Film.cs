using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ITMovies
{
    public class Film
    {
        private int id;
        private string titre;
        private string realisateur;
        //private string description;
        private string langue;
        //private int annee;
        private string duree;
        private double prix;

        public Film(int id, string titre, string realisateur, string langue, string duree, double prix)
        {
            this.id = id;
            this.titre = titre;
            this.realisateur = realisateur;
            this.langue = langue;
            this.duree = duree;
            this.prix = prix;
        }
        //Constructor without the id
        public Film(string titre, string realisateur, string langue, string duree, double prix)
        {
            this.titre = titre;
            this.realisateur = realisateur;
            this.langue = langue;
            this.duree = duree;
            this.prix = prix;
        }
        //Constructor with only the id (for the delete)
        public Film(int id)
        {
            this.id = id;
        }

        public bool equals(Film film)
        {
            // check if this film is the same as the film passed as parameter without the id
            if (this.titre == film.titre && this.realisateur == film.realisateur && this.langue == film.langue && this.duree == film.duree && this.prix == film.prix)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool addFilm()
        {
            // add this film to the database but not the id
            // using the connection object in the Database class

            //create the sql query
            string sql = "INSERT INTO Films (titre,realisateur,langue,duree,prix) VALUES (@titre,@realisateur,@langue,@duree,@prix)";
            
            //open the connnection
            Database.connection.Open();
            // create the command
            SqlCommand command = new SqlCommand(sql, Database.connection);
            // add the parameters
            command.Parameters.AddWithValue("@titre", this.titre);
            command.Parameters.AddWithValue("@realisateur", this.realisateur);
            command.Parameters.AddWithValue("@langue", this.langue);
            command.Parameters.AddWithValue("@duree", this.duree);
            command.Parameters.AddWithValue("@prix", this.prix);
            // execute the command
            int rows = command.ExecuteNonQuery();
            // close the connection
            Database.connection.Close();
            // return true if the command was executed successfully
            return rows > 0;
        }
        public bool deleteFilm()
        {
            // delete this film from the database
            // using the connection object in the Database class

            //create the sql query
            string sql = "DELETE FROM Films WHERE id=@id";
            //open the connnection
            Database.connection.Open();
            // create the command
            SqlCommand command = new SqlCommand(sql, Database.connection);
            // add the parameters
            command.Parameters.AddWithValue("@id", this.id);
            // execute the command
            int rows = command.ExecuteNonQuery();
            // close the connection
            Database.connection.Close();
            // return true if the command was executed successfully
            return rows > 0;
        }
        public bool updateFilm(Film film)
        {  
            // update this film in the database
            // using the connection object in the Database class

            //create the sql query
            string sql = "UPDATE Films SET titre=@titre,realisateur=@realisateur,langue=@langue,duree=@duree,prix=@prix WHERE id=@id";
            //open the connnection
            Database.connection.Open();
            // create the command
            SqlCommand command = new SqlCommand(sql, Database.connection);
            // add the parameters
            command.Parameters.AddWithValue("@id", this.id);
            command.Parameters.AddWithValue("@titre", film.titre);
            command.Parameters.AddWithValue("@realisateur", film.realisateur);
            command.Parameters.AddWithValue("@langue", film.langue);
            command.Parameters.AddWithValue("@duree", film.duree);
            command.Parameters.AddWithValue("@prix", film.prix);
            // execute the command
            int rows = command.ExecuteNonQuery();
            // close the connection
            Database.connection.Close();
            // return true if the command was executed successfully
            return rows > 0;
        }
        public static List<Film> getAllFilms()
        {
            string sql = "SELECT id, titre, realisateur, langue, duree, prix FROM films";
            SqlCommand cmd = new SqlCommand(sql, Database.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Film> films = new List<Film>();
            while (reader.Read())
            {
                Film film = new Film(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetDouble(5));
                films.Add(film);
            }
            reader.Close();
            Database.connection.Close();
            return films;
        }
        
    }

}