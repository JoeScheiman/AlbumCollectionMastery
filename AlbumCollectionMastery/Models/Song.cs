﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollectionMastery.Models
{
    public class Song
    {
        public int SongID { get; set; }

        [Display(Name = "Song Title:")]
        public string SongTitle { get; set; }

    }
}