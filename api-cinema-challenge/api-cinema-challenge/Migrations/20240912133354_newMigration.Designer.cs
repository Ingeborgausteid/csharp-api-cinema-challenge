﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20240912133354_newMigration")]
    partial class newMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated");

                    b.HasKey("Id");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1649),
                            Email = "roger@rogan.com",
                            Name = "Roger Rogan",
                            Phone = "+44729389128",
                            UpdatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1649)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1651),
                            Email = "chris@muse.mu",
                            Name = "Chris Wolstenholme",
                            Phone = "+44729388192",
                            UpdatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1651)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1653),
                            Email = "lisa@timber.com",
                            Name = "Lisa Timber",
                            Phone = "+47123456789",
                            UpdatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1653)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<int>("RuntimeMinutes")
                        .HasColumnType("integer")
                        .HasColumnName("runtimeMinutes");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated");

                    b.HasKey("Id");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1672),
                            Description = "The greatest movie ever made.",
                            Rating = "PG-13",
                            RuntimeMinutes = 126,
                            Title = "Dodgeball",
                            UpdatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1672)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1674),
                            Description = "The story of a lifetime.",
                            Rating = "PG-13",
                            RuntimeMinutes = 142,
                            Title = "Forrest Gump",
                            UpdatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1675)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("movieid");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screenNumber");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated");

                    b.HasKey("Id");

                    b.ToTable("screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 40,
                            CreatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1686),
                            MovieId = 1,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 9, 14, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1681),
                            UpdatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1686)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 80,
                            CreatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1688),
                            MovieId = 2,
                            ScreenNumber = 4,
                            StartsAt = new DateTime(2024, 9, 13, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1688),
                            UpdatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1689)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customerid");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screeningid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created");

                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<int>("NumSeats")
                        .HasColumnType("integer")
                        .HasColumnName("numSeats");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated");

                    b.HasKey("CustomerId", "ScreeningId");

                    b.ToTable("tickets");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            ScreeningId = 1,
                            CreatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1693),
                            Id = 1,
                            NumSeats = 2,
                            UpdatedAt = new DateTime(2024, 9, 12, 13, 33, 54, 400, DateTimeKind.Utc).AddTicks(1693)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
