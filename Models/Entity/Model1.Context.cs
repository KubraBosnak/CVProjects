﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CvProject.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbCVEntities : DbContext
    {
        public DbCVEntities()
            : base("name=DbCVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblAdmin> TblAdmin { get; set; }
        public virtual DbSet<TblDeneyimlerim> TblDeneyimlerim { get; set; }
        public virtual DbSet<TblEgitimlerim> TblEgitimlerim { get; set; }
        public virtual DbSet<TblHakkinda> TblHakkinda { get; set; }
        public virtual DbSet<TblHobilerim> TblHobilerim { get; set; }
        public virtual DbSet<TblIletisim> TblIletisim { get; set; }
        public virtual DbSet<TblSertifikalarım> TblSertifikalarım { get; set; }
        public virtual DbSet<TblYeteneklerim> TblYeteneklerim { get; set; }
        public virtual DbSet<TblSosyalMedya> TblSosyalMedya { get; set; }
    }
}
