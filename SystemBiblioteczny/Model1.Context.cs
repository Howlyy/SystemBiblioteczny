﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SystemBiblioteczny
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    /// <summary>
    /// Klasa uzyskania dostepu do danych. Framework Entity
    /// </summary>
    public partial class SystemBibliotecznyEntities123 : DbContext
    {
        public SystemBibliotecznyEntities123()
            : base("name=SystemBibliotecznyEntities123")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
    }
}
