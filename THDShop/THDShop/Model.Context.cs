﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace THDShop
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLLaptopShopEntities : DbContext
    {
        public QLLaptopShopEntities()
            : base("name=QLLaptopShopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BILL> BILL { get; set; }
        public virtual DbSet<CATEGORIES> CATEGORIES { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMER { get; set; }
        public virtual DbSet<DE_BILL> DE_BILL { get; set; }
        public virtual DbSet<DE_ORDER> DE_ORDER { get; set; }
        public virtual DbSet<DELI_ADDRESS> DELI_ADDRESS { get; set; }
        public virtual DbSet<GIFT> GIFT { get; set; }
        public virtual DbSet<MYGIFT> MYGIFT { get; set; }
        public virtual DbSet<ORDERS> ORDERS { get; set; }
        public virtual DbSet<PRODUCTS> PRODUCTS { get; set; }
        public virtual DbSet<ROLES> ROLES { get; set; }
        public virtual DbSet<STAFF> STAFF { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }

        public System.Data.Entity.DbSet<THDShop.ViewModel.Category.CategoryDTO> CategoryDTOes { get; set; }
    }
}