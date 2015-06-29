using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    interface ISupportJeuxRepository : IDisposable
    {
        IEnumerable<Supportlivre> GetSupportJeux();
        Supportlivre GetSupportJeuxByID(int SupportJeuxId);
        void InsertSupportJeux(Supportlivre jeux);
        void DeleteSupportJeux(int jeuxId);
        void UpdateSupportJeux(Supportlivre jeux);
        void Save();
    }
}
