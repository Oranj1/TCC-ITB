using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegurSys
{
    public partial class frmEscolher : Form
    {
        public frmEscolher()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            frmQrCode ObjfrmQrCode = new frmQrCode();

            if (cboEscolherForma.SelectedIndex == 0)
            {
                ObjfrmQrCode.lblNomeArea.Text = ObjfrmQrCode.lblNomeArea.Text + frmPontos.nomeArea;
                ObjfrmQrCode.ShowDialog();
            }
            else
            {
                frmPontos.areaCode = cboEscolherForma.SelectedItem.ToString();
                frmPontos.nomeArea = cboEscolherForma.SelectedItem.ToString();
                ObjfrmQrCode.lblNomeArea.Text = "QrCode para a " + frmPontos.nomeArea;
                ObjfrmQrCode.ShowDialog();
            }
            this.Close();
        }

        private void frmEscolher_Load(object sender, EventArgs e)
        {
            cboEscolherForma.SelectedIndex = 0;
            cboEscolherForma.Items[0] = "Ponto " + frmPontos.nomeArea;
        }
    }
}