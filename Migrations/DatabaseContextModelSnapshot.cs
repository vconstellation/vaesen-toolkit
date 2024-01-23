﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VaesenToolkit.Services;

#nullable disable

namespace VaesenToolkit.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("VaesenToolkit.Models.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("NoteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("noteContext")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NoteId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("VaesenToolkit.Models.Note", b =>
                {
                    b.HasOne("VaesenToolkit.Models.Note", null)
                        .WithMany("notes")
                        .HasForeignKey("NoteId");
                });

            modelBuilder.Entity("VaesenToolkit.Models.Note", b =>
                {
                    b.Navigation("notes");
                });
#pragma warning restore 612, 618
        }
    }
}