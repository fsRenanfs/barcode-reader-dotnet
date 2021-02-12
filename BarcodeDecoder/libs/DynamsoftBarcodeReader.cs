using Dynamsoft.DBR;
using System;

namespace BarcodeDecodeApp.BarcodeDecoder.libs
{
    public class DynamsoftBarcodeReader : CustomBarcodeReader
    {
        public DynamsoftBarcodeReader(string file) : base(file)
        {
        }

        public override Barcode Decode()
        {
            BarcodeReader reader = new BarcodeReader();
            return null;
            //PArece 
           // reader.DecodeBitmap();
        }
    }
}
