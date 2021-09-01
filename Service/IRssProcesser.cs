using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Impact_assignment.Model;
using Newtonsoft.Json;

namespace Impact_assignment.Service
{
    public interface IRssProcesser
    {
        public Task<string> GetRssFeedAsJsonSTring(string RssFeed);
         
    }
}
