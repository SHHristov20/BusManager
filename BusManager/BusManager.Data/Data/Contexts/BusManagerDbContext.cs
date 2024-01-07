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

        public BusManagerDbContext(DbContextOptions<BusManagerDbContext> options) : base(options)
        {
            Database.EnsureCreated();
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

            // Seed UserTypes
            modelBuilder.Entity<UserType>().HasData(
                new() { Id = 1, Name = "User" },
                new() { Id = 2, Name = "Driver" },
                new() { Id = 3, Name = "Staff" },
                new() { Id = 4, Name = "Manager" },
                new() { Id = 5, Name = "Admin" }
            );
        }
    }
}
