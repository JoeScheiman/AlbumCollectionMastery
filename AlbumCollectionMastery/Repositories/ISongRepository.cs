using AlbumCollectionMastery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollectionMastery.Repositories
{
    public interface ISongRepository
    {
        void Create(Song song);
    }
}
