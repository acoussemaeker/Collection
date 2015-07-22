using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class Film
    {
        int id;
        string nom;
        string description;
        string realisateur;
        DateTime dateSortie;
        string paysOrigine;

        public Film(int id,string nom, string description, string realisateur, DateTime dateSortie, string paysOrigine )
        {
            this.id = id;
            this.nom = nom;
            this.description = description;
            this.realisateur = realisateur;
            this.dateSortie = dateSortie;
            this.paysOrigine = paysOrigine;
        }

        public Film(string nom, string description, string realisateur, DateTime dateSortie, string paysOrigine)
        {
            this.nom = nom;
            this.description = description;
            this.realisateur = realisateur;
            this.dateSortie = dateSortie;
            this.paysOrigine = paysOrigine;
        }
    }
}
