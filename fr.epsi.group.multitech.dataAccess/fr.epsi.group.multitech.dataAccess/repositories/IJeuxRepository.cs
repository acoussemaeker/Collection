using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    public interface IJeuxRepository : IDisposable
    {
        IEnumerable<Jeux> GetJeux();
        Jeux GetJeuxByID(int JeuxId);
        void InsertJeux(Jeux jeux);
        void DeleteJeux(int jeuxId);
        void UpdateJeux(Jeux jeux);
        void Save();
    }
}
