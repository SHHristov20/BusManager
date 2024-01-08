using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManager.Data.Data.Contexts
{
    public class BusManagerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Station> Stations { get; set; }

        public BusManagerDbContext() { }
        public BusManagerDbContext(DbContextOptions<BusManagerDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BusManager;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .Property(x => x.Id)
                .UseIdentityColumn();

            modelBuilder.Entity<UserType>()
                .Property(x => x.Id)
                .UseIdentityColumn();

            modelBuilder.Entity<User>()
                .HasOne(u => u.UserType)        // User has one UserType
                .WithMany(ut => ut.Users)       // UserType has many Users
                .HasForeignKey(u => u.UserTypeId) // Foreign key property in User entity
                .IsRequired();

            modelBuilder.Entity<City>()
                .Property(x => x.Id)
                .UseIdentityColumn();

            modelBuilder.Entity<Station>()
                .HasOne(s => s.City)
                .WithMany(c => c.Stations)
                .HasForeignKey(s => s.CityId)
                .IsRequired();

            SeedUserTypes(modelBuilder);
            SeedCities(modelBuilder);
        }

        void SeedUserTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserType>().HasData(
                new() { Id = 1, Name = "User" },
                new() { Id = 2, Name = "Driver" },
                new() { Id = 3, Name = "Staff" },
                new() { Id = 4, Name = "Manager" },
                new() { Id = 5, Name = "Admin" }
            );
        }

        void SeedCities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City { Id = 1, Name = "Blagoevgrad" },
                new City { Id = 2, Name = "Burgas" },
                new City { Id = 3, Name = "Varna" },
                new City { Id = 4, Name = "Veliko Tarnovo" },
                new City { Id = 5, Name = "Vidin" },
                new City { Id = 6, Name = "Vraca" },
                new City { Id = 7, Name = "Gabrovo" },
                new City { Id = 8, Name = "Dobrich" },
                new City { Id = 9, Name = "Kardzali" },
                new City { Id = 10, Name = "Kyustendil" },
                new City { Id = 11, Name = "Lovech" },
                new City { Id = 12, Name = "Montana" },
                new City { Id = 13, Name = "Pazardzhik" },
                new City { Id = 14, Name = "Pernik" },
                new City { Id = 15, Name = "Pleven" },
                new City { Id = 16, Name = "Plovdiv" },
                new City { Id = 17, Name = "Razgrad" },
                new City { Id = 18, Name = "Ruse" },
                new City { Id = 19, Name = "Silistra" },
                new City { Id = 20, Name = "Sliven" },
                new City { Id = 21, Name = "Smolyan" },
                new City { Id = 22, Name = "Sofia" },
                new City { Id = 23, Name = "Stara Zagora" },
                new City { Id = 24, Name = "Targovishte" },
                new City { Id = 25, Name = "Haskovo" },
                new City { Id = 26, Name = "Shumen" },
                new City { Id = 27, Name = "Yambol" }
            );
            
        }
    }
}
