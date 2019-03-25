using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollectionMastery.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }

        public string AlbumTitle { get; set; }

        public virtual List<Song> Songs { get; set; }
    }
}
