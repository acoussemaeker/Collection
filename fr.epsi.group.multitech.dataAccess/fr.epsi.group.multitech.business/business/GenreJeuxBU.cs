using fr.epsi.group.multitech.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class GenreJeuxBU
    {
        int id;
        string nom;

        public GenreJeuxBU(GenreJeux genreJeux)
        {
            this.id = genreJeux.id;
            this.nom = genreJeux.nom;
        }

        public GenreJeuxBU(string nom)
        {
            this.nom = nom;
        }

        public GenreJeux GetModel()
        {
            GenreJeux _result = new GenreJeux();
            _result.id = this.id;
            _result.nom = this.nom;

            return _result;
        }
    }
}
