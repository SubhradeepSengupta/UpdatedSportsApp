﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsApplication.Models;

namespace SportsApplication.Migrations
{
    [DbContext(typeof(SportsDbContext))]
    [Migration("20190712054852_Models Created")]
    partial class ModelsCreated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsApplication.Models.Test", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Date");

                    b.HasKey("ID");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("SportsApplication.Models.TestType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("TestTypes");
                });

            modelBuilder.Entity("SportsApplication.Models.TestTypeMapper", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TestID");

                    b.Property<int>("TestTypeID");

                    b.HasKey("ID");

                    b.HasIndex("TestID")
                        .IsUnique();

                    b.HasIndex("TestTypeID");

                    b.ToTable("TestTypeMappers");
                });

            modelBuilder.Entity("SportsApplication.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Role");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SportsApplication.Models.UserTestMapper", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("CooperTestDistance");

                    b.Property<string>("FitnessRating");

                    b.Property<int?>("SprintTestTime");

                    b.Property<int>("TestID");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("TestID");

                    b.HasIndex("UserID");

                    b.ToTable("UserTestMappers");
                });

            modelBuilder.Entity("SportsApplication.Models.TestTypeMapper", b =>
                {
                    b.HasOne("SportsApplication.Models.Test", "Test")
                        .WithOne("TestTypeMapper")
                        .HasForeignKey("SportsApplication.Models.TestTypeMapper", "TestID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportsApplication.Models.TestType", "TestType")
                        .WithMany("TestTypeMapper")
                        .HasForeignKey("TestTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SportsApplication.Models.UserTestMapper", b =>
                {
                    b.HasOne("SportsApplication.Models.Test", "Test")
                        .WithMany("UserTestMappers")
                        .HasForeignKey("TestID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SportsApplication.Models.User", "User")
                        .WithMany("UserTestMappers")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
