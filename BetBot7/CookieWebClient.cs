using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BetBot7
{
    public class CookieWebClient : WebClient
    {
        public CookieContainer m_container = new CookieContainer();
        public WebProxy proxy = null;

        protected override WebRequest GetWebRequest(Uri address)
        {
            try
            {
                ServicePointManager.DefaultConnectionLimit = 1000000;
                WebRequest request = base.GetWebRequest(address);
                request.Proxy = proxy;
                //request.Proxy = new WebProxy("192.168.1.176", 5000);

                HttpWebRequest webRequest = request as HttpWebRequest;
                webRequest.Pipelined = true;
                webRequest.KeepAlive = true;
                if (webRequest != null)
                {
                    webRequest.CookieContainer = m_container;
                }

                return request;
            }
            catch
            {
                return null;
            }
        }
    }
}
