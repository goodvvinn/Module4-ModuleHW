﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PositiveNoise;

namespace PositiveNoise.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210503151454_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArtistSong", b =>
                {
                    b.Property<int>("ArtistsArtistId")
                        .HasColumnType("int");

                    b.Property<int>("SongsSongId")
                        .HasColumnType("int");

                    b.HasKey("ArtistsArtistId", "SongsSongId");

                    b.HasIndex("SongsSongId");

                    b.ToTable("ArtistSong");
                });

            modelBuilder.Entity("PositiveNoise.Entity.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ArtistId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("InstagramURL")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("InstagramURL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<int>("PhoneNumber")
                        .HasMaxLength(13)
                        .HasColumnType("int")
                        .HasColumnName("PhoneNumber");

                    b.HasKey("ArtistId");

                    b.ToTable("Artist");
                });

            modelBuilder.Entity("PositiveNoise.Entity.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GenreId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("GenreId");

                    b.ToTable("Genre");
                });

            modelBuilder.Entity("PositiveNoise.Entity.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SongId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Duration")
                        .HasMaxLength(4)
                        .HasColumnType("time")
                        .HasColumnName("Duration");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Title");

                    b.HasKey("SongId");

                    b.HasIndex("GenreId");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("ArtistSong", b =>
                {
                    b.HasOne("PositiveNoise.Entity.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PositiveNoise.Entity.Song", null)
                        .WithMany()
                        .HasForeignKey("SongsSongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PositiveNoise.Entity.Song", b =>
                {
                    b.HasOne("PositiveNoise.Entity.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("PositiveNoise.Entity.Genre", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}