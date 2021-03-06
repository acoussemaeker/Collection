﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    class SupportJeuxRepository : IDisposable
    {
       private CollectionEntities context;
        private bool disposed = false;

        public SupportJeuxRepository(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<Supportjeux> GetSupportSupportjeux()
        {
            return context.Supportjeux.ToList();
        }

        public Supportjeux GetSupportjeuxByID(int SupportjeuxId)
        {
            return context.Supportjeux.Find(SupportjeuxId);
        }

        public void InsertSupportjeux(Supportjeux supportjeux)
        {
            context.Supportjeux.Add(supportjeux);
        }

        public void DeleteSupportjeux(int supportjeuxId)
        {
            Supportjeux supportjeux = context.Supportjeux.Find(supportjeuxId);
            context.Supportjeux.Remove(supportjeux);
        }

        public void UpdateSupportjeux(Supportjeux supportjeux)
        {
            context.Entry(supportjeux).State = EntityState.Modified;
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
