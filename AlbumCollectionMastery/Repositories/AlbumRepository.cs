using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollectionMastery.Models;

namespace AlbumCollectionMastery.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        private AlbumContext db;
        
        public AlbumRepository(AlbumContext db)
        {
            this.db = db;
        }

        public Album GetById (int id)
        {
            return db.Albums.Single(album => album.AlbumId == id);
        }

        public void Create(Album newAlbum)
        {
            db.Albums.Add(newAlbum);
            db.SaveChanges();
        }

        public IEnumerable<Album> GetAll()
        {
            return db.Albums.ToList();
        }
    }
}
