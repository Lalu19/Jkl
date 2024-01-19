using AdminApi.Models.Helper;
using AdminApi.Models.Menu;
using AdminApi.Models.User;
using Microsoft.EntityFrameworkCore;
using AdminApi;
using AdminApi.Models;
using AdminApi.Models.App;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public virtual DbSet<HospitalMaster> HospitalMasters { get; set; }
        public virtual DbSet<BedMaster> BedMasters { get; set; }
        public virtual DbSet<DieticianMaster>DieticianMasters { get; set; }
        public virtual DbSet<DIETMaster>DIETMasters { get; set; }
        public virtual DbSet<FoodProviderLogin>FoodProviderLogins { get; set; }
        public virtual DbSet<PatientType>PatientType { get; set; }
        public virtual DbSet<FoodServiceType> FoodServiceType { get; set; }
        public virtual DbSet<DietType> DietType { get; set; }
        public virtual DbSet<Supervisor> Supervisor { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   

            modelBuilder.Seed();//use this for Sql server,Mysql,Sqlite and PostgreSql
            //modelBuilder.SeedOracle();//use this only for Oracle
            #region 

            //Hospital

          modelBuilder.Entity<HospitalMaster>()
            .Property(s => s.CreatedOn)
            .HasDefaultValue(System.DateTime.Now);

          modelBuilder.Entity<HospitalMaster>()
            .Property(s => s.IsDeleted)
            .HasDefaultValue(false)
            .ValueGeneratedNever();

            //Bed

            modelBuilder.Entity<BedMaster>()
                .Property(s => s.CreatedOn)
                .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<BedMaster>()
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false)
                .ValueGeneratedNever();

            //Dietician Master

            modelBuilder.Entity<DieticianMaster>()
               .Property(s => s.CreatedOn)
               .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<DieticianMaster>()
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false)
                .ValueGeneratedNever();

            //Diet Master
            modelBuilder.Entity<DIETMaster>()
                .Property(s => s.CreatedOn)
                .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<DIETMaster>()
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false)
                .ValueGeneratedNever();
            

            //FoodProvider Login
            modelBuilder.Entity<FoodProviderLogin>()
                .Property(s => s.CreatedOn)
                .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<FoodProviderLogin>()
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false)
                .ValueGeneratedNever();


            //PatientType
            modelBuilder.Entity<PatientType>()
               .Property(s => s.CreatedOn)
               .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<PatientType>()
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false)
                .ValueGeneratedNever();

            //FoodServiceType
            modelBuilder.Entity<FoodServiceType>()
               .Property(s => s.CreatedOn)
               .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<FoodServiceType>()
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false)
                .ValueGeneratedNever();
            //DietType
            modelBuilder.Entity<DietType>()
              .Property(s => s.CreatedOn)
              .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<DietType>()
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false)
                .ValueGeneratedNever();

            //Supervisor

            modelBuilder.Entity<Supervisor>()
              .Property(s => s.CreatedOn)
              .HasDefaultValue(System.DateTime.Now);

            modelBuilder.Entity<Supervisor>()
                .Property(s => s.IsDeleted)
                .HasDefaultValue(false)
                .ValueGeneratedNever();

            #endregion
        }

    }
}
