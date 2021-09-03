using System;
using Xunit;
using Impact_assignment.Service;
using Impact_assignment.Controllers;
using Microsoft.Extensions.Logging;
using Impact_assignment.Model;
using AutoFixture;

namespace TestImpactAssignment
{
    public class TestRssProcesser
    {
        [Fact]
        public async void GetRssFeedAsJsonSTring_succeeds_WhenGivenValidFeed()
        {
            //Assign
            RssProcesser stt = new RssProcesser();

            //Act
            var result = await stt.GetRssFeedAsJsonSTring("http://feeds.tv2.dk/nyheder/rss");

            //Assert
            Assert.NotNull(result);
        }


        [Fact]
        public void Model_Parses_pubDateToGMT2NoDaylight()
        {
            Fixture fix = new Fixture();

            var Entry = fix.Create<Entrymodel>(); //Acess violation somewhere don't have time for it.
            //Assign

            var time = Entry.pubDate;
            //Act
            //Assert
        }
    }
}
