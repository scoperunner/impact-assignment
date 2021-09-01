using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;
using CodeHollow.FeedReader;
using Impact_assignment.Model;
using Newtonsoft.Json;

namespace Impact_assignment.Service
{
    public class RssProcesser : IRssProcesser
    {
        public async Task<string> GetRssFeedAsJsonSTring(string RssFeed)
        {
            try
            {
                List<RssFeedModel> feeds = new List<RssFeedModel>();
                var reader = await FeedReader.ReadAsync(RssFeed);
                var feedmodel = new RssFeedModel { title = reader.Title, desc = reader.Description };

                foreach (var feeditem in reader.Items) 
                {

                       
                    feedmodel.entries.Add(new Entrymodel { title = feeditem.Title, link = feeditem.Link, pubDate = feeditem.PublishingDate.Value, authors = feeditem.Author });

                }
                string json = JsonConvert.SerializeObject(feedmodel);
                return json;
            }
            catch (Exception ex)
            {
            
            }
            return null;
        }
    }
}
