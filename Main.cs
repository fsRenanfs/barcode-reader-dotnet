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
                    string file = filedialog.FileName;
                    CustomBarcodeReader customBarcodeReader = new SpireBarcodeReader(file);
                    Barcode barcode = customBarcodeReader.Decode();

                    if(barcode.Code != null)
                    {
                        lblArquivo.Text = file;
                        txtCodigoBarras.Text = barcode.Code;
                        pictureBox.Image = barcode.Bitmap;
                    }                  
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + ":  \n"+ ex.StackTrace, "ERRO AO LER IMAGEM!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
