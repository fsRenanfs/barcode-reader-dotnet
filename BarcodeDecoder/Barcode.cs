using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeDecodeApp.BarcodeDecoder
{
    public class Barcode
    {
        public Barcode(string code, Bitmap bitmap)
        {
            Code = code;
            Bitmap = bitmap;
        }

        public string Code { get; }
        public Bitmap Bitmap { get; }
    }
}
