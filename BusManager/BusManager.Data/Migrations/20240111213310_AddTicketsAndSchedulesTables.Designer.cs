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
    [Migration("20240111213310_AddTicketsAndSchedulesTables")]
    partial class AddTicketsAndSchedulesTables
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