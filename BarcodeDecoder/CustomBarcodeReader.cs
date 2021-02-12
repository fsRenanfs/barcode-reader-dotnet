using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeDecodeApp.BarcodeDecoder
{
    public abstract class CustomBarcodeReader
    {
        protected string file;

        public CustomBarcodeReader(string file)
        {
            this.file = file;
        }

        public Bitmap CropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, PixelFormat.Format24bppRgb);
        }

        public abstract Barcode Decode();       
    }
}
