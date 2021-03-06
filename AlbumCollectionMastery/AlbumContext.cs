﻿using AlbumCollectionMastery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollectionMastery
{
    public class AlbumContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public DbSet<Album> Albums { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=JoesData;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(

                new Album()
                {
                    AlbumId = 1,
                    AlbumTitle = "Classic Rock"
                },

                new Album()
                {
                    AlbumId = 2,
                    AlbumTitle = "Programming Tunez"
                },

                new Album()
                {
                    AlbumId = 3,
                    AlbumTitle = "Funky-ish"
                });

            modelBuilder.Entity<Song>().HasData(

                new Song()
                {
                    SongId = 1,
                    AlbumId = 1,
                    SongTitle = "Tom Sawyer",
                    SongArtist = "Rush"
                },

                new Song()
                {
                    SongId = 2,
                    AlbumId = 1,
                    SongTitle = "All Along the Watchtower",
                    SongArtist = "Jimi Hendrix"
                },

                new Song()
                {
                    SongId = 3,
                    AlbumId = 1,
                    SongTitle = "Dazed and Confused",
                    SongArtist = "Led Zeppelin"
                },

                new Song()
                {
                    SongId = 4,
                    AlbumId = 2,
                    SongTitle = "Jabon",
                    SongArtist = "Jojo Mayer and the Nerve"
                },

                new Song()
                {
                    SongId = 5,
                    AlbumId = 2,
                    SongTitle = "Take Five",
                    SongArtist = "Dave Brubeck Quartet"
                },

                new Song()
                {
                    SongId = 6,
                    AlbumId = 2,
                    SongTitle = "Stream of Consciousness",
                    SongArtist = "Dream Theater"
                },

                new Song()
                {
                    SongId = 7,
                    AlbumId = 3,
                    SongTitle = "Dean Town",
                    SongArtist = "Vulfpeck"
                },

                new Song()
                {
                    SongId = 8,
                    AlbumId = 3,
                    SongTitle = "Time Traveler",
                    SongArtist = "KNOWER"
                },

                new Song()
                {
                    SongId = 9,
                    AlbumId = 3,
                    SongTitle = "It Gets Funkier IV",
                    SongArtist = "Vulfpeck f/ Louis Cole"
                });

            base.OnModelCreating(modelBuilder);
        }


    }
}
