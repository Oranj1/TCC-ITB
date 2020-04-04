using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegurSys
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }
        clnPesquisar ObjClnPesquisar = new clnPesquisar();


        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            CarregaGridRel();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            CarregaGridRel();
        }
        public void CarregaGridRel()
        {
            dgvRelatorio.DataSource = ObjClnPesquisar.Relatorios();
            dgvRelatorio.Columns[0].HeaderText = ("ID");
            dgvRelatorio.Columns[1].HeaderText = ("Data");
            dgvRelatorio.Columns[2].HeaderText = ("Funcionario");
            dgvRelatorio.AutoResizeColumns();
        }

        private void btnAcha_Click(object sender, EventArgs e)
        {
            dgvRelatorio.DataSource = ObjClnPesquisar.RelatorioPorId(txtAchaId.Text.ToString());
            dgvRelatorio.Columns[0].HeaderText = ("ID");
            dgvRelatorio.Columns[1].HeaderText = ("Data");
            dgvRelatorio.Columns[2].HeaderText = ("Funcionario");
            dgvRelatorio.AutoResizeColumns();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            frmLerRelatorio ObjFrmLerRelatorio = new frmLerRelatorio();
            SqlDataReader ObjDrDados;
            ObjDrDados = ObjClnPesquisar.RelatorioPorIdLinha(dgvRelatorio.CurrentRow.Cells[0].Value.ToString());
            ObjDrDados.Read();
            ObjFrmLerRelatorio.txtNomeRel.Text = ObjDrDados["nome"].ToString();
            ObjFrmLerRelatorio.mskDataRel.Text = ObjDrDados["data"].ToString();
            ObjFrmLerRelatorio.txtRel.Text = ObjDrDados["relatorio_dia"].ToString();
            ObjFrmLerRelatorio.ShowDialog();
        }
    }
}
