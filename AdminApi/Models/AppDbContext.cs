﻿using AdminApi.Models.App.Banner;
using AdminApi.Models.App.Bhaktas;
using AdminApi.Models.App.Booking;
using AdminApi.Models.App.Categories;
using AdminApi.Models.App.Checkouts;
using AdminApi.Models.App.Feedbacks;
using AdminApi.Models.App.LiveTest;
using AdminApi.Models.App.Location;
using AdminApi.Models.App.Orders;
using AdminApi.Models.App.Pandits;
using AdminApi.Models.App.PoojaCategory;
using AdminApi.Models.App.PoojaCategoryItems;
using AdminApi.Models.App.Products;
using AdminApi.Models.App.PushNotifications;
using AdminApi.Models.App.Questions;
using AdminApi.Models.App.Temples;
using AdminApi.Models.Helper;
using AdminApi.Models.Menu;
using AdminApi.Models.User;
using Microsoft.EntityFrameworkCore;

namespace AdminApi.Models
{
    public class AppDbContext:DbContext
    {     
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<LogHistory> LogHistory { get; set; }
        public virtual DbSet<AppMenu> Menu { get; set; }
        public virtual DbSet<MenuGroup> MenuGroup { get; set; }
        public virtual DbSet<MenuGroupWiseMenuMapping> MenuGroupWiseMenuMapping { get; set; }


        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Temple> Temples { get; set; }
        public virtual DbSet<Pandit> Pandits { get; set; }
        public virtual DbSet<Bhakta> Bhaktas { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionMapping> QuestionMappings { get; set; }
        public virtual DbSet<LiveTest> LiveTests { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<PoojaCategoryType> PoojaCategoryTypes { get; set; }
        public virtual DbSet<PoojaCategory> PoojaCategories { get; set; }
        public virtual DbSet<PoojaCategoryMapping> PoojaCategoryMappings { get; set; }
       
        public virtual DbSet<PoojaCategoryItem> PoojaCategoryItems { get; set; }
        public virtual DbSet<PushNotification> PushNotifications { get; set; }

        public virtual DbSet<Category> Categories { get; set; } 
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Checkout> Checkouts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<SubCategory> SubCategorys { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            modelBuilder.Seed();//use this for Sql server,Mysql,Sqlite and PostgreSql
                                //modelBuilder.SeedOracle();//use this only for Oracle
            #region 


            modelBuilder.Entity<Country>()
              .Property(s => s.CreatedOn)
              .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Country>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();

            modelBuilder.Entity<State>()
             .Property(s => s.CreatedOn)
             .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<State>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();


            modelBuilder.Entity<City>()
           .Property(s => s.CreatedOn)
           .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<City>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();


            modelBuilder.Entity<Temple>()
         .Property(s => s.CreatedOn)
         .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Temple>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();

            modelBuilder.Entity<Pandit>()
        .Property(s => s.CreatedOn)
        .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Pandit>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();


            modelBuilder.Entity<Bhakta>()
       .Property(s => s.CreatedOn)
       .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Bhakta>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();

			modelBuilder.Entity<PoojaCategory>()
	  .Property(s => s.CreatedOn)
	  .HasDefaultValue(System.DateTime.Now);

			modelBuilder.Entity<PoojaCategory>()
			  .Property(s => s.IsDeleted)
			  .HasDefaultValue(false)
			  .ValueGeneratedNever();

            modelBuilder.Entity<PoojaCategoryType>()
      .Property(s => s.CreatedOn)
      .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<PoojaCategoryType>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();


            modelBuilder.Entity<PoojaCategoryMapping>()
 .Property(s => s.CreatedOn)
 .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<PoojaCategoryMapping>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();


            modelBuilder.Entity<Feedback>()
      .Property(s => s.CreatedOn)
      .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Feedback>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();

            modelBuilder.Entity<Question>()
      .Property(s => s.CreatedOn)
      .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Question>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();

            modelBuilder.Entity<QuestionMapping>()
.Property(s => s.CreatedOn)
.HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<QuestionMapping>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();

            modelBuilder.Entity<LiveTest>()
      .Property(s => s.CreatedOn)
      .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<LiveTest>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();

            modelBuilder.Entity<Booking>()
    .Property(s => s.CreatedOn)
    .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Booking>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();


            modelBuilder.Entity<PoojaCategoryItem>()
 .Property(s => s.CreatedOn)
 .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<PoojaCategoryItem>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();


            modelBuilder.Entity<PushNotification>()
 .Property(s => s.CreatedOn)
 .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<PushNotification>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();

            modelBuilder.Entity<Category>()
 .Property(s => s.CreatedOn)
 .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Category>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();

            modelBuilder.Entity<Product>()
.Property(s => s.CreatedOn)
.HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Product>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();

            modelBuilder.Entity<Checkout>()
.Property(s => s.CreatedOn)
.HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Checkout>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();



            modelBuilder.Entity<Order>()
.Property(s => s.CreatedOn)
.HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Order>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();

            modelBuilder.Entity<OrderItem>()
.Property(s => s.CreatedOn)
.HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<OrderItem>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();

            modelBuilder.Entity<Banner>()
.Property(s => s.CreatedOn)
.HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Banner>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();
            #endregion
        }

    }
}
