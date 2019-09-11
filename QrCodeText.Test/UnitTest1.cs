using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace QrCodeText.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReadQrCode()
        {
            var bar = new BarcodeReader();
            bar.Options = new DecodingOptions {
                PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.QR_CODE }
            };
            var bitmap = (Bitmap)Bitmap.FromFile("D:\\a.png");
            var result = bar.Decode(bitmap);
            Console.WriteLine(result.Text);
        }
    }
}
