using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    class GenreLivre: IGenreLivre, IDisposable
    {
        private CollectionEntities context;
        private bool disposed = false;

        public GenreLivre(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<GenreLivre> GetGenreLivre()
        {
            return context.GenreLivre.ToList();
        }

        public GenreLivre GetGenreLivreByID(int GenreLivreId)
        {
            return context.GenreLivre.Find(GenreLivreId);
        }

        public void InsertGenreLivre(GenreLivre genreLivre)
        {
            context.GenreLivre.Add(genreLivre);
        }

        public void DeleteGenreLivre(int genreLivreId)
        {
            GenreLivre genreLivre = context.GenreLivre.Find(genreLivreId);
            context.GenreLivre.Remove(genreLivre);
        }

        public void UpdateGenreLivre(GenreLivre genreLivre)
        {
            context.Entry(genreLivre).State = EntityState.Modified;
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