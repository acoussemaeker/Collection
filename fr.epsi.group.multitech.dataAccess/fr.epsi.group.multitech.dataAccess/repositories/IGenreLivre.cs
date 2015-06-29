using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    interface IGenreLivre : IDisposable
    {
        IEnumerable<GenreLivre> GetGenreLivre();
        Livre GetGenreLivreByID(int GenreLivreId);
        void InsertGenreLivre(GenreLivre genreLivre);
        void DeleteGenreLivre(int genreLivreId);
        void UpdateGenreLivre(GenreLivre genreLivre);
        void Save();
    }
}
