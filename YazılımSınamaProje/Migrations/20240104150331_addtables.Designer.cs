﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YazılımSınamaProje.Models;

#nullable disable

namespace YazılımSınamaProje.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240104150331_addtables")]
    partial class addtables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YazılımSınamaProje.Models.Offer", b =>
                {
                    b.Property<int>("offerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("offerID"));

                    b.Property<int>("bidAmount")
                        .HasColumnType("int");

                    b.Property<int>("bidderID")
                        .HasColumnType("int");

                    b.Property<int>("offerRecipientID")
                        .HasColumnType("int");

                    b.Property<int>("projectID")
                        .HasColumnType("int");

                    b.HasKey("offerID");

                    b.HasIndex("projectID");

                    b.ToTable("offers");
                });

            modelBuilder.Entity("YazılımSınamaProje.Models.Project", b =>
                {
                    b.Property<int>("projectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("projectID"));

                    b.Property<int>("projectBudget")
                        .HasColumnType("int");

                    b.Property<string>("projectDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projectLanguage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projectTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("projectTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("projectID");

                    b.HasIndex("userId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("YazılımSınamaProje.Models.User", b =>
                {
                    b.Property<int>("userID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("userID"));

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("money")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userID");

                    b.ToTable("users");
                });

            modelBuilder.Entity("YazılımSınamaProje.Models.Work", b =>
                {
                    b.Property<int>("workID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("workID"));

                    b.Property<int>("employerID")
                        .HasColumnType("int");

                    b.Property<string>("explanation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("newBudget")
                        .HasColumnType("int");

                    b.Property<int>("projectID")
                        .HasColumnType("int");

                    b.Property<int>("workBusinessID")
                        .HasColumnType("int");

                    b.HasKey("workID");

                    b.HasIndex("projectID");

                    b.ToTable("works");
                });

            modelBuilder.Entity("YazılımSınamaProje.Models.Offer", b =>
                {
                    b.HasOne("YazılımSınamaProje.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("projectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("YazılımSınamaProje.Models.Project", b =>
                {
                    b.HasOne("YazılımSınamaProje.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("YazılımSınamaProje.Models.Work", b =>
                {
                    b.HasOne("YazılımSınamaProje.Models.Project", "project")
                        .WithMany()
                        .HasForeignKey("projectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("project");
                });
#pragma warning restore 612, 618
        }
    }
}
