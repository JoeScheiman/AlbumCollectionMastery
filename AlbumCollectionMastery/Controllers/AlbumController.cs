using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollectionMastery.Models;
using AlbumCollectionMastery.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollectionMastery
{
    public class AlbumController : Controller
    {
        IAlbumRepository AlbumRepo;

        public AlbumController(IAlbumRepository AlbumRepo)
        {
            this.AlbumRepo = AlbumRepo;
        }

        public ViewResult Index()
        {
            var model = AlbumRepo.GetAll();
            return View(model);
        }
        //public IActionResult Index() //This method came with project, I'll try it...
        //{
        //    return View();
        //} 

        public ViewResult Details(int Id)
        {
            var model = AlbumRepo.GetById(Id);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Album album)
        {
            AlbumRepo.Create(album);
            return RedirectToAction("Index");
        }
        
    }
}