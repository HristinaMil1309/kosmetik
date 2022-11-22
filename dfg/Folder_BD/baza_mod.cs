using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace dfg.Folder_BD
{
    public partial class baza_mod : DbContext
    {
        public baza_mod()
            : base("name=baza_mod_con")
        {
        }

        public virtual DbSet<Basket> Basket { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Ed_izmerenia> Ed_izmerenia { get; set; }
        public virtual DbSet<Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Order_composition> Order_composition { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.id_category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ed_izmerenia>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Ed_izmerenia)
                .HasForeignKey(e => e.id_ed_izmerenia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Manufacturer)
                .HasForeignKey(e => e.id_manufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Basket)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.id_order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Order_composition1)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.id_order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Basket)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.id_products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Order_composition)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.id_products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Roles>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.id_Roles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Supplier)
                .HasForeignKey(e => e.id_supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Basket)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.id_users)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Order)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.id_user);
        }
    }
}
