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
    public partial class frmMessageDialog : Form
    {

        public frmMessageDialog()
        {
            InitializeComponent();
        }

        private void btnNemPensar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMessageDialog_Load(object sender, EventArgs e)
        {

        }

        private void btnSimEuQuero_Click(object sender, EventArgs e)
        {
            if (pcbQuestion.Visible == false)
            {
                frmAdm.sair = true;
                frmSeguranca.sair = true;
            }
            else
            {
                frmRotas.verificador = true;
                frmPesquisar.verificador = true;
            }
            this.Close();
        }

        private void pcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
