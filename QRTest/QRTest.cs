using Aquality.Selenium.Browsers;
using NUnit.Framework;
using QRTest.Utils;

namespace QRTest
{
    public class Tests : BaseTest
    {
        [Test]
        public void QRTest()
        {
            QRCoderPageObject qrCoderPageObject = new QRCoderPageObject();
            qrCoderPageObject.ClickSiteLinkBtn();
            qrCoderPageObject.SetUrl(GetTestData.Get("TestValues", "UrlA1QA"));
            qrCoderPageObject.ClickSubmitBtn();
            Assert.AreEqual(GetTestData.Get("TestValues", "UrlA1QA"), FileUtils.GetValueQRCode(qrCoderPageObject.GetQRCodeSRC()), "URL different");
        }
    }
}