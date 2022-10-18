using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMovies
{
    public class Client
    {
        public string id { get; set; }
        public string nom { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public string mdp { get; set; }

        public Client(string id, string nom, string email, string tel, string mdp)
        {
            this.id = id;
            this.nom = nom;
            this.email = email;
            this.tel = tel;
            this.mdp = mdp;
        }
        public Client(string id, string nom, string email, string tel)
        {
            this.id=id;
            this.nom = nom;
            this.tel=tel;
            this.email=email;
        }
        public Client(string id)
        {
            this.id = id;
        }
    }
}
