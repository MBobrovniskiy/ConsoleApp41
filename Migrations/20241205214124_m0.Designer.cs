﻿// <auto-generated />
using System;
using ConsoleApp41;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp41.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20241205214124_m0")]
    partial class m0
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("ConsoleApp41.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("LibraryId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ReaderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LibraryId");

                    b.HasIndex("ReaderId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("ConsoleApp41.Models.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Libraries");
                });

            modelBuilder.Entity("ConsoleApp41.Models.Reader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("ConsoleApp41.Models.Taken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BorrowedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ReturnedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Takens");
                });

            modelBuilder.Entity("ConsoleApp41.Models.Book", b =>
                {
                    b.HasOne("ConsoleApp41.Models.Library", "Library")
                        .WithMany("Books")
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp41.Models.Reader", null)
                        .WithMany("BorrowedBooks")
                        .HasForeignKey("ReaderId");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("ConsoleApp41.Models.Taken", b =>
                {
                    b.HasOne("ConsoleApp41.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleApp41.Models.Reader", "User")
                        .WithMany("Borrowings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ConsoleApp41.Models.Library", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("ConsoleApp41.Models.Reader", b =>
                {
                    b.Navigation("BorrowedBooks");

                    b.Navigation("Borrowings");
                });
#pragma warning restore 612, 618
        }
    }
}
