//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fr.epsi.group.multitech.dataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            this.utilisateurFilmSupport = new HashSet<utilisateurFilmSupport>();
            this.UtilisateurJeuxSupport = new HashSet<UtilisateurJeuxSupport>();
            this.UtilisateurLivreSupport = new HashSet<UtilisateurLivreSupport>();
        }
    
        public int id { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse { get; set; }
        public decimal codepostal { get; set; }
        public string ville { get; set; }
    
        public virtual ICollection<utilisateurFilmSupport> utilisateurFilmSupport { get; set; }
        public virtual ICollection<UtilisateurJeuxSupport> UtilisateurJeuxSupport { get; set; }
        public virtual ICollection<UtilisateurLivreSupport> UtilisateurLivreSupport { get; set; }
    }
}
