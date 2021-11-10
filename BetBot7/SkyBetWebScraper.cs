using BetBot7;
using HtmlAgilityPack;
using Microsoft.Bot.Builder.Integration.AspNet.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MatchedBetViewer
{
    class SkyBetWebScraper : SkyBetEntryModel
    {
        private ObservableCollection<SkyBetEntryModel> _entries = new ObservableCollection<SkyBetEntryModel>();
        protected static CookieWebClient wc = new CookieWebClient();

        public ObservableCollection<SkyBetEntryModel> Entries
        {
            get { return _entries; }
            set { _entries = value; }
        }
        public List<string> Links = new List<string>();

        public HtmlDocument Download(string url)
        {
            HtmlDocument hdoc = new HtmlDocument();

            wc.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.97 Safari/537.11";
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            wc.Headers[HttpRequestHeader.Accept] = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            //wc.Headers[HttpRequestHeader.AcceptEncoding] = "gzip,deflate,sdch";
            wc.Headers[HttpRequestHeader.AcceptLanguage] = "en-GB,en-US;q=0.8,en;q=0.6";
            wc.Headers[HttpRequestHeader.AcceptCharset] = "ISO-8859-1,utf-8;q=0.7,*;q=0.3";

            HtmlNode.ElementsFlags.Remove("option");
            HtmlNode.ElementsFlags.Remove("select");






            Stream read = wc.OpenRead(url);
            hdoc.Load(read, true);


            return hdoc;
        }

        public void SkyBetScrapeRaceLink(string page)
        {

            var hdocument = Download(page);
            wc.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.97 Safari/537.11";
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            wc.Headers[HttpRequestHeader.Accept] = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            wc.Headers[HttpRequestHeader.AcceptEncoding] = "gzip,deflate,sdch";
            wc.Headers[HttpRequestHeader.AcceptLanguage] = "en-GB,en-US;q=0.8,en;q=0.6";
            wc.Headers[HttpRequestHeader.AcceptCharset] = "ISO-8859-1,utf-8;q=0.7,*;q=0.3";







            // foreach (var article in Articles)
            // {
            //     Links.Add(HttpUtility.HtmlDecode(article.SelectSingleNode("//a").Attributes["href"].Value));
            //}
            foreach (HtmlNode link in hdocument.DocumentNode.SelectNodes("//a[@href]"))

            {
                Links.Add(link.Attributes["href"].Value);
            }

        }
        public void SkyBetScrapeOdds(string page)
        {
            var web = new HtmlWeb();
            var doc = web.Load(page);


        }


    }
}
