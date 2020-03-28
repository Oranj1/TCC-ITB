using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegurSys
{
    public partial class frmQrCode : Form
    {
        public frmQrCode()
        {
            InitializeComponent();
        }

        private void frmQrCode_Load(object sender, EventArgs e)
        {
            pcQrCode.Image = GerarQRCode(frmPontos.areaCode);
        }
        public Bitmap GerarQRCode(string texto)
        {
            try
            {
                var bw = new ZXing.BarcodeWriter();
                var encOptions = new ZXing.Common.EncodingOptions() { Width = 400, Height = 400, Margin = 0 };
                bw.Options = encOptions;
                bw.Format = ZXing.BarcodeFormat.QR_CODE;
                var resultado = new Bitmap(bw.Write(texto));
                return resultado;
            }
            catch
            {
                throw;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(Imprimir);
            pd.Print();
        }

        public void Imprimir(object sender, PrintPageEventArgs e)
        {
            Image i = pcQrCode.Image;
            //local de impressão 50 x, 50 y.
            e.Graphics.DrawImage(i, 240, 50);
        }
    }
}
