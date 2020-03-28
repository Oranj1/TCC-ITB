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
    public partial class frmPesquisar : Form
    {
        clnPesquisar ObjClnPesquisar = new clnPesquisar();
        clnFuncionario ObjClnFuncionario = new clnFuncionario();
        clnUtil ObjUtil = new clnUtil();
        frmMessageBoxAviso ObjMessageAviso = new frmMessageBoxAviso();
        public static bool verificador = false;

        public frmPesquisar()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" && txtNome.Text == "")
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "Digite um ID ou nome";
                ObjMessageAviso.ShowDialog();

                dgvPesquisar.DataSource = null;
                limparDgv();
            }
            else if (txtID.Text != "" && txtNome.Text != "")
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "Digite apenas um ID ou \n um nome";
                ObjMessageAviso.ShowDialog();

                dgvPesquisar.DataSource = null;
                limparDgv();
            }
            else
            {
                dgvPesquisar.DataSource = null;

                if (txtID.Text != "")
                {
                    CarregaDataGridPorId();

                    if (dgvPesquisar.RowCount == 0)
                    {
                        ObjMessageAviso.pcbCaution.Visible = true;
                        ObjMessageAviso.lbl1.Text = "Não foram encontrados dados \n com esse ID";
                        ObjMessageAviso.ShowDialog();

                        dgvPesquisar.DataSource = null;
                        limparDgv();
                    }
                }
                if (txtNome.Text != "")
                {
                    CarregaDataGrid();

                    if (dgvPesquisar.RowCount == 0)
                    {
                        ObjMessageAviso.pcbCaution.Visible = true;
                        ObjMessageAviso.lbl1.Text = "Não foram encontrados dados \n com esse Nome";
                        ObjMessageAviso.ShowDialog();

                        dgvPesquisar.DataSource = null;
                        limparDgv();
                    }
                }
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPesquisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CarregaDataGrid()
        {
            if (Marcado() == false)
            {
                dgvPesquisar.DataSource = ObjClnPesquisar.LocalizarPorNome(txtNome.Text);
                dgvPesquisar.Columns[0].HeaderText = ("ID");
                dgvPesquisar.Columns[1].HeaderText = ("Nome");
            }
            else
            {
                dgvPesquisar.DataSource = ObjClnPesquisar.LocalizarPorNomeComDia(txtNome.Text, ObjUtil.DiaSemanaEmPtBr());
                dgvPesquisar.Columns[0].HeaderText = ("ID");
                dgvPesquisar.Columns[1].HeaderText = ("Nome");
                dgvPesquisar.Columns[2].HeaderText = ("Periodo de " + ObjUtil.DiaSemanaEmPtBr());
            }
            dgvPesquisar.AutoResizeColumns();
            limparDgv();
        }
        public void CarregaDataGridPorId()
        {
            if (Marcado() == false)
            {
                dgvPesquisar.DataSource = ObjClnPesquisar.LocalizarPorId(txtID.Text);
                dgvPesquisar.Columns[0].HeaderText = ("ID");
                dgvPesquisar.Columns[1].HeaderText = ("Nome");
            }
            else
            {
                dgvPesquisar.DataSource = ObjClnPesquisar.LocalizarPorIdComDia(txtNome.Text, ObjUtil.DiaSemanaEmPtBr());
                dgvPesquisar.Columns[0].HeaderText = ("ID");
                dgvPesquisar.Columns[1].HeaderText = ("Nome");
                dgvPesquisar.Columns[2].HeaderText = ("Periodo de " + ObjUtil.DiaSemanaEmPtBr());
            }
            dgvPesquisar.AutoResizeColumns();
            limparDgv();
        }

        private void frmPesquisar_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtID.Text = "";
            CarregaDataGrid();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmRegistrar ObjfrmRegistrar = new frmRegistrar();
            ObjfrmRegistrar.Text = "Consultar";
            ObjfrmRegistrar.btnModificar.Visible = false;
            ObjfrmRegistrar.txtNomeFull.Enabled = false;
            ObjfrmRegistrar.txtTel.Enabled = false;
            ObjfrmRegistrar.txtCpf.Enabled = false;
            ObjfrmRegistrar.txtRg.Enabled = false;
            ObjfrmRegistrar.mskCel.Enabled = false;
            ObjfrmRegistrar.txtRegistarLogin.Enabled = false;
            ObjfrmRegistrar.txtRegistrarSenha.Enabled = false;
            ObjfrmRegistrar.txtAchaID.Enabled = false;
            ObjfrmRegistrar.btnPesquisa.Visible = false;
            ObjfrmRegistrar.txtAchaID.Text = Convert.ToString(dgvPesquisar.CurrentRow.Cells[0].Value);
            ObjfrmRegistrar.ShowDialog();
            CarregaDataGrid();
        }

        private void btnRondas_Click(object sender, EventArgs e)
        {
            frmRotas ObjFrmRotas = new frmRotas();
            ObjFrmRotas.btnPesquisar.Visible = false;
            ObjFrmRotas.txtAchaIDRonda.Enabled = false;
            ObjFrmRotas.ShowDialog();
        }
        public void limparDgv()
        {
            if (dgvPesquisar.RowCount == 0)
            {
                btnAlterar.Enabled = false;
                btnConsultar.Enabled = false;
                btnExcluir.Enabled = false;
                txtNome.Focus();
            }
            else
            {
                btnAlterar.Enabled = true;
                btnConsultar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmRegistrar ObjfrmRegistrar = new frmRegistrar();
            ObjfrmRegistrar.Text = "Registrar";
            ObjfrmRegistrar.btnModificar.Text = "&Registrar";
            ObjfrmRegistrar.txtAchaID.Visible = false;
            ObjfrmRegistrar.btnPesquisa.Visible = false;
            ObjfrmRegistrar.lblAidi.Text = "Digite os dados abaixo:";
            ObjfrmRegistrar.ShowDialog();
            txtNome.Text = "";
            txtID.Text = "";
            CarregaDataGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmRegistrar ObjfrmRegistrar = new frmRegistrar();
            ObjfrmRegistrar.Text = "Alterar";
            ObjfrmRegistrar.btnModificar.Text = "&Alterar";
            ObjfrmRegistrar.txtAchaID.Enabled = false;
            ObjfrmRegistrar.btnPesquisa.Visible = false;
            ObjfrmRegistrar.txtAchaID.Text = Convert.ToString(dgvPesquisar.CurrentRow.Cells[0].Value);
            ObjfrmRegistrar.ShowDialog();
            CarregaDataGrid();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nomeFull = Convert.ToString(dgvPesquisar.CurrentRow.Cells[1].Value);
            string[] nome = nomeFull.Split(' ');

            frmMessageDialog ObjMessageDialog = new frmMessageDialog();
            ObjMessageDialog.pcbQuestion.Visible = true;
            ObjMessageDialog.lbl1.Text = "Deseja Exluir o Registo " + Convert.ToString(dgvPesquisar.CurrentRow.Cells[0].Value) + " com o \n nome de " + nome[0] + " ?" + " \n Essa ação não poderá ser desfeita";
            ObjMessageDialog.ShowDialog();

            if (verificador == true)
            {
                verificador = false;
                ObjClnFuncionario.Id = dgvPesquisar.CurrentRow.Cells[0].Value.ToString();
                ObjClnFuncionario.ExclusaoLogica();

                ObjMessageAviso.pcbCaution.Visible = false;
                ObjMessageAviso.lbl1.Text = "Registro Excluido com sucesso";
                ObjMessageAviso.ShowDialog();

                CarregaDataGrid();
            }
            else
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "Nenhuma exclusão foi feita";
                ObjMessageAviso.ShowDialog();
            }
        }

        private void ckFiltrarHoje_CheckedChanged(object sender, EventArgs e)
        {
            Marcado();
        }
        public bool Marcado()
        {
            if (ckFiltrarHoje.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            ObjUtil.ApenasNumeros(sender, e);
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dgvPesquisar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRegistrar ObjfrmRegistrar = new frmRegistrar();
            ObjfrmRegistrar.Text = "Alterar";
            ObjfrmRegistrar.btnModificar.Text = "&Alterar";
            ObjfrmRegistrar.txtAchaID.Enabled = false;
            ObjfrmRegistrar.btnPesquisa.Visible = false;
            ObjfrmRegistrar.txtAchaID.Text = Convert.ToString(dgvPesquisar.CurrentRow.Cells[0].Value);
            ObjfrmRegistrar.ShowDialog();
        }
    }
}
