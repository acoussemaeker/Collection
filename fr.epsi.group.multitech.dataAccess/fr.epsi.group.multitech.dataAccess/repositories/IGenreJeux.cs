using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    interface IGenreJeux : IDisposable
    {
        IEnumerable<GenreJeux> GetGenreJeux();
        Jeux GetGenreJeuxByID(int GenreJeuxId);
        void InsertGenreJeux(GenreJeux genreJeux);
        void DeleteGenreJeux(int genreJeuxId);
        void UpdateGenreJeux(GenreJeux genreJeux);
        void Save();
    }
}
