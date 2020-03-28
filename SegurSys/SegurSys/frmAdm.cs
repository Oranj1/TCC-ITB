using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SegurSys
{
    public partial class frmAdm : Form
    {

        clnPesquisar ObjClnPesquisar = new clnPesquisar();
        frmRegistrar ObjfrmRegistrar = new frmRegistrar();
        clnUtil ObjUtil = new clnUtil();

        public static bool sair = false;
        public static string IdOcoPrincipal = "";
        public string id, ini, fim;
        public int i = 1;
        public string idOco;

        public frmAdm()
        {
            InitializeComponent();
        }

        private void frmAdm_Load(object sender, EventArgs e)
        {
            RefreshFormAmd();
            tmAttFormAdm.Enabled = true;
            tmAttFormAdm.Interval = 5000;
            txtLast.Cursor = Cursors.Arrow; // Cursor como nos outros controles;
        }
        public void CarregaDataGrid()
        {
            dgvAtual.DataSource = ObjClnPesquisar.TrabalhamAgora(ObjUtil.DiaSemanaEmPtBr());
            dgvAtual.Columns[0].HeaderText = ("ID");
            dgvAtual.Columns[1].HeaderText = ("Funcionario");
            dgvAtual.Columns[2].HeaderText = ("Entrada");
            dgvAtual.Columns[3].HeaderText = ("Intervalo");
            dgvAtual.Columns[4].HeaderText = ("Fim Intervalo");
            dgvAtual.Columns[5].HeaderText = ("Saida");
            dgvAtual.AutoResizeColumns();
        }

        public void RefreshFormAmd()
        {
            //Pega a ultima occorencia e joga na txt apenas pra a leitura;
            CarregaDataGrid();

            SqlDataReader ObjDrDados;
            ObjDrDados = ObjClnPesquisar.LocalizarUltimaOcorrencia();

            if (ObjDrDados.Read())
            {
                txtLast.Text = ObjDrDados["acontecimento"].ToString();
                idOco = ObjDrDados["id_ocorrencia"].ToString();
            }
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisar Pesquisa = new frmPesquisar();
            Pesquisa.ShowDialog();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void pesquisarToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void pontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPontos ObjFrmPonto = new frmPontos();
            ObjFrmPonto.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrar ObjfrmRegistrar = new frmRegistrar();
            ObjfrmRegistrar.Text = "Registrar";
            ObjfrmRegistrar.btnModificar.Text = "&Registrar";
            ObjfrmRegistrar.txtAchaID.Visible = false;
            ObjfrmRegistrar.btnPesquisa.Visible = false;
            ObjfrmRegistrar.lblAidi.Text = "Digite os dados abaixo:";
            ObjfrmRegistrar.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
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
            ObjfrmRegistrar.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrar ObjfrmRegistrar = new frmRegistrar();
            ObjfrmRegistrar.Text = "Alterar";
            ObjfrmRegistrar.btnModificar.Enabled = false;
            ObjfrmRegistrar.btnModificar.Text = "&Alterar";
            ObjfrmRegistrar.txtNomeFull.Enabled = false;
            ObjfrmRegistrar.txtTel.Enabled = false;
            ObjfrmRegistrar.txtCpf.Enabled = false;
            ObjfrmRegistrar.txtRg.Enabled = false;
            ObjfrmRegistrar.mskCel.Enabled = false;
            ObjfrmRegistrar.txtRegistarLogin.Enabled = false;
            ObjfrmRegistrar.txtRegistrarSenha.Enabled = false;
            ObjfrmRegistrar.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEscala ObjFrmEscala = new frmEscala();
            ObjFrmEscala.Text = "Consultar";
            ObjFrmEscala.mskBegin.Enabled = false;
            ObjFrmEscala.mskEnd.Enabled = false;
            ObjFrmEscala.mskIntervalBegin.Enabled = false;
            ObjFrmEscala.mskIntervalEnd.Enabled = false;
            ObjFrmEscala.cboBegin.Visible = false;
            ObjFrmEscala.cboEnd.Visible = false;
            ObjFrmEscala.cboInterval.Visible = false;
            ObjFrmEscala.cboIntervalEnd.Visible = false;
            ObjFrmEscala.lblAviso.Visible = false;
            ObjFrmEscala.btnGravar.Visible = false;
            ObjFrmEscala.ckDia.Enabled = false;
            ObjFrmEscala.ShowDialog();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEscala ObjFrmEscala = new frmEscala();
            ObjFrmEscala.Text = "Alterar";
            ObjFrmEscala.ckDia.Enabled = false;
            ObjFrmEscala.cboDiaSemana.Enabled = false;
            ObjFrmEscala.mskBegin.Enabled = false;
            ObjFrmEscala.mskEnd.Enabled = false;
            ObjFrmEscala.mskIntervalBegin.Enabled = false;
            ObjFrmEscala.mskIntervalEnd.Enabled = false;
            ObjFrmEscala.cboBegin.Visible = false;
            ObjFrmEscala.cboEnd.Visible = false;
            ObjFrmEscala.cboInterval.Visible = false;
            ObjFrmEscala.cboIntervalEnd.Visible = false;
            ObjFrmEscala.lblAviso.Visible = false;
            ObjFrmEscala.btnGravar.Visible = false;
            ObjFrmEscala.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRotas ObjFrmRotas = new frmRotas();
            ObjFrmRotas.Text = "Consultar";
            ObjFrmRotas.ckDia.Enabled = false;
            ObjFrmRotas.btnSalvar.Visible = false;
            ObjFrmRotas.lbl.Visible = false;
            ObjFrmRotas.lbl0.Visible = false;
            ObjFrmRotas.lbl0_5.Visible = false;
            ObjFrmRotas.cbo1.Visible = false;
            ObjFrmRotas.cbo2.Visible = false;
            ObjFrmRotas.cboTime.Visible = false;
            ObjFrmRotas.ShowDialog();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRotas ObjFrmRotas = new frmRotas();
            ObjFrmRotas.Text = "Rondas";
            ObjFrmRotas.ckDia.Enabled = false;
            ObjFrmRotas.cboDiaSemana.Enabled = false;
            ObjFrmRotas.cbo1.Enabled = false;
            ObjFrmRotas.cbo2.Enabled = false;
            ObjFrmRotas.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin ObjLogin = new frmLogin();
            frmMessageDialog ObjMessageDialog = new frmMessageDialog();

            ObjMessageDialog.pcbQuestion.Visible = false;
            ObjMessageDialog.lbl1.Text = "Deseja realmente sair ?";
            ObjMessageDialog.ShowDialog();

            if (sair == true)
            {
                ObjLogin.Show();
                sair = false;
                frmSeguranca.sair = false;
                this.Close();
            }
        }

        private void tmAttFormAdm_Tick(object sender, EventArgs e)
        {
            RefreshFormAmd();
        }

        private void txtLast_Click(object sender, EventArgs e)
        {
            
        }

        private void txtLast_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void txtLast_DoubleClick(object sender, EventArgs e)
        {
            if (txtLast.Text != "")
            {
                SqlDataReader ObjDrDados, ObjDrNome;
                frmRegistrarOcorrencia ObjOcorrencia = new frmRegistrarOcorrencia();
                ObjDrDados = ObjClnPesquisar.PesquisaOcorrencia(idOco);
                ObjDrDados.Read();
                ObjOcorrencia.Text = "Consultar Ocorrência";
                ObjOcorrencia.id = ObjDrDados["id_ocorrencia"].ToString();
                IdOcoPrincipal = ObjDrDados["id_ocorrencia"].ToString();
                ObjOcorrencia.txtFazerOcorrencia.Text = ObjDrDados["acontecimento"].ToString();
                ObjOcorrencia.txtFazerOcorrencia.Enabled = false;
                ObjOcorrencia.mskDataOcorrido.Text = ObjDrDados["data_acontecimento"].ToString().Replace("/", "");
                ObjOcorrencia.mskDataOcorrido.Enabled = false;
                ObjOcorrencia.mskBeginOcorrido.Text = ObjDrDados["hora_de_inicio"].ToString().Replace(":", "");
                ObjOcorrencia.mskBeginOcorrido.Enabled = false;
                ObjOcorrencia.mskEndOcorrido.Text = ObjDrDados["hora_do_termino"].ToString().Replace(":", "");
                ObjOcorrencia.mskEndOcorrido.Enabled = false;
                ObjOcorrencia.mskDataRe.Text = ObjDrDados["hora_data_registro"].ToString().Substring(0, 10).Replace("/", "");
                ObjOcorrencia.mskDataRe.Visible = true;
                ObjOcorrencia.mskHoraRe.Text = ObjDrDados["hora_data_registro"].ToString().Substring(11, 5).Replace(":", "");
                ObjOcorrencia.mskHoraRe.Visible = true;
                ObjOcorrencia.cboNivel.Text = ObjDrDados["nivel_ocorrencia"].ToString();
                ObjOcorrencia.cboStatus.Text = ObjDrDados["_status"].ToString();
                ObjOcorrencia.txtPor.Visible = true;
                ObjOcorrencia.txtPor.Enabled = false;
                ObjOcorrencia.cboFunc.Visible = false;
                ObjOcorrencia.cboNivel.Enabled = false;
                SqlDataReader ObjCombo;
                string idArea = ObjDrDados["id_area"].ToString();
                ObjCombo = ObjClnPesquisar.PreencherTodosPontos(idArea);
                ObjCombo.Read();
                ObjOcorrencia.txtPonto.Text = ObjCombo["ponto"].ToString();
                ObjOcorrencia.txtPonto.Visible = true;
                ObjOcorrencia.cboArea.Visible = false;
                ObjOcorrencia.lblTitle.Text = "Ocorrencia registrada por: " + ObjDrDados["nome"].ToString();
                ObjDrNome = ObjClnPesquisar.IdDeQuemViu(ObjDrDados["visto_por"].ToString());
                if (ObjDrNome.Read())
                {
                    ObjOcorrencia.txtPor.Text = ObjDrNome["nome"].ToString();
                }
                else
                {
                    ObjOcorrencia.txtPor.Text = ObjDrDados["nome"].ToString();
                }
                ObjOcorrencia.lblTitle.Font = new Font(ObjOcorrencia.lblTitle.Font, FontStyle.Regular); //Tira o negrito (A bulacha opressora)
                ObjOcorrencia.lblAviso.Visible = false;
                ObjOcorrencia.btnOcorrencia.Visible = false;
                ObjOcorrencia.lblDataRe.Visible = true;
                ObjOcorrencia.lblHoraRe.Visible = true;
                ObjOcorrencia.cboBegin.Visible = false;
                ObjOcorrencia.cboEnd.Visible = false;
                ObjOcorrencia.btnAbrirCalendario.Visible = false;
                ObjOcorrencia.ShowDialog();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvAtual_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAtual_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRegistrar ObjfrmRegistrar = new frmRegistrar();
            ObjfrmRegistrar.Text = "Alterar";
            ObjfrmRegistrar.btnModificar.Text = "&Alterar";
            ObjfrmRegistrar.txtAchaID.Enabled = false;
            ObjfrmRegistrar.btnPesquisa.Visible = false;
            ObjfrmRegistrar.txtAchaID.Text = Convert.ToString(dgvAtual.CurrentRow.Cells[0].Value);
            ObjfrmRegistrar.ShowDialog();
        }

        private void monitoramentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMonitoramento"] == null)
            {
                frmMonitoramento ObjfrmMonitoramento = new frmMonitoramento();
                ObjfrmMonitoramento.Show();
            }
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio objFrmRelatorio = new frmRelatorio();
            objFrmRelatorio.ShowDialog();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmVerOcorrencia ObjfrmVerOcorrencia = new frmVerOcorrencia();
            ObjfrmVerOcorrencia.ShowDialog();
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistrarOcorrencia ObjRegOco = new frmRegistrarOcorrencia();
            ObjRegOco.Text = "Administrador - Registrar Ocorrência";
            ObjRegOco.ShowDialog();
        }
    }
}
