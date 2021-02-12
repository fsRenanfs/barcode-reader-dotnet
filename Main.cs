using System;
using System.Windows.Forms;
using BarcodeDecodeApp.BarcodeDecoder;
using BarcodeDecodeApp.BarcodeDecoder.libs;

namespace BarcodeDecodeApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnImportarArq_Click(object sender, EventArgs e)
        {
            if(filedialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    CustomBarcodeReader customBarcodeReader = new SpireBarcodeReader(filedialog.FileName);
                    Barcode barcode = customBarcodeReader.Decode();

                    if(barcode.Code != null)
                    {
                        txtCodigoBarras.Text = barcode.Code;
                        pictureBox.Image = barcode.Bitmap;
                    }                  
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.StackTrace, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
