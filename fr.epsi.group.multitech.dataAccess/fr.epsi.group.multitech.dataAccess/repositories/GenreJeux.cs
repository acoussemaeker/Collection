using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    class GenreJeuxRepository : IDisposable
    {
        private CollectionEntities context;
        private bool disposed = false;

        public GenreJeuxRepository(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<GenreJeux> GetGenreJeux()
        {
            return context.GenreJeux.ToList();
        }

        public GenreJeux GetGenreJeuxByID(int GenreJeuxId)
        {
            return context.GenreJeux.Find(GenreJeuxId);
        }

        public void InsertGenreJeux(GenreJeux genreJeux)
        {
            context.GenreJeux.Add(genreJeux);
        }

        public void DeleteGenreJeux(int genreJeuxId)
        {
            GenreJeux genreJeux = context.GenreJeux.Find(genreJeuxId);
            context.GenreJeux.Remove(genreJeux);
        }

        public void UpdateGenreJeux(GenreJeux genreJeux)
        {
            context.Entry(genreJeux).State = EntityState.Modified;
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
