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
    [Migration("20240209132434_testuuuddsdd")]
    partial class testuuuddsdd
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
                        .HasColumnName("customer_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("customer_name");

                    b.Property<string>("EmailAdress")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email_adr");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_nr");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(382),
                            CustomerName = "John Doe",
                            EmailAdress = "john@example.com",
                            PhoneNumber = "1234567890",
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(385)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(389),
                            CustomerName = "Jane Smith",
                            EmailAdress = "jane@example.com",
                            PhoneNumber = "9876543210",
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(389)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("MovieId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("movie_description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("movie_rating");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer")
                        .HasColumnName("movie_runtimeMins");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("movie_tite");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("MovieId");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(435),
                            Description = "Description of Movie 1",
                            Rating = "PG",
                            RuntimeMins = 120,
                            Title = "Movie 1",
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(436)
                        },
                        new
                        {
                            MovieId = 2,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(439),
                            Description = "Description of Movie 2",
                            Rating = "PG-13",
                            RuntimeMins = 150,
                            Title = "Movie 2",
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(440)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("ScreeningId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("screen_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ScreeningId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("fk_movie_id");

                    b.Property<int>("ScreenCapacity")
                        .HasColumnType("integer")
                        .HasColumnName("screen_capacity");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screen_number");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("starts_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("ScreeningId");

                    b.HasIndex("MovieId");

                    b.ToTable("screenings");

                    b.HasData(
                        new
                        {
                            ScreeningId = 1,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(470),
                            MovieId = 1,
                            ScreenCapacity = 100,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2024, 2, 9, 14, 24, 34, 247, DateTimeKind.Utc).AddTicks(463),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(470)
                        },
                        new
                        {
                            ScreeningId = 2,
                            CreatedAt = new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(475),
                            MovieId = 2,
                            ScreenCapacity = 120,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 2, 9, 15, 24, 34, 247, DateTimeKind.Utc).AddTicks(474),
                            UpdatedAt = new DateTime(2024, 2, 9, 13, 24, 34, 247, DateTimeKind.Utc).AddTicks(476)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ticket_id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TicketId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("integer")
                        .HasColumnName("seat_number");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("TicketId");

                    b.HasIndex("ScreeningId");

                    b.ToTable("tickets");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Screening", null)
                        .WithMany("Tickets")
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Navigation("Screenings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
