using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class Livre
    {
        int id;
        string nom;
        string description;
        string auteur;
        string editeur;
        DateTime premiereparution;
        int nbPage;

        public Livre(int id, string nom, string description, string auteur, string editeur, DateTime premiereparution, int nbPage)
        {
            this.id = id;
            this.description = description;
            this.auteur = auteur;
            this.editeur = editeur;
            this.premiereparution = premiereparution;
            this.nbPage = nbPage;
        }

        public Livre(string nom, string description, string auteur, string editeur, DateTime premiereparution, int nbPage)
        {
            this.description = description;
            this.auteur = auteur;
            this.editeur = editeur;
            this.premiereparution = premiereparution;
            this.nbPage = nbPage;
        }
    }
}
