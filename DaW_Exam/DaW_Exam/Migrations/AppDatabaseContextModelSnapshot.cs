﻿// <auto-generated />
using System;
using DaW_Exam.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DaW_Exam.Migrations
{
    [DbContext(typeof(AppDatabaseContext))]
    partial class AppDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DaW_Exam.Models.Editura", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Judet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AutorId")
                        .IsUnique()
                        .HasFilter("[AutorId] IS NOT NULL");

                    b.ToTable("Edituri");
                });

            modelBuilder.Entity("DaW_Exam.Models.Example", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Examples");
                });

            modelBuilder.Entity("DaW_Exam.Models.Many_to_Many.Autor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Autori");
                });

            modelBuilder.Entity("DaW_Exam.Models.Many_to_Many.AutoriCartiRelation", b =>
                {
                    b.Property<Guid?>("AutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CarteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AutorId", "CarteId");

                    b.HasIndex("CarteId");

                    b.ToTable("AutoriCartiRelations");
                });

            modelBuilder.Entity("DaW_Exam.Models.Many_to_Many.Carte", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EdituraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EdituraId");

                    b.ToTable("Carti");
                });

            modelBuilder.Entity("DaW_Exam.Models.Editura", b =>
                {
                    b.HasOne("DaW_Exam.Models.Many_to_Many.Autor", "Autor")
                        .WithOne("Editura")
                        .HasForeignKey("DaW_Exam.Models.Editura", "AutorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("DaW_Exam.Models.Many_to_Many.AutoriCartiRelation", b =>
                {
                    b.HasOne("DaW_Exam.Models.Many_to_Many.Autor", "Autor")
                        .WithMany("AutoriCartiRelations")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DaW_Exam.Models.Many_to_Many.Carte", "Carte")
                        .WithMany("AutoriCartiRelations")
                        .HasForeignKey("CarteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Carte");
                });

            modelBuilder.Entity("DaW_Exam.Models.Many_to_Many.Carte", b =>
                {
                    b.HasOne("DaW_Exam.Models.Editura", "Editura")
                        .WithMany("Carti")
                        .HasForeignKey("EdituraId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Editura");
                });

            modelBuilder.Entity("DaW_Exam.Models.Editura", b =>
                {
                    b.Navigation("Carti");
                });

            modelBuilder.Entity("DaW_Exam.Models.Many_to_Many.Autor", b =>
                {
                    b.Navigation("AutoriCartiRelations");

                    b.Navigation("Editura");
                });

            modelBuilder.Entity("DaW_Exam.Models.Many_to_Many.Carte", b =>
                {
                    b.Navigation("AutoriCartiRelations");
                });
#pragma warning restore 612, 618
        }
    }
}
