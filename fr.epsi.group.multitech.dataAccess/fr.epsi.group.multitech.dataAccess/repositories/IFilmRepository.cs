using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    public interface IFilmRepository : IDisposable
    {
        IEnumerable<Film> GetFilms();
        Film GetFilmByID(int FilmId);
        void InsertFilm(Film film);
        void DeleteFilm(int filmId);
        void UpdateFilm(Film film);
        void Save();
    }
}
