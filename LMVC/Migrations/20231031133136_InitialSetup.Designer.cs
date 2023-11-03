﻿// <auto-generated />
using System;
using LMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LMVC.Migrations
{
    [DbContext(typeof(LmsDbContext))]
    [Migration("20231031133136_InitialSetup")]
    partial class InitialSetup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LMVC.Models.BOOK", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("librarycardId")
                        .HasColumnType("int");

                    b.Property<int>("publishedYear")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ID")
                        .IsUnique();

                    b.HasIndex("librarycardId");

                    b.ToTable("BOOKs");
                });

            modelBuilder.Entity("LMVC.Models.LIBRARYCARD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MemberName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("LIBRARYCARDs");
                });

            modelBuilder.Entity("LMVC.Models.BOOK", b =>
                {
                    b.HasOne("LMVC.Models.LIBRARYCARD", "librarycard")
                        .WithMany("book")
                        .HasForeignKey("librarycardId");

                    b.Navigation("librarycard");
                });

            modelBuilder.Entity("LMVC.Models.LIBRARYCARD", b =>
                {
                    b.Navigation("book");
                });
#pragma warning restore 612, 618
        }
    }
}