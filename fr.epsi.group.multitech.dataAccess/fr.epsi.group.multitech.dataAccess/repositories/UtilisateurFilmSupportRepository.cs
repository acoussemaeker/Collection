using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    class UtilisateurFilmSupportRepository : IDisposable
    {
        private CollectionEntities context;
        private bool disposed = false;

        public UtilisateurFilmSupportRepository(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<UtilisateurFilmSupport> GetUtilisateurFilmSupport()
        {
            return context.UtilisateurFilmSupport.ToList();
        }

        public UtilisateurFilmSupport GetUtilisateurFilmSupportByID(int UtilisateurFilmSupportId)
        {
            return context.UtilisateurFilmSupport.Find(UtilisateurFilmSupportId);
        }

        public void InsertUtilisateurFilmSupport(UtilisateurFilmSupport UtilisateurFilmSupport)
        {
            context.UtilisateurFilmSupport.Add(UtilisateurFilmSupport);
        }

        public void DeleteUtilisateurFilmSupport(int UtilisateurFilmSupportId)
        {
            UtilisateurFilmSupport UtilisateurFilmSupport = context.UtilisateurFilmSupport.Find(UtilisateurFilmSupportId);
            context.UtilisateurFilmSupport.Remove(UtilisateurFilmSupport);
        }

        public void UpdateUtilisateurFilmSupport(UtilisateurFilmSupport UtilisateurFilmSupport)
        {
            context.Entry(UtilisateurFilmSupport).State = EntityState.Modified;
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