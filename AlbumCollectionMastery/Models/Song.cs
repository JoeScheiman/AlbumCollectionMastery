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

        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }

    }
}
