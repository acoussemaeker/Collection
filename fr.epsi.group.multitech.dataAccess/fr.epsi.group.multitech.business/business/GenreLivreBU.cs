using fr.epsi.group.multitech.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class GenreLivreBU
    {
        int id;
        string nom;

        public GenreLivreBU(GenreLivre genreLivre)
        {
            this.id = genreLivre.id;
            this.nom = genreLivre.nom;
        }

        public GenreLivreBU(string nom)
        {
            this.nom = nom;
        }

        public GenreLivre GetModel()
        {
            GenreLivre _result = new GenreLivre();
            _result.id = this.id;
            _result.nom = this.nom;

            return _result;
        }
    }
}
