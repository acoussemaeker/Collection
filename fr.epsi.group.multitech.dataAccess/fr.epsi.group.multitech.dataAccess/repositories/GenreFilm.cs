using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    class GenreFilmRepository : IGenreFilm, IDisposable
    {
        private CollectionEntities context;
        private bool disposed = false;

        public GenreFilmRepository(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<GenreFilm> GetGenreFilm()
        {
            return context.GenreFilm.ToList();
        }

        public GenreFilm GetGenreFilmByID(int GenreFilmId)
        {
            return context.GenreFilm.Find(GenreFilmId);
        }

        public void InsertGenreFilm(GenreFilm genreFilm)
        {
            context.GenreFilm.Add(genreFilm);
        }

        public void DeleteGenreFilm(int genreFilmId)
        {
            GenreFilm genreFilm = context.GenreFilm.Find(genreFilmId);
            context.GenreFilm.Remove(genreFilm);
        }

        public void UpdateGenreFilm(GenreFilm genreFilm)
        {
            context.Entry(genreFilm).State = EntityState.Modified;
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

