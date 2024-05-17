using System;
using System.Collections.Generic;
using ApnaMakaanAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApnaMakaanAPI.DAL.DBContext
{
    public partial class ApnaMakaanDBContext : DbContext
    {

        public ApnaMakaanDBContext(DbContextOptions<ApnaMakaanDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<FurnishingType> FurnishingTypes { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<Property> Properties { get; set; } = null!;
        public virtual DbSet<PropertyType> PropertyTypes { get; set; } = null!;
        public virtual DbSet<user> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cityName");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FurnishingType>(entity =>
            {
                entity.ToTable("FurnishingType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FurnishingType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("furnishing_Type");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("imageURL");

                entity.Property(e => e.IsPrimary).HasColumnName("isPrimary");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Images__Property__440B1D61");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.ToTable("Property");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bhk).HasColumnName("BHK");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MainEnterance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAinEnterance");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("PostedON");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Property__CityId__412EB0B6");

                entity.HasOne(d => d.FurnishingType)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.FurnishingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Property__Furnis__403A8C7D");

                entity.HasOne(d => d.PropertyType)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.PropertyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Property__Proper__3F466844");

                entity.HasOne(d => d.UserNavigation)
                    .WithMany(p => p.Properties)
                    .HasForeignKey(d => d.User)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Property__User__3E52440B");
            });

            modelBuilder.Entity<PropertyType>(entity =>
            {
                entity.ToTable("PropertyType");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PropertyType1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("property_Type");
            });

            modelBuilder.Entity<user>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            SeedTheData(modelBuilder);

            OnModelCreatingPartial(modelBuilder);
        }

        private void SeedTheData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(SeedingInitialData.GetCity());
            modelBuilder.Entity<FurnishingType>()
                .HasData(SeedingInitialData.GetFurnishingType());
            modelBuilder.Entity<PropertyType>()
                .HasData(SeedingInitialData.GetPropertyType());
            modelBuilder.Entity<user>()
                .HasData(SeedingInitialData.GetUser());
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
