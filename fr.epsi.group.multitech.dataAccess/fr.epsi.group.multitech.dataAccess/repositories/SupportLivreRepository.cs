using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    class SupportLivreRepository :  IDisposable
    {
       private CollectionEntities context;
        private bool disposed = false;

        public SupportLivreRepository(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<Supportlivre> GetSupportlivre()
        {
            return context.Supportlivre.ToList();
        }

        public Supportlivre GetSupportlivreByID(int SupportlivreId)
        {
            return context.Supportlivre.Find(SupportlivreId);
        }

        public void InsertSupportlivre(Supportlivre Supportlivre)
        {
            context.Supportlivre.Add(Supportlivre);
        }

        public void DeleteSupportlivre(int SupportlivreId)
        {
            Supportlivre Supportlivre = context.Supportlivre.Find(SupportlivreId);
            context.Supportlivre.Remove(Supportlivre);
        }

        public void UpdateSupportlivre(Supportlivre Supportlivre)
        {
            context.Entry(Supportlivre).State = EntityState.Modified;
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

