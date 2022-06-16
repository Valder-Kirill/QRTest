using System.Drawing;
using System.IO;
using System.Net;
using ZXing;

namespace QRTest.Utils
{
    public static class FileUtils
    {
        public static string GetValueQRCode(string url)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(url);
            MemoryStream ms = new MemoryStream(bytes);
            Image img = System.Drawing.Image.FromStream(ms);
            IBarcodeReader reader = new BarcodeReader();
            var barcodeBitmap = (Bitmap)img;
            var result = reader.Decode(barcodeBitmap);
            return result.Text;
        }
    }
}
