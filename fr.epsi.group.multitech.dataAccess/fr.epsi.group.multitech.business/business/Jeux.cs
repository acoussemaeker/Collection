using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class Jeux
    {
        int id;
        string nom;
        string description;
        DateTime dateSortie;
        string editeur;

        public Jeux(int id,string nom, string description, DateTime dateSortie, string editeur )
        {
            this.id = id;
            this.nom = nom;
            this.description = description;
            this.dateSortie = dateSortie;
            this.editeur = editeur;
        }

        public Jeux(string nom, string description, DateTime dateSortie, string editeur)
        {
            this.nom = nom;
            this.description = description;
            this.dateSortie = dateSortie;
            this.editeur = editeur;
        }
    }
}
