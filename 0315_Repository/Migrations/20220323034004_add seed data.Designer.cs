﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _0315_Repository.Models;

namespace _0315_Repository.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20220323034004_add seed data")]
    partial class addseeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_0315_Repository.Models.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPromotion")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateUser = "A",
                            IsPromotion = false,
                            Name = "蛋糕",
                            Price = 10m
                        },
                        new
                        {
                            Id = 2,
                            CreateUser = "A",
                            IsPromotion = true,
                            Name = "餅乾",
                            Price = 20m
                        },
                        new
                        {
                            Id = 3,
                            CreateUser = "A",
                            IsPromotion = false,
                            Name = "蛋塔",
                            Price = 30m
                        },
                        new
                        {
                            Id = 4,
                            CreateUser = "B",
                            IsPromotion = true,
                            Name = "奶酪",
                            Price = 40m
                        },
                        new
                        {
                            Id = 5,
                            CreateUser = "B",
                            IsPromotion = false,
                            Name = "蛋捲",
                            Price = 50m
                        },
                        new
                        {
                            Id = 6,
                            CreateUser = "B",
                            IsPromotion = true,
                            Name = "飲料",
                            Price = 60m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}