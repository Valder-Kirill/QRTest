using Aquality.Selenium.Browsers;
using NUnit.Framework;
using QRTest.Utils;

namespace QRTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            var browser = AqualityServices.Browser;

            browser.Maximize();
            browser.GoTo(GetTestData.Get("BrowserData", "Url"));
        }

        [Test]
        public void QRTest()
        {
            QRCoderPageObject qrCoderPageObject = new QRCoderPageObject();
            qrCoderPageObject.ClickSiteLinkBtn();
            qrCoderPageObject.SetUrl(GetTestData.Get("TestValues", "UrlA1QA"));
            qrCoderPageObject.ClickSubmitBtn();
            Assert.AreEqual(GetTestData.Get("TestValues", "UrlA1QA"), FileUtils.GetValueQRCode(qrCoderPageObject.GetQRCodeSRC()), "URL different");
        }

        [TearDown]
        public void TearDown()
        {
            AqualityServices.Browser.Driver.Quit();
        }
    }
}