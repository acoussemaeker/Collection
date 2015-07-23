using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    class UtilisateurJeuxSupportRepository : IDisposable
    {
        private CollectionEntities context;
        private bool disposed = false;

        public UtilisateurJeuxSupportRepository(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<UtilisateurJeuxSupport> GetUtilisateurJeuxSupport()
        {
            return context.UtilisateurJeuxSupport.ToList();
        }

        public UtilisateurJeuxSupport GetUtilisateurJeuxSupportByID(int UtilisateurJeuxSupportId)
        {
            return context.UtilisateurJeuxSupport.Find(UtilisateurJeuxSupportId);
        }

        public void InsertUtilisateurJeuxSupport(UtilisateurJeuxSupport UtilisateurJeuxSupport)
        {
            context.UtilisateurJeuxSupport.Add(UtilisateurJeuxSupport);
        }

        public void DeleteUtilisateurJeuxSupport(int UtilisateurJeuxSupportId)
        {
            UtilisateurJeuxSupport UtilisateurJeuxSupport = context.UtilisateurJeuxSupport.Find(UtilisateurJeuxSupportId);
            context.UtilisateurJeuxSupport.Remove(UtilisateurJeuxSupport);
        }

        public void UpdateUtilisateurJeuxSupport(UtilisateurJeuxSupport UtilisateurJeuxSupport)
        {
            context.Entry(UtilisateurJeuxSupport).State = EntityState.Modified;
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