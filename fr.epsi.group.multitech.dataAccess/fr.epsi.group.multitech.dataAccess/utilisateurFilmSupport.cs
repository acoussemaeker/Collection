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
    
    public partial class utilisateurFilmSupport
    {
        public int utilisateurID { get; set; }
        public int FilmID { get; set; }
        public Nullable<int> SupportFilmID { get; set; }
    
        public virtual Film Film { get; set; }
        public virtual Supportfilm Supportfilm { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}
