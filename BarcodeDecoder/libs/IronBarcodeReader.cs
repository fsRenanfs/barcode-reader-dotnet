using IronBarCode;
using System.Configuration;
using System.Drawing;


namespace BarcodeDecodeApp.BarcodeDecoder.libs
{
    public class IronBarcodeReader : CustomBarcodeReader
    {
        public IronBarcodeReader(string file) : base(file)
        {
        }

        public override Barcode Decode()
        {
            var t = ConfigurationManager.AppSettings["IronBarCode.LicenseKey"];
            bool result = IronBarCode.License.IsLicensed;

            BarcodeResult QRResult = BarcodeReader.QuicklyReadOneBarcode(file);

            // Work with the results
            if (QRResult != null)
            {
                string value = QRResult.Value;
                Bitmap Img = QRResult.BarcodeImage;
                BarcodeEncoding BarcodeType = QRResult.BarcodeType;

                return new Barcode(value, Img);
            }

            return null;
        }
    }
}
