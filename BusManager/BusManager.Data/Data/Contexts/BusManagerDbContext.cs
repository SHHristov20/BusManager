using BusManager.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BusManager.Data.Data.Contexts
{
    public class BusManagerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

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

            modelBuilder.Entity<City>()
                .Property(x => x.Id)
                .UseIdentityColumn();

            modelBuilder.Entity<Station>()
                .Property(x => x.Id)
                .UseIdentityColumn();

            modelBuilder.Entity<Schedule>()
                .Property(x => x.Id)
                .UseIdentityColumn();

            modelBuilder.Entity<Ticket>()
                .Property(x => x.Id)
                .UseIdentityColumn();


            modelBuilder.Entity<User>()
                .HasOne(u => u.UserType)
                .WithMany(ut => ut.Users)
                .HasForeignKey(u => u.UserTypeId)
                .IsRequired();

            modelBuilder.Entity<Station>()
                .HasOne(s => s.City)
                .WithMany(c => c.Stations)
                .HasForeignKey(s => s.CityId)
                .IsRequired();

            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.FromStation)
                .WithMany(fs => fs.SchedulesFrom)
                .HasForeignKey(s => s.FromStationId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.ToStation)
                .WithMany(ts => ts.SchedulesTo)
                .HasForeignKey(s => s.ToStationId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Buyer)
                .WithMany(b => b.Tickets)
                .HasForeignKey(b => b.BuyerId)
                .IsRequired();

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Schedule) 
                .WithMany(s => s.Tickets)
                .HasForeignKey(s => s.ScheduleId)
                .IsRequired();

            SeedUserTypes(modelBuilder);
            SeedUsers(modelBuilder);
            SeedCities(modelBuilder);
            SeedStations(modelBuilder);
            SeedSchedules(modelBuilder);
        }

        void SeedUserTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserType>().HasData(
                new() { Id = 1, Name = "User" },
                new() { Id = 2, Name = "Staff" },
                new() { Id = 3, Name = "Admin" }
            );
        }
        void SeedUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new() { Id = 1, FirstName = "Admin", LastName = "Admin", Email = "admin", Password = "$2a$04$srEq7x2/m/gNjDV1BiOKYuozaHzx8uCiRFto/.y7hW4aUXyAsEKg2", UserTypeId = 3 },
                new() { Id = 2, FirstName = "Staff", LastName = "Staff", Email = "staff", Password = "$2a$04$DDXAkQvGT/HO2wYk6I81uOVNnFxvGFRUrKiwkSj2dVGw7UzBFegHy", UserTypeId = 2 },
                new() { Id = 3, FirstName = "User", LastName = "User", Email = "user", Password = "$2a$04$aTQazmIdabP6cV/VkbeyQuDV.eVX0lwE7x17dF6TmBN38aI3jDO0q", UserTypeId = 1 }
            );
        }
        void SeedCities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new() { Id = 1, Name = "Blagoevgrad" },
                new() { Id = 2, Name = "Burgas" },
                new() { Id = 3, Name = "Varna" },
                new() { Id = 4, Name = "Veliko Tarnovo" },
                new() { Id = 5, Name = "Vidin" },
                new() { Id = 6, Name = "Vraca" },
                new() { Id = 7, Name = "Gabrovo" },
                new() { Id = 8, Name = "Dobrich" },
                new() { Id = 9, Name = "Kardzali" },
                new() { Id = 10, Name = "Kyustendil" },
                new() { Id = 11, Name = "Lovech" },
                new() { Id = 12, Name = "Montana" },
                new() { Id = 13, Name = "Pazardzhik" },
                new() { Id = 14, Name = "Pernik" },
                new() { Id = 15, Name = "Pleven" },
                new() { Id = 16, Name = "Plovdiv" },
                new() { Id = 17, Name = "Razgrad" },
                new() { Id = 18, Name = "Ruse" },
                new() { Id = 19, Name = "Silistra" },
                new() { Id = 20, Name = "Sliven" },
                new() { Id = 21, Name = "Smolyan" },
                new() { Id = 22, Name = "Sofia" },
                new() { Id = 23, Name = "Stara Zagora" },
                new() { Id = 24, Name = "Targovishte" },
                new() { Id = 25, Name = "Haskovo" },
                new() { Id = 26, Name = "Shumen" },
                new() { Id = 27, Name = "Yambol" }
            );
        }
        void SeedStations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Station>().HasData(
                new() { Id = 1, Name = "South Bus Station", Address = "pl. Tsaritsa Yoanna", CityId = 2 },
                new() { Id = 2, Name = "Central Bus Station", Address = "Blvd Knyagina Maria Luisa 100", CityId = 22 },
                new() { Id = 3, Name = "Central Bus Station", Address = "Blvd Vladislav Varnenchik 158", CityId = 3 }
            );
        }
        void SeedSchedules(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Schedule>().HasData(
                new() { Id = 1, FromStationId = 1, ToStationId = 3, Price = 14, Time = new DateTime(2024, 1, 17, 17, 30, 0) },
                new() { Id = 2, FromStationId = 3, ToStationId = 1, Price = 14, Time = new DateTime(2024, 1, 17, 15, 40, 0) },
                new() { Id = 3, FromStationId = 1, ToStationId = 2, Price = 30, Time = new DateTime(2024, 1, 17, 18, 10, 0) },
                new() { Id = 4, FromStationId = 2, ToStationId = 1, Price = 30, Time = new DateTime(2024, 1, 18, 19, 10, 0) },
                new() { Id = 5, FromStationId = 1, ToStationId = 3, Price = 14, Time = new DateTime(2024, 1, 18, 21, 0, 0) },
                new() { Id = 6, FromStationId = 3, ToStationId = 1, Price = 14, Time = new DateTime(2024, 1, 18, 17, 35, 0) },
                new() { Id = 7, FromStationId = 1, ToStationId = 2, Price = 30, Time = new DateTime(2024, 1, 19, 16, 50, 0) },
                new() { Id = 8, FromStationId = 2, ToStationId = 1, Price = 30, Time = new DateTime(2024, 1, 19, 20, 10, 0) }
            );
        }
    }
}
