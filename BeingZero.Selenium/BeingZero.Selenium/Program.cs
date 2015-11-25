using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace BeingZero.Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Launch Mozilla Firefox Browser and Maximize it 
            IWebDriver wd = new FirefoxDriver();
            wd.Manage().Window.Maximize();

            // 2. Goto http://beingzero.in
            wd.Url = "http://beingzero.in";


            // 3. Wait for 10 seconds
            Thread.Sleep(TimeSpan.FromSeconds(10));


            // 4. Quit the Browser
            wd.Quit();
        }
    }
}
