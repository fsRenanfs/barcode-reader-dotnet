using System;
using System.Collections.Generic;
using System.Drawing;
using ZXing;

namespace BarcodeDecodeApp.BarcodeDecoder.libs
{
    public class ZXingBarcodeReader : CustomBarcodeReader
    {

        private readonly List<BarcodeFormat> Fmts = new List<BarcodeFormat> { BarcodeFormat.All_1D };

        public ZXingBarcodeReader(string file) : base(file)
        {

        }
        public bool DecodeImg(Bitmap img)
        {
            BarcodeReader reader = new BarcodeReader()
            {
                AutoRotate = true,
                TryInverted = true,
                Options =
                    {
                        PossibleFormats = Fmts,
                        TryHarder = true,
                        ReturnCodabarStartEnd = true,
                        PureBarcode = false
                    }
            };

            Result result = reader.Decode(img);

            if (result != null)
            {
                Console.WriteLine(result.BarcodeFormat);
                Console.WriteLine(result.Text);
                return true;
            }

            return false;
        }

        public override Barcode Decode()
        {
            BarcodeReader reader = new BarcodeReader();
            Bitmap originalBitmap = (Bitmap) Image.FromFile(file);
            Bitmap img = originalBitmap;// CropImage(originalBitmap, new Rectangle(0, 0, originalBitmap.Width, originalBitmap.Height));

            if (DecodeImg(img))
            {
                return new Barcode("deu certo", img);
            }

            return new Barcode("deu ruim", img);

        }
    }
}
