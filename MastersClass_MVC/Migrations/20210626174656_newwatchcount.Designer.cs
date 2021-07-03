﻿// <auto-generated />
using MastersClass_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MastersClass_MVC.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210626174656_newwatchcount")]
    partial class newwatchcount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MastersClass_MVC.Models.Courses", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageslink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("videolink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("MastersClass_MVC.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fareastlevel1")
                        .HasColumnType("int");

                    b.Property<int>("fareastlevel2")
                        .HasColumnType("int");

                    b.Property<int>("fareastlevel3")
                        .HasColumnType("int");

                    b.Property<int>("italianlevel1")
                        .HasColumnType("int");

                    b.Property<int>("italianlevel2")
                        .HasColumnType("int");

                    b.Property<int>("italianlevel3")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("turkishlevel1")
                        .HasColumnType("int");

                    b.Property<int>("turkishlevel2")
                        .HasColumnType("int");

                    b.Property<int>("turkishlevel3")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}