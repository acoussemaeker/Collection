using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess
{
    class LivreBU
    {
        int id;
        string nom;
        string description;
        string auteur;
        string editeur;
        DateTime premiereParrution;
        int nbPage;
        int genreid;

        public LivreBU(Livre livre)
        {
            this.id = livre.id;
            this.nom = livre.nom;
            this.description = livre.description;
            this.auteur = livre.auteur;
            this.editeur = livre.editeur;
            this.premiereParrution = livre.premiereParrution;
            this.nbPage = livre.nbpage;
        }

        public LivreBU(string nom, string description, string auteur, string editeur, DateTime premiereParrution, int nbPage, int genreid)
        {
            this.nom = nom;
            this.description = description;
            this.auteur = auteur;
            this.editeur = editeur;
            this.premiereParrution = premiereParrution;
            this.nbPage = nbPage;
            this.genreid = genreid;
        }

        public Livre GetModel()
        {
            Livre _result = new Livre();

            _result.id = this.id;
            _result.nom = this.nom;
            _result.description = this.description;
            _result.auteur = this.auteur;
            _result.editeur = this.editeur;
            _result.premiereParrution = this.premiereParrution;
            _result.nbpage = this.nbPage;
            _result.idGenre = this.genreid;

            return _result;
        }
    }
}
