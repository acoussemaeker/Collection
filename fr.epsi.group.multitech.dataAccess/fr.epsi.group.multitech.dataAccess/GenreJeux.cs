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
    
    public partial class GenreJeux
    {
        public GenreJeux()
        {
            this.Jeux = new HashSet<Jeux>();
        }
    
        public int id { get; set; }
        public string nom { get; set; }
    
        public virtual ICollection<Jeux> Jeux { get; set; }
    }
}
