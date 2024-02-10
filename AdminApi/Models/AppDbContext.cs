using AdminApi.Models.App.Bhaktas;
using AdminApi.Models.App.Feedbacks;
using AdminApi.Models.App.Location;
using AdminApi.Models.App.Pandits;
using AdminApi.Models.App.PoojaCategory;
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
        public virtual DbSet<PoojaCategory> PoojaCategories { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        


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

            modelBuilder.Entity<Feedback>()
      .Property(s => s.CreatedOn)
      .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Feedback>()
              .Property(s => s.IsDeleted)
              .HasDefaultValue(false)
              .ValueGeneratedNever();



            #endregion
        }

    }
}
