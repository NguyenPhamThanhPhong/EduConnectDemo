﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EduConnectApp.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EduConnectEntities : DbContext
    {
        public EduConnectEntities()
            : base("name=EduConnectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ADMIN> ADMINs { get; set; }
        public virtual DbSet<GIANGDAY> GIANGDAYs { get; set; }
        public virtual DbSet<GIAOVIEN> GIAOVIENs { get; set; }
        public virtual DbSet<HOCSINH> HOCSINHs { get; set; }
        public virtual DbSet<HOCTAP> HOCTAPs { get; set; }
        public virtual DbSet<KETQUA> KETQUAs { get; set; }
        public virtual DbSet<KHOI> KHOIs { get; set; }
        public virtual DbSet<LOAIDIEM> LOAIDIEMs { get; set; }
        public virtual DbSet<LOGIN> LOGINs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<NHANXET> NHANXETs { get; set; }
        public virtual DbSet<PHUHUYNH> PHUHUYNHs { get; set; }
        public virtual DbSet<TBMON> TBMONs { get; set; }
        public virtual DbSet<THANHTICH> THANHTICHes { get; set; }
        public virtual DbSet<THI> THIs { get; set; }
        public virtual DbSet<TO1> TO1 { get; set; }
    }
}
