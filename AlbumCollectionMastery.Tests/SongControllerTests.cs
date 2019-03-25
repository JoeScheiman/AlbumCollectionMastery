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
        [Fact]
        public void Can_Create_a_Song()
        {
            var expectedId = 3;
            var testRepo = new SongRepository(null);
            var DUT = new SongController(testRepo);

            var testResult = DUT.Create(expectedId);

            Assert.IsType<ViewResult>(testResult);

        }
    }
}
