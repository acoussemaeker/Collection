using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    class UtilisateurLivreSupportRepository : IDisposable
    {
        private CollectionEntities context;
        private bool disposed = false;

        public UtilisateurLivreSupportRepository(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<UtilisateurLivreSupport> GetUtilisateurLivreSupport()
        {
            return context.UtilisateurLivreSupport.ToList();
        }

        public UtilisateurLivreSupport GetUtilisateurLivreSupportByID(int UtilisateurLivreSupportId)
        {
            return context.UtilisateurLivreSupport.Find(UtilisateurLivreSupportId);
        }

        public void InsertUtilisateurLivreSupport(UtilisateurLivreSupport UtilisateurLivreSupport)
        {
            context.UtilisateurLivreSupport.Add(UtilisateurLivreSupport);
        }

        public void DeleteUtilisateurLivreSupport(int UtilisateurLivreSupportId)
        {
            UtilisateurLivreSupport UtilisateurLivreSupport = context.UtilisateurLivreSupport.Find(UtilisateurLivreSupportId);
            context.UtilisateurLivreSupport.Remove(UtilisateurLivreSupport);
        }

        public void UpdateUtilisateurLivreSupport(UtilisateurLivreSupport UtilisateurLivreSupport)
        {
            context.Entry(UtilisateurLivreSupport).State = EntityState.Modified;
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