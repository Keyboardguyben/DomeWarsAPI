﻿// <auto-generated />
using System;
using DomeWarsDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DomeWarsDAL.Migrations
{
    [DbContext(typeof(DomeWarsContext))]
    partial class DomeWarsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoEF.Domain.Entities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Dmg")
                        .HasColumnType("int");

                    b.Property<int>("GangId")
                        .HasColumnType("int");

                    b.Property<int>("Hp")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TerritoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GangId");

                    b.HasIndex("TerritoryId");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("DomeWarsDomain.Entities.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Funds")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TerritoryId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("TerritoryId");

                    b.ToTable("Business");
                });

            modelBuilder.Entity("DomeWarsDomain.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MaxRound")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerNumber")
                        .HasColumnType("int");

                    b.Property<int>("Round")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("DomeWarsDomain.Entities.Gang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Money")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("PublicOpinion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.ToTable("Gang");
                });

            modelBuilder.Entity("DomeWarsDomain.Entities.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("User");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Xp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique()
                        .IsDescending();

                    b.ToTable("Player");
                });

            modelBuilder.Entity("DomeWarsDomain.Entities.Territory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<int?>("GangId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAttacked")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("PoliceAttention")
                        .HasColumnType("int");

                    b.Property<int?>("RoundsSinceAttack")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("GangId");

                    b.ToTable("Territory");
                });

            modelBuilder.Entity("DemoEF.Domain.Entities.Unit", b =>
                {
                    b.HasOne("DomeWarsDomain.Entities.Gang", "Gang")
                        .WithMany()
                        .HasForeignKey("GangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomeWarsDomain.Entities.Territory", "Territory")
                        .WithMany()
                        .HasForeignKey("TerritoryId");

                    b.Navigation("Gang");

                    b.Navigation("Territory");
                });

            modelBuilder.Entity("DomeWarsDomain.Entities.Business", b =>
                {
                    b.HasOne("DomeWarsDomain.Entities.Territory", "Territory")
                        .WithMany()
                        .HasForeignKey("TerritoryId");

                    b.Navigation("Territory");
                });

            modelBuilder.Entity("DomeWarsDomain.Entities.Game", b =>
                {
                    b.HasOne("DomeWarsDomain.Entities.Player", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("DomeWarsDomain.Entities.Gang", b =>
                {
                    b.HasOne("DomeWarsDomain.Entities.Game", "Game")
                        .WithMany("Gangs")
                        .HasForeignKey("GameId");

                    b.HasOne("DomeWarsDomain.Entities.Player", "Player")
                        .WithMany("Gangs")
                        .HasForeignKey("PlayerId");

                    b.Navigation("Game");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("DomeWarsDomain.Entities.Territory", b =>
                {
                    b.HasOne("DomeWarsDomain.Entities.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId");

                    b.HasOne("DomeWarsDomain.Entities.Gang", "Gang")
                        .WithMany("Territories")
                        .HasForeignKey("GangId");

                    b.Navigation("Game");

                    b.Navigation("Gang");
                });

            modelBuilder.Entity("DomeWarsDomain.Entities.Game", b =>
                {
                    b.Navigation("Gangs");
                });

            modelBuilder.Entity("DomeWarsDomain.Entities.Gang", b =>
                {
                    b.Navigation("Territories");
                });

            modelBuilder.Entity("DomeWarsDomain.Entities.Player", b =>
                {
                    b.Navigation("Gangs");
                });
#pragma warning restore 612, 618
        }
    }
}
