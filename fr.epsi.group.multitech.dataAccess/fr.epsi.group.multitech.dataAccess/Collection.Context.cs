﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CollectionEntities : DbContext
    {
        public CollectionEntities()
            : base("name=CollectionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<GenreFilm> GenreFilm { get; set; }
        public virtual DbSet<GenreJeux> GenreJeux { get; set; }
        public virtual DbSet<GenreLivre> GenreLivre { get; set; }
        public virtual DbSet<Jeux> Jeux { get; set; }
        public virtual DbSet<Livre> Livre { get; set; }
        public virtual DbSet<Supportfilm> Supportfilm { get; set; }
        public virtual DbSet<Supportjeux> Supportjeux { get; set; }
        public virtual DbSet<Supportlivre> Supportlivre { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
        public virtual DbSet<UtilisateurFilmSupport> UtilisateurFilmSupport { get; set; }
        public virtual DbSet<UtilisateurJeuxSupport> UtilisateurJeuxSupport { get; set; }
        public virtual DbSet<UtilisateurLivreSupport> UtilisateurLivreSupport { get; set; }
    }
}
