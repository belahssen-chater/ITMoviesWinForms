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

    }
}
