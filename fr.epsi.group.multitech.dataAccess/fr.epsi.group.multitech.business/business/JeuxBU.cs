using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess
{
    class JeuxBU
    {
        int id;
        string nom;
        string description;
        DateTime dateSortie;
        string editeur;
        int genreid;

        public JeuxBU(Jeux jeux)
        {
            this.id = jeux.id;
            this.nom = jeux.nom;
            this.description = jeux.description;
            this.dateSortie = jeux.dateSortie;
            this.editeur = jeux.editeur;
        }

        public JeuxBU(string nom, string description, DateTime dateSortie, string editeur, int genreid)
        {
            this.nom = nom;
            this.description = description;
            this.dateSortie = dateSortie;
            this.editeur = editeur;
            this.genreid = genreid;
        }

        public Jeux GetModel()
        {
            Jeux _result = new Jeux();

            _result.id = this.id;
            _result.nom = this.nom;
            _result.description = this.description;
            _result.dateSortie = this.dateSortie;
            _result.editeur = this.editeur;
            _result.idGenre = this.genreid;

            return _result;
        }
    }
}
