using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    public interface ILivreRepository : IDisposable
    {
        IEnumerable<Livre> GetLivre();
        Livre GetLivreByID(int LivreId);
        void InsertLivre(Livre livre);
        void DeleteLivre(int livreId);
        void UpdateLivre(Livre livre);
        void Save();
    }
}

