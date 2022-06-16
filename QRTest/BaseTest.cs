using Aquality.Selenium.Browsers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QRTest
{
    public class BaseTest
    {
        [SetUp]
        public void Setup()
        {
            var browser = AqualityServices.Browser;

            browser.Maximize();
            browser.GoTo(GetTestData.Get("BrowserData", "Url"));
        }
        [TearDown]
        public void TearDown()
        {
            AqualityServices.Browser.Driver.Quit();
        }
    }
}
