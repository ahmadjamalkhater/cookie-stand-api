﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cookie_stand_api.Data;

#nullable disable

namespace cookie_stand_api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("cookie_stand_api.Models.CookieStand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("AverageCookiesPerSale")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaximumCustomersPerHour")
                        .HasColumnType("int");

                    b.Property<int>("MinimumCustomersPerHour")
                        .HasColumnType("int");

                    b.Property<string>("Owner")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("cookieStands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AverageCookiesPerSale = 2.5,
                            Description = "",
                            Location = "Barcelona",
                            MaximumCustomersPerHour = 7,
                            MinimumCustomersPerHour = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
