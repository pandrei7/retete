using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retete
{
    public class Recipe
    {
        public string Name { get; private set; }
        public string Link { get; private set; }
        public string ImageLink { get; private set; }
        public bool HasVideo { get; private set; }

        public Recipe(string name, string link, string image, bool hasVideo = false)
        {
            Name = name;
            Link = link;
            ImageLink = image;
            HasVideo = hasVideo;
        }

        public Recipe() : this("Fara nume", "Fara link", "Fara imagine") {}
    }
}
