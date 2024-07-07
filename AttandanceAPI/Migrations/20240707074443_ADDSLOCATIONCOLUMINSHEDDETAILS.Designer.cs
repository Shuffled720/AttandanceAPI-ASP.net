﻿// <auto-generated />
using AttandanceAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AttandanceAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240707074443_ADDSLOCATIONCOLUMINSHEDDETAILS")]
    partial class ADDSLOCATIONCOLUMINSHEDDETAILS
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AttandanceAPI.Models.Shed_Details", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Correspondence_Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Railway_ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShedIncharge_StaffNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shed_Incharge_DetailsShedIncharge_StaffNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Shed_Latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shed_Longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Shed_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZonalRLY")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Shed_Incharge_DetailsShedIncharge_StaffNo");

                    b.ToTable("Shed_Details");
                });

            modelBuilder.Entity("AttandanceAPI.Models.Shed_Incharge_Details", b =>
                {
                    b.Property<string>("ShedIncharge_StaffNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressHome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressOffice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AdminTag")
                        .HasColumnType("bit");

                    b.Property<string>("AttendanceUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AttendanceUserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShedIncharge_StaffNo");

                    b.ToTable("Shed_Incharge_Details");
                });

            modelBuilder.Entity("AttandanceAPI.Models.Shed_Details", b =>
                {
                    b.HasOne("AttandanceAPI.Models.Shed_Incharge_Details", "Shed_Incharge_Details")
                        .WithMany()
                        .HasForeignKey("Shed_Incharge_DetailsShedIncharge_StaffNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shed_Incharge_Details");
                });
#pragma warning restore 612, 618
        }
    }
}
