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
    
    public partial class UtilisateurJeuxSupport
    {
        public int id { get; set; }
        public int utilisateurID { get; set; }
        public int jeuxID { get; set; }
        public int supportJeuxID { get; set; }
    
        public virtual Jeux Jeux { get; set; }
        public virtual Supportjeux Supportjeux { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
