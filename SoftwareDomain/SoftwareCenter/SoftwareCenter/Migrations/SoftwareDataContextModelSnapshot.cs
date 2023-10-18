﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoftwareCenter.Data;

#nullable disable

namespace SoftwareCenter.Migrations
{
    [DbContext(typeof(SoftwareDataContext))]
    partial class SoftwareDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("SoftwareCenter.Data.SoftwareInventoryItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Retired")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SupportTech")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TitleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Titles");
                });

            modelBuilder.Entity("SoftwareCenter.Data.UserIssueEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IssueId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SoftwareId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("User")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SoftwareId");

                    b.ToTable("UserIssues");
                });

            modelBuilder.Entity("SoftwareCenter.Data.UserIssueEntity", b =>
                {
                    b.HasOne("SoftwareCenter.Data.SoftwareInventoryItemEntity", "Software")
                        .WithMany("Issues")
                        .HasForeignKey("SoftwareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Software");
                });

            modelBuilder.Entity("SoftwareCenter.Data.SoftwareInventoryItemEntity", b =>
                {
                    b.Navigation("Issues");
                });
#pragma warning restore 612, 618
        }
    }
}
