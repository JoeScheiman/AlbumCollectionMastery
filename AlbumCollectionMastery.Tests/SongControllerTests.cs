using System;
using Xunit;
using NSubstitute;
using System.Collections.Generic;
using AlbumCollectionMastery.Models;
using AlbumCollectionMastery.Repositories;
using AlbumCollectionMastery.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace AlbumCollectionMastery.Tests
{
    public class SongControllerTests
    {
        public SongController DUT;
        public ISongRepository testRepo;

        public SongControllerTests()
        {
            testRepo = Substitute.For<ISongRepository>();
            DUT = new SongController(testRepo);
        }

        [Fact]
        public void Create_a_Song_Returns_a_View()
        {
            var expectedId = 3;
            var testResult = DUT.Create(expectedId);

            Assert.IsType<ViewResult>(testResult);

        }

        [Fact]
        public void Can_Create_a_Song()
        {
            var pass = true;

            var newSong = new Song();
            var wrongSong = new Song();
            //This example is based off NSubstitute website,
            //No Assert is needed.
            testRepo.Create(newSong);
            if(!pass) //Change var pass to false to see this fail
                testRepo.Received().Create(wrongSong);            
            
            if(pass)
                testRepo.Received().Create(newSong);
        }
    }
}
