using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    class UtilisateurRepository
    {
        private CollectionEntities context;
        private bool disposed = false;
        
        public UtilisateurRepository(CollectionEntities context)
        {
            this.context = context;
        }

        public IEnumerable<Utilisateur> GetUtilisateurs()
        {
            return context.Utilisateur.ToList();
        }

        public Utilisateur GetUtilisateurByID(int UtilisateurId)
        {
            return context.Utilisateur.Find(UtilisateurId);
        }

        public void InsertUtilisateur(Utilisateur utilisateur)
        {
            context.Utilisateur.Add(utilisateur);
        }

        public void DeleteUtilisateur(int utilisateurId)
        {
            Utilisateur utilisateur = context.Utilisateur.Find(utilisateurId);
            context.Utilisateur.Remove(utilisateur);
        }

        public void UpdateUtilisateur(Utilisateur utilisateur)
        {
            context.Entry(utilisateur).State = EntityState.Modified;
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