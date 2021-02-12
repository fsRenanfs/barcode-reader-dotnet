using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeDecodeApp.BarcodeDecoder.libs
{
    public class SpireBarcodeReader : CustomBarcodeReader
    {
        public SpireBarcodeReader(string file) : base(file)
        {
        }

        public override Barcode Decode()
        {
            string result = Spire.Barcode.BarcodeScanner.ScanOne(file, true);

            return new Barcode(result, (Bitmap) Image.FromFile(file));
        }
    }
}
