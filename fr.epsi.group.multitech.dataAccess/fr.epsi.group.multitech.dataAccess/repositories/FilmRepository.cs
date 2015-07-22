using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    public class FilmRepository : IDisposable
    {
        private CollectionEntities context;
        private bool disposed = false;
        
        public FilmRepository(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<Film> GetFilms()
        {
            return context.Film.ToList();
        }

        public Film GetFilmByID(int FilmId)
        {
            return context.Film.Find(FilmId);
        }

        public void InsertFilm(Film film)
        {
            context.Film.Add(film);
        }

        public void DeleteFilm(int filmId)
        {
            Film film = context.Film.Find(filmId);
            context.Film.Remove(film);
        }

        public void UpdateFilm(Film film)
        {
            context.Entry(film).State = EntityState.Modified;
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
