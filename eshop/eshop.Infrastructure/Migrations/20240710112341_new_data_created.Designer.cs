﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eshop.Infrastructure.Data;

#nullable disable

namespace eshop.Infrastructure.Migrations
{
    [DbContext(typeof(EshopDbContext))]
    [Migration("20240710112341_new_data_created")]
    partial class new_data_created
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eshop.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bilgisayar ve Tablet"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ses Sistemleri"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Monitör"
                        });
                });

            modelBuilder.Entity("eshop.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9172),
                            Description = "Açıklama",
                            ImageUrl = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg",
                            IsActive = true,
                            Name = "Dell XPS 15",
                            Price = 96000m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9207),
                            Description = "Açıklama",
                            ImageUrl = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg",
                            IsActive = true,
                            Name = "MacBook Pro M2",
                            Price = 96000m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9211),
                            Description = "Açıklama",
                            ImageUrl = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg",
                            IsActive = true,
                            Name = "Lenovo",
                            Price = 86000m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9214),
                            Description = "Açıklama",
                            ImageUrl = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg",
                            IsActive = true,
                            Name = "Asus",
                            Price = 50000m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9218),
                            Description = "Açıklama",
                            ImageUrl = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg",
                            IsActive = true,
                            Name = "Ses -A",
                            Price = 96000m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9221),
                            Description = "Açıklama",
                            ImageUrl = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg",
                            IsActive = true,
                            Name = "Ses-B",
                            Price = 86000m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9225),
                            Description = "Açıklama",
                            ImageUrl = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg",
                            IsActive = true,
                            Name = "Ses-C",
                            Price = 50000m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9229),
                            Description = "Açıklama",
                            ImageUrl = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg",
                            IsActive = true,
                            Name = "M -A",
                            Price = 96000m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9233),
                            Description = "Açıklama",
                            ImageUrl = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg",
                            IsActive = true,
                            Name = "M-B",
                            Price = 86000m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 7, 10, 14, 23, 39, 600, DateTimeKind.Local).AddTicks(9237),
                            Description = "Açıklama",
                            ImageUrl = "https://cdn.dsmcdn.com/ty1398/product/media/images/prod/QC/20240703/11/36f8f5ca-a76c-356a-8ff3-3435c5ae8c9f/1_org.jpg",
                            IsActive = true,
                            Name = "M-C",
                            Price = 50000m
                        });
                });

            modelBuilder.Entity("eshop.Domain.Product", b =>
                {
                    b.HasOne("eshop.Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("eshop.Domain.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
