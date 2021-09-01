using Impact_assignment.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Impact_assignment.Controllers
{
    [ApiController]
    [Route("News")]
    public class NewsController : ControllerBase
    {
        

        public IRssProcesser _RssProcesser;

        private readonly ILogger<NewsController> _logger;

        public NewsController(ILogger<NewsController> logger)
        {
            _logger = logger;
            _RssProcesser = new RssProcesser();// kunne ikke lige finde en måde at Dp-injecte på. så det kunne unit-testes
        }

        [HttpGet("/GetRssNewsAsJson")]
        public string Get(string UrlRssFeed)
        {

            var feedstring = _RssProcesser.GetRssFeedAsJsonSTring(UrlRssFeed).Result;


            return feedstring;
        }
    }
}
