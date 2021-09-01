using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Impact_assignment.Model
{
    public class RssFeedModel
    {
        public string title { get; set; }
        public string desc { get; set; }

        public ImageModel img { get; set; }
        public List<Entrymodel> entries = new List<Entrymodel>();

    }
}
