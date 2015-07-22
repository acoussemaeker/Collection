using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    interface IGenreFilm : IDisposable
    {
        IEnumerable<GenreFilm> GetGenreFilm();
        Jeux GetGenreFilmByID(int GenreFilmId);
        void InsertGenreFilm(GenreFilm genreFilm);
        void DeleteGenreFilm(int genreFilmId);
        void UpdateGenreFilm(GenreFilm genreFilm);
        void Save();
    }
}
