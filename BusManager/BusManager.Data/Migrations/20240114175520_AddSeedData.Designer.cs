﻿// <auto-generated />
using System;
using BusManager.Data.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusManager.Data.Migrations
{
    [DbContext(typeof(BusManagerDbContext))]
    [Migration("20240114175520_AddSeedData")]
    partial class AddSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusManager.Data.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Blagoevgrad"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Burgas"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Varna"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Veliko Tarnovo"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Vidin"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Vraca"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Gabrovo"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Dobrich"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Kardzali"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Kyustendil"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Lovech"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Montana"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Pazardzhik"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Pernik"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Pleven"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Plovdiv"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Razgrad"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Ruse"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Silistra"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Sliven"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Smolyan"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Sofia"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Stara Zagora"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Targovishte"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Haskovo"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Shumen"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Yambol"
                        });
                });

            modelBuilder.Entity("BusManager.Data.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FromStationId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("ToStationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FromStationId");

                    b.HasIndex("ToStationId");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FromStationId = 1,
                            Price = 14f,
                            Time = new DateTime(2024, 1, 17, 17, 30, 0, 0, DateTimeKind.Unspecified),
                            ToStationId = 3
                        },
                        new
                        {
                            Id = 2,
                            FromStationId = 3,
                            Price = 14f,
                            Time = new DateTime(2024, 1, 17, 15, 40, 0, 0, DateTimeKind.Unspecified),
                            ToStationId = 1
                        },
                        new
                        {
                            Id = 3,
                            FromStationId = 1,
                            Price = 30f,
                            Time = new DateTime(2024, 1, 17, 18, 10, 0, 0, DateTimeKind.Unspecified),
                            ToStationId = 2
                        },
                        new
                        {
                            Id = 4,
                            FromStationId = 2,
                            Price = 30f,
                            Time = new DateTime(2024, 1, 18, 19, 10, 0, 0, DateTimeKind.Unspecified),
                            ToStationId = 1
                        },
                        new
                        {
                            Id = 5,
                            FromStationId = 1,
                            Price = 14f,
                            Time = new DateTime(2024, 1, 18, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            ToStationId = 3
                        },
                        new
                        {
                            Id = 6,
                            FromStationId = 3,
                            Price = 14f,
                            Time = new DateTime(2024, 1, 18, 17, 35, 0, 0, DateTimeKind.Unspecified),
                            ToStationId = 1
                        },
                        new
                        {
                            Id = 7,
                            FromStationId = 1,
                            Price = 30f,
                            Time = new DateTime(2024, 1, 19, 16, 50, 0, 0, DateTimeKind.Unspecified),
                            ToStationId = 2
                        },
                        new
                        {
                            Id = 8,
                            FromStationId = 2,
                            Price = 30f,
                            Time = new DateTime(2024, 1, 19, 20, 10, 0, 0, DateTimeKind.Unspecified),
                            ToStationId = 1
                        });
                });

            modelBuilder.Entity("BusManager.Data.Models.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Stations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "pl. Tsaritsa Yoanna",
                            CityId = 2,
                            Name = "South Bus Station"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Blvd Knyagina Maria Luisa 100",
                            CityId = 22,
                            Name = "Central Bus Station"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Blvd Vladislav Varnenchik 158",
                            CityId = 3,
                            Name = "Central Bus Station"
                        });
                });

            modelBuilder.Entity("BusManager.Data.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuyerId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BusManager.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserTypeId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin",
                            FirstName = "Admin",
                            LastName = "Admin",
                            Password = "$2a$04$srEq7x2/m/gNjDV1BiOKYuozaHzx8uCiRFto/.y7hW4aUXyAsEKg2",
                            UserTypeId = 3
                        },
                        new
                        {
                            Id = 2,
                            Email = "staff",
                            FirstName = "Staff",
                            LastName = "Staff",
                            Password = "$2a$04$DDXAkQvGT/HO2wYk6I81uOVNnFxvGFRUrKiwkSj2dVGw7UzBFegHy",
                            UserTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "user",
                            FirstName = "User",
                            LastName = "User",
                            Password = "$2a$04$aTQazmIdabP6cV/VkbeyQuDV.eVX0lwE7x17dF6TmBN38aI3jDO0q",
                            UserTypeId = 1
                        });
                });

            modelBuilder.Entity("BusManager.Data.Models.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "User"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Staff"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("BusManager.Data.Models.Schedule", b =>
                {
                    b.HasOne("BusManager.Data.Models.Station", "FromStation")
                        .WithMany("SchedulesFrom")
                        .HasForeignKey("FromStationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusManager.Data.Models.Station", "ToStation")
                        .WithMany("SchedulesTo")
                        .HasForeignKey("ToStationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FromStation");

                    b.Navigation("ToStation");
                });

            modelBuilder.Entity("BusManager.Data.Models.Station", b =>
                {
                    b.HasOne("BusManager.Data.Models.City", "City")
                        .WithMany("Stations")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("BusManager.Data.Models.Ticket", b =>
                {
                    b.HasOne("BusManager.Data.Models.User", "Buyer")
                        .WithMany("Tickets")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusManager.Data.Models.Schedule", "Schedule")
                        .WithMany("Tickets")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("BusManager.Data.Models.User", b =>
                {
                    b.HasOne("BusManager.Data.Models.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("BusManager.Data.Models.City", b =>
                {
                    b.Navigation("Stations");
                });

            modelBuilder.Entity("BusManager.Data.Models.Schedule", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("BusManager.Data.Models.Station", b =>
                {
                    b.Navigation("SchedulesFrom");

                    b.Navigation("SchedulesTo");
                });

            modelBuilder.Entity("BusManager.Data.Models.User", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("BusManager.Data.Models.UserType", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}