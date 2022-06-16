using Aquality.Selenium.Elements.Interfaces;
using Aquality.Selenium.Forms;
using OpenQA.Selenium;

namespace QRTest
{
    public class QRCoderPageObject : Form
    {
        private ITextBox urlTB = ElementFactory.GetTextBox(By.XPath("//div[contains(@class,'formBody')]//input[@type='text']"), "URL text box");
        private IButton submitBtn = ElementFactory.GetButton(By.XPath("//div[contains(@class,'formBottom')]//input[@type='submit']"), "Submit Button");
        private IButton siteLinkBtn = ElementFactory.GetButton(By.XPath("//a[@href='/?t=l']"), "Site link button");
        private ILabel qrCodeImg = ElementFactory.GetLabel(By.XPath("//div[contains(@class,'right')]/div[contains(@class,'image')]/img"), "QR Code Image");

        public QRCoderPageObject() : base(By.XPath("//div[@id='pageContent']"), "Content Page")
        {
        }

        public void SetUrl(string url)
        {
            urlTB.ClearAndType(url);
        }

        public void ClickSubmitBtn()
        {
            submitBtn.Click();
        }

        public void ClickSiteLinkBtn()
        {
            siteLinkBtn.WaitAndClick();
        }

        public string GetQRCodeSRC()
        {
            return qrCodeImg.GetAttribute("src");
        }
    }
}
