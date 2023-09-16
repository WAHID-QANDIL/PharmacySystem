﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacyProjectITI;

#nullable disable

namespace PharmacyProjectITI.Migrations
{
    [DbContext(typeof(pharmacyContext))]
    partial class pharmacyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PharmacyProjectITI.Categary", b =>
                {
                    b.Property<int>("cid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cid"));

                    b.Property<string>("cname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cid");

                    b.ToTable("categarie");
                });

            modelBuilder.Entity("PharmacyProjectITI.Medicien", b =>
                {
                    b.Property<int>("mid_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("mid_id"));

                    b.Property<int>("cid")
                        .HasColumnType("int");

                    b.Property<DateTime>("expireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("mid_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("mid_price")
                        .HasColumnType("real");

                    b.Property<DateTime>("productionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("mid_id");

                    b.HasIndex("cid");

                    b.ToTable("medicien");
                });

            modelBuilder.Entity("PharmacyProjectITI.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("uEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("PharmacyProjectITI.User_mediciens", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("mid_id")
                        .HasColumnType("int");

                    b.Property<string>("mid_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.HasIndex("mid_id");

                    b.ToTable("User_Mediciens");
                });

            modelBuilder.Entity("PharmacyProjectITI.Medicien", b =>
                {
                    b.HasOne("PharmacyProjectITI.Categary", "Categary")
                        .WithMany()
                        .HasForeignKey("cid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categary");
                });

            modelBuilder.Entity("PharmacyProjectITI.User_mediciens", b =>
                {
                    b.HasOne("PharmacyProjectITI.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmacyProjectITI.Medicien", "Medicien")
                        .WithMany()
                        .HasForeignKey("mid_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicien");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
