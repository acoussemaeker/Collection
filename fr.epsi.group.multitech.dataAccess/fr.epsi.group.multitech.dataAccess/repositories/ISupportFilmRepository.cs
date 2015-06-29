using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    interface ISupportFilmRepository :IDisposable
    {
        IEnumerable<Supportlivre> GetSupportFilm();
        Supportlivre GetSupportFilmByID(int SupportFilmId);
        void InsertSupportFilm(Supportlivre film);
        void DeleteSupportFilm(int filmId);
        void UpdateSupportFilm(Supportlivre film);
        void Save();
    }
}