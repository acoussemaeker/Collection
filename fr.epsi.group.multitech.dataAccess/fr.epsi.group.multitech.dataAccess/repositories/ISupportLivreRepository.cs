using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    interface ISupportLivreRepository : IDisposable
    {
        IEnumerable<Supportlivre> GetSupportLivre();
        Supportlivre GetSupportLivreByID(int SupportLivreId);
        void InsertSupportLivre(Supportlivre livre);
        void DeleteSupportLivre(int livreId);
        void UpdateSupportLivre(Supportlivre livre);
        void Save();
    }
}
