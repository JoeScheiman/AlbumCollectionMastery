﻿// <auto-generated />
using AlbumCollectionMastery;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlbumCollectionMastery.Migrations
{
    [DbContext(typeof(AlbumContext))]
    [Migration("20190325054335_ArtistNameAdded")]
    partial class ArtistNameAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlbumCollectionMastery.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumTitle");

                    b.HasKey("AlbumId");

                    b.ToTable("Albums");

                    b.HasData(
                        new { AlbumId = 1, AlbumTitle = "Classic Rock" },
                        new { AlbumId = 2, AlbumTitle = "Programming Tunez" },
                        new { AlbumId = 3, AlbumTitle = "Funky-ish" }
                    );
                });

            modelBuilder.Entity("AlbumCollectionMastery.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<string>("SongArtist");

                    b.Property<string>("SongTitle");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Songs");

                    b.HasData(
                        new { SongId = 1, AlbumId = 1, SongArtist = "Rush", SongTitle = "Tom Sawyer" },
                        new { SongId = 2, AlbumId = 1, SongArtist = "Rush", SongTitle = "All Along the Watchtower" },
                        new { SongId = 3, AlbumId = 1, SongArtist = "Rush", SongTitle = "Dazed and Confused" },
                        new { SongId = 4, AlbumId = 2, SongArtist = "Rush", SongTitle = "Jabon" },
                        new { SongId = 5, AlbumId = 2, SongArtist = "Rush", SongTitle = "Take Five" },
                        new { SongId = 6, AlbumId = 2, SongArtist = "Rush", SongTitle = "Stream of Consciousness" },
                        new { SongId = 7, AlbumId = 3, SongArtist = "Rush", SongTitle = "Dean Town" },
                        new { SongId = 8, AlbumId = 3, SongArtist = "Rush", SongTitle = "Time Traveler" },
                        new { SongId = 9, AlbumId = 3, SongArtist = "Rush", SongTitle = "It Gets Funkier IV" }
                    );
                });

            modelBuilder.Entity("AlbumCollectionMastery.Models.Song", b =>
                {
                    b.HasOne("AlbumCollectionMastery.Models.Album")
                        .WithMany("Songs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
