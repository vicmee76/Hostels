// <auto-generated />
using System;
using Hostels.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hostels.Migrations
{
    [DbContext(typeof(HostelContext))]
    [Migration("20220415122731_updatedRolesMadeRequired")]
    partial class updatedRolesMadeRequired
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {

            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hostels.Models.Roles", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleName")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Hostels.Models.Users", b =>
                {
                    b.Property<int>("UseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolesRoleId")
                        .HasColumnType("int");

                    b.HasKey("UseId");

                    b.HasIndex("RolesRoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Hostels.Models.Users", b =>
                {
                    b.HasOne("Hostels.Models.Roles", "Roles")
                        .WithMany("Users")
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                });

            modelBuilder.Entity("Hostels.Models.Roles", b =>
                {
                });

        }
    }
}
