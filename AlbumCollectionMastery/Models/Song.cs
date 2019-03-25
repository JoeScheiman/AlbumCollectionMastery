using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollectionMastery.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }

        [Display(Name = "Song Title:")]
        public string SongTitle { get; set; }
        [Display(Name = "Artist Name:")]
        public string SongArtist { get; set; }

        public int AlbumId { get; set; }
        

    }
}
