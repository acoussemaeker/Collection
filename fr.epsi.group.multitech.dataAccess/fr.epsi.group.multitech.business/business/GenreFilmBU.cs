using fr.epsi.group.multitech.dataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.business.business
{
    class GenreFilmBU
    {
        int id;
        string nom;

        public GenreFilmBU(GenreFilm genreFilm)
        {
            this.id = genreFilm.id;
            this.nom = genreFilm.nom;
        }

        public GenreFilmBU(string nom)
        {
            this.nom = nom;
        }

        public GenreFilm GetModel()
        {
            GenreFilm _result = new GenreFilm();
            _result.id = this.id;
            _result.nom = this.nom;

            return _result;
        }
    }
}
