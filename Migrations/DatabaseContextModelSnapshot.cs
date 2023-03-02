﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using VehicleRental;

#nullable disable

namespace ASPWebapp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("VehicleRental.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int>("ProductType")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Price = 2000.00m,
                            ProductName = "Samsung Galaxy s23 Ultra",
                            ProductType = 2
                        },
                        new
                        {
                            ID = 2,
                            Price = 1700.00m,
                            ProductName = "Samsung Galaxy s23 Plus",
                            ProductType = 2
                        },
                        new
                        {
                            ID = 3,
                            Price = 1200.00m,
                            ProductName = "Samsung Galaxy s23 ",
                            ProductType = 2
                        },
                        new
                        {
                            ID = 4,
                            Price = 3500.00m,
                            ProductName = "Nvidia Geforce GTX4090",
                            ProductType = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}