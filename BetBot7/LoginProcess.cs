using BetBot7;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueBetViewer
{
    class LoginProcess : Setting
    {
        public string GetUser()
        {
            return instance.betUser;
        }
        public string GetPin()
        {
            return instance.betPin;
        }

        public ChromeOptions options = new ChromeOptions();

        public void LoginClick()
        {
            options.AddArgument("--user-agent=Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/85.0.4183.83 Safari/537.36");
            IWebDriver driver = new ChromeDriver(options);

            driver.Manage().Window.Minimize();

            driver.Navigate().GoToUrl("https://www.skybet.com/secure/identity/m/login/mvegas");

            driver.FindElement(By.XPath("//*[@id=\"username\"]")).SendKeys(GetUser());

            driver.FindElement(By.XPath("//*[@id=\"pin\"]")).SendKeys(GetPin());

            driver.FindElement(By.XPath("//*[@id=\"entry\"]/div/div[2]/div[1]/div/div[1]/form/button")).Click();

            driver.Navigate().GoToUrl("https://m.skybet.com/horse-racing");



        }



    }
}
