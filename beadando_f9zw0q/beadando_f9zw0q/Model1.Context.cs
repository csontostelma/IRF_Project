﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace beadando_f9zw0q
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class adatbazisEntities : DbContext
    {
        public adatbazisEntities()
            : base("name=adatbazisconnectionstring")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Fazon> Fazon { get; set; }
        public virtual DbSet<Méret> Méret { get; set; }
        public virtual DbSet<Rendelés> Rendelés { get; set; }
        public virtual DbSet<Ruhadarab> Ruhadarab { get; set; }
        public virtual DbSet<Szín> Szín { get; set; }
        public virtual DbSet<Termék> Termék { get; set; }
    }
}
