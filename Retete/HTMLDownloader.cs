using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Retete
{
    class HTMLDownloader
    {
        public static string DownloadPage(string url)
        {
            string html;

            using (var client = new WebClient())
            {
                client.Encoding = System.Text.Encoding.UTF8;
                Console.WriteLine("Incep sa downloadez " + url);
                html = client.DownloadString(url);
                Console.WriteLine("Am downloadat " + url);
            }

            html = WebUtility.HtmlDecode(html);

            return html;
        }
    }
}
