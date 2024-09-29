﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookstoreManagement.Migrations
{
    [DbContext(typeof(BookstoreContext))]
    [Migration("20240929224128_book")]
    partial class book
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookstoreManagement.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("SearchTerm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Saja",
                            Genre = "Learning",
                            Price = 10.99,
                            Title = "The Great c#"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Fawaz",
                            Genre = "Exactly Loved",
                            Price = 8.9900000000000002,
                            Title = "I miss You Dad"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Mahmood",
                            Genre = "Road of Life",
                            Price = 7.9900000000000002,
                            Title = "Hello World"
                        });
                });

            modelBuilder.Entity("BookstoreManagement.Models.Book", b =>
                {
                    b.HasOne("BookstoreManagement.Models.Book", null)
                        .WithMany("Books")
                        .HasForeignKey("BookId");
                });

            modelBuilder.Entity("BookstoreManagement.Models.Book", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
