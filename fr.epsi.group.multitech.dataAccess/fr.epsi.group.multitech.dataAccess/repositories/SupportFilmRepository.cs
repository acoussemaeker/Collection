using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    class SupportfilmRepository  : ISupportFilmRepository, IDisposable
    {
       private CollectionEntities context;
        private bool disposed = false;

        public SupportfilmRepository(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<Supportfilm> GetSupportSupportfilm()
        {
            return context.Supportfilm.ToList();
        }

        public Supportfilm GetSupportfilmByID(int SupportfilmId)
        {
            return context.Supportfilm.Find(SupportfilmId);
        }

        public void InsertSupportfilm(Supportfilm supportfilm)
        {
            context.Supportfilm.Add(supportfilm);
        }

        public void DeleteSupportfilm(int supportfilmId)
        {
            Supportfilm supportfilm = context.Supportfilm.Find(supportfilmId);
            context.Supportfilm.Remove(supportfilm);
        }

        public void UpdateSupportfilm(Supportfilm supportfilm)
        {
            context.Entry(supportfilm).State = EntityState.Modified;
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

