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
    public partial class frmMonitoramento : Form
    {
        clnPesquisar ObjClnPesquisar = new clnPesquisar();

        public frmMonitoramento()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmAttFormAtual_Tick(object sender, EventArgs e)
        {
            RefreshFormAtual();          
        }

        private void RefreshFormAtual()
        {
            dgvAtual.DataSource = ObjClnPesquisar.PesquisarAtual();
            dgvAtual.Columns[0].HeaderText = "ID";
            dgvAtual.Columns[1].HeaderText = "Segurança";
            dgvAtual.Columns[2].HeaderText = "Em Turno";
            dgvAtual.Columns[3].HeaderText = "Em Intervalo";
            dgvAtual.Columns[4].HeaderText = "Ponto Atual";
            dgvAtual.Columns[5].HeaderText = "Proximo Ponto";
        }

        private void frmMonitoramento_Load(object sender, EventArgs e)
        {
            RefreshFormAtual();
            tmAttFormAtual.Enabled = true;
            tmAttFormAtual.Interval = 1000;
        }

        private void dgvAtual_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAtual_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
