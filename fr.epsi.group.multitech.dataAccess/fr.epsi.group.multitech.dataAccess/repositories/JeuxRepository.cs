using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    public class JeuxRepository : IJeuxRepository, IDisposable
    {
        private CollectionEntities context;
        private bool disposed = false;
        
        public JeuxRepository(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<Jeux> GetJeuxs()
        {
            return context.Jeux.ToList();
        }

        public Jeux GetJeuxByID(int JeuxId)
        {
            return context.Jeux.Find(JeuxId);
        }

        public void InsertJeux(Jeux jeux)
        {
            context.Jeux.Add(jeux);
        }

        public void DeleteJeux(int jeuxId)
        {
            Jeux jeux = context.Jeux.Find(jeuxId);
            context.Jeux.Remove(jeux);
        }

        public void UpdateJeux(Jeux jeux)
        {
            context.Entry(jeux).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

