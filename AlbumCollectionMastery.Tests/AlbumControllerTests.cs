using System;
using Xunit;
using NSubstitute;
using System.Collections.Generic;
using AlbumCollectionMastery.Models;
using AlbumCollectionMastery.Repositories;

namespace AlbumCollectionMastery.Tests
{
    public class AlbumControllerTests
    {
        public AlbumController DUT;  //I like DUT for Device Under Test - if it's bad, let me know.  We use it with hardware testing, but it still seems applicable.
        public IAlbumRepository testRepo;

        public AlbumControllerTests()
        {
            testRepo = Substitute.For<IAlbumRepository>();
            DUT = new AlbumController(testRepo);
        }
        [Fact]
        public void Index_Sets_Model_To_All_Albums()
        {
            var expectedModel = new List<Album>();
            testRepo.GetAll().Returns(expectedModel);

            var result = DUT.Index();
            var model = (IEnumerable<Album>)result.Model;

            Assert.Equal(expectedModel, model);
        }
    }
}
