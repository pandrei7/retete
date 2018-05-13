using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retete
{
    class HTMLParser
    {
        private const string INVALID_STRING = "invalid";

        public static Recipe NextRecipe(string html, ref int index)
        {
            string link = extractLink(html, ref index);
            if (link == INVALID_STRING)
                return null;

            bool hasVideo = extractHasVideo(html, ref index);

            string image = extractImage(html, ref index);

            string name = extractName(html, ref index);
            name = cleanName(name);

            return new Recipe(name, link, image, hasVideo);
        }

        private static string extractLink(string html, ref int index)
        {
            index = html.IndexOf("recipe-thumb", index);
            // If there aren't any recipes left, return a special string
            if (index == -1)
            {
                return INVALID_STRING;
            }

            index = html.IndexOf("a href", index);

            int startPos = html.IndexOf('"', index) + 1;
            int endPos = html.IndexOf('"', startPos);

            int length = endPos - startPos;
            string link = html.Substring(startPos, length);
            index = endPos;

            return link;
        }

        private static bool extractHasVideo(string html, ref int index)
        {
            int videoPos = html.IndexOf("has-youtube-video", index);
            int endTagPos = html.IndexOf('>', index);
            return videoPos != -1 && videoPos < endTagPos;
        }

        private static string extractImage(string html, ref int index)
        {
            index = html.IndexOf("img", index);
            index = html.IndexOf("data-src", index);

            int startPos = html.IndexOf('"', index) + 1;
            int endPos = html.IndexOf('"', startPos);

            int length = endPos - startPos;
            string image = html.Substring(startPos, length);
            index = endPos;

            return "http://www.lalena.ro" + image;
        }

        private static string extractName(string html, ref int index)
        {
            index = html.IndexOf("a href", index);

            int startPos = html.IndexOf('>', index) + 1;
            int endPos = html.IndexOf('<', startPos);

            int length = endPos - startPos;
            string name = html.Substring(startPos, length);
            index = endPos;

            return name;
        }

        private static string cleanName(string name)
        {
            name = name.Replace("- Reteta VIDEO", "");
            name = name.Replace("VIDEO", "");
            name.Trim();
            return name;
        }
    }
}
