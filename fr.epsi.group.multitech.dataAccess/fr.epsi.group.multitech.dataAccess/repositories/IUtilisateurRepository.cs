using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fr.epsi.group.multitech.dataAccess.repositories
{
    interface IUtilisateurRepository : IDisposable
    {
        IEnumerable<Utilisateur> GetUtilisateur();
        Utilisateur GetUtilisateurByID(int UtilisateurId);
        void InsertUtilisateur(Utilisateur utilisateur);
        void DeleteUtilisateur(int utilisateurId);
        void UpdateUtilisateur(Utilisateur utilisateur);
        void Save();
    }
}