using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return true;
        }
        public bool deleteAdmin()
        {
            //Delete the admin from the database
            //Return true if the admin was deleted successfully
            //Return false if the admin was not deleted successfully
            return true;
        }
        public bool updateAdmin()
        {
            //Update the admin in the database
            //Return true if the admin was updated successfully
            //Return false if the admin was not updated successfully
            return true;
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
            return true;
        }


    }
}
