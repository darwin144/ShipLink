﻿// <auto-generated />
using System;
using API_ShipLink.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_ShipLink.Migrations
{
    [DbContext(typeof(ShiplinkContext))]
    [Migration("20230812171031_initialize")]
    partial class initialize
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("API_ShipLink.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("password");

                    b.Property<Guid>("User_id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("User_id")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("API_ShipLink.Models.AccountRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Account_id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("account_id");

                    b.Property<Guid>("Role_id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("role_id");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("Account_id")
                        .IsUnique();

                    b.HasIndex("Role_id");

                    b.ToTable("AccountRole");
                });

            modelBuilder.Entity("API_ShipLink.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f147a695-1a4f-4960-bffc-08db60bf618f"),
                            Name = "User"
                        },
                        new
                        {
                            Id = new Guid("c22a20c5-0149-41fd-bffd-08db60bf618f"),
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("API_ShipLink.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phone");

                    b.HasKey("Id");

                    b.HasIndex("Email", "Phone")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("API_ShipLink.Models.Account", b =>
                {
                    b.HasOne("API_ShipLink.Models.User", "User")
                        .WithOne("Account")
                        .HasForeignKey("API_ShipLink.Models.Account", "User_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("API_ShipLink.Models.AccountRole", b =>
                {
                    b.HasOne("API_ShipLink.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("API_ShipLink.Models.Account", null)
                        .WithOne("AccountRole")
                        .HasForeignKey("API_ShipLink.Models.AccountRole", "Account_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("API_ShipLink.Models.Role", "Role")
                        .WithMany("AccountRoles")
                        .HasForeignKey("Role_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("API_ShipLink.Models.Account", b =>
                {
                    b.Navigation("AccountRole");
                });

            modelBuilder.Entity("API_ShipLink.Models.Role", b =>
                {
                    b.Navigation("AccountRoles");
                });

            modelBuilder.Entity("API_ShipLink.Models.User", b =>
                {
                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}
