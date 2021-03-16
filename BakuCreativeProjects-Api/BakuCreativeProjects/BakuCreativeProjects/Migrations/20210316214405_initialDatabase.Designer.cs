﻿// <auto-generated />
using BakuCreativeProjects.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BakuCreativeProjects.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210316214405_initialDatabase")]
    partial class initialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BakuCreativeProjects.Models.ChildCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("ChildCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Sport",
                            SubCategoryId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sport",
                            SubCategoryId = 3
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sport",
                            SubCategoryId = 5
                        },
                        new
                        {
                            Id = 4,
                            Name = "Klassik",
                            SubCategoryId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Klassik",
                            SubCategoryId = 3
                        },
                        new
                        {
                            Id = 6,
                            Name = "Klassik",
                            SubCategoryId = 5
                        },
                        new
                        {
                            Id = 7,
                            Name = "Saat",
                            SubCategoryId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Saat",
                            SubCategoryId = 4
                        },
                        new
                        {
                            Id = 9,
                            Name = "Saat",
                            SubCategoryId = 6
                        });
                });

            modelBuilder.Entity("BakuCreativeProjects.Models.MainCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Kisi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Qadin"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Usaq"
                        });
                });

            modelBuilder.Entity("BakuCreativeProjects.Models.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MainCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MainCategoryId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MainCategoryId = 1,
                            Name = "Ayaqqabi"
                        },
                        new
                        {
                            Id = 2,
                            MainCategoryId = 1,
                            Name = "Aksesuar"
                        },
                        new
                        {
                            Id = 3,
                            MainCategoryId = 2,
                            Name = "Ayaqqabi"
                        },
                        new
                        {
                            Id = 4,
                            MainCategoryId = 2,
                            Name = "Aksesuar"
                        },
                        new
                        {
                            Id = 5,
                            MainCategoryId = 3,
                            Name = "Ayaqqabi"
                        },
                        new
                        {
                            Id = 6,
                            MainCategoryId = 3,
                            Name = "Aksesuar"
                        });
                });

            modelBuilder.Entity("BakuCreativeProjects.Models.ChildCategory", b =>
                {
                    b.HasOne("BakuCreativeProjects.Models.SubCategory", "SubCategory")
                        .WithMany("ChildCategories")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("BakuCreativeProjects.Models.SubCategory", b =>
                {
                    b.HasOne("BakuCreativeProjects.Models.MainCategory", "MainCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MainCategory");
                });

            modelBuilder.Entity("BakuCreativeProjects.Models.MainCategory", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("BakuCreativeProjects.Models.SubCategory", b =>
                {
                    b.Navigation("ChildCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
