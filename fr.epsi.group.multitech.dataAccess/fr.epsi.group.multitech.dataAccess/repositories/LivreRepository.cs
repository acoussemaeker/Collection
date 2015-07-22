using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    public class LivreRepository : IDisposable
    {
        private CollectionEntities context;
        private bool disposed = false;

        public LivreRepository(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<Livre> GetLivres()
        {
            return context.Livre.ToList();
        }

        public Livre GetLivreByID(int LivreId)
        {
            return context.Livre.Find(LivreId);
        }

        public void InsertLivre(Livre livre)
        {
            context.Livre.Add(livre);
        }

        public void DeleteLivre(int livreId)
        {
            Livre livre = context.Livre.Find(livreId);
            context.Livre.Remove(livre);
        }

        public void UpdateLivre(Livre livre)
        {
            context.Entry(livre).State = EntityState.Modified;
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

