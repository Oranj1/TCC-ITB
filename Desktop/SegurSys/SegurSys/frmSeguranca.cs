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
    public partial class frmSeguranca : Form
    {
        private string _id;
        public static bool sair = false;

        clnPesquisar ObjClnPesquisar = new clnPesquisar();
        frmMessageDialog ObjMessageDialog = new frmMessageDialog();

        public string Id { get => _id; set => _id = value; }

        public frmSeguranca()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmSeguranca_Load(object sender, EventArgs e)
        {
            RefreshFormSeguranca();
            tmAttFormSegur.Enabled = true;
            tmAttFormSegur.Interval = 5000;
        }

        public void RefreshFormSeguranca()
        {
            SqlDataReader ObjDrDados;
            ObjDrDados = ObjClnPesquisar.LocalizarUltimaOcorrencia();
            if (ObjDrDados.Read())
            {
                txtLast.Text = ObjDrDados["acontecimento"].ToString();
            }
        }

        private void registrarOcorrênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarOcorrencia Ocorrencia = new frmRegistrarOcorrencia();
            Ocorrencia.Text = "Funcionario - Ocorrência";
            Ocorrencia.user = lblUser.Text;
            Ocorrencia.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmLogin ObjLogin = new frmLogin();

            ObjMessageDialog.pcbQuestion.Visible = false;
            ObjMessageDialog.lbl1.Text = "Deseja realmente sair ?";
            ObjMessageDialog.ShowDialog();

            if (sair == true)
            {
                ObjLogin.Show();
                sair = false;
                frmAdm.sair = false;
                this.Close();
            }
        }

        private void tmAttFormSegur_Tick(object sender, EventArgs e)
        {
            RefreshFormSeguranca();
        }

        private void dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrar ObjfrmRegistrar = new frmRegistrar();
            SqlDataReader ObjDrDados;
            ObjDrDados = ObjClnPesquisar.LocalizarNivelAcesso(lblUser.Text);

            if (ObjDrDados.Read())
            {
                ObjfrmRegistrar.lblAidi.Text = "Mostrando dados para o usuario: " + lblUser.Text;
                ObjfrmRegistrar.lblAidi.Font = new Font(ObjfrmRegistrar.lblAidi.Font.FontFamily, 10);
                ObjfrmRegistrar.btnPesquisa.Visible = false;
                ObjfrmRegistrar.txtAchaID.Visible = false;
                ObjfrmRegistrar.txtNomeFull.Enabled = false;
                ObjfrmRegistrar.txtTel.Enabled = false;
                ObjfrmRegistrar.txtCpf.Enabled = false;
                ObjfrmRegistrar.txtRg.Enabled = false;
                ObjfrmRegistrar.mskCel.Enabled = false;
                ObjfrmRegistrar.txtRegistarLogin.Enabled = false;
                ObjfrmRegistrar.txtRegistrarSenha.Enabled = false;
                ObjfrmRegistrar.btnModificar.Visible = false;
                ObjfrmRegistrar.lblAviso.Visible = false;
                ObjfrmRegistrar.lblAviso.Text = ObjDrDados["id_func"].ToString();
                ObjfrmRegistrar.txtNomeFull.Text = ObjDrDados["nome"].ToString();
                ObjfrmRegistrar.txtTel.Text = ObjDrDados["telefone"].ToString();
                ObjfrmRegistrar.mskCel.Text = ObjDrDados["celular"].ToString();
                ObjfrmRegistrar.txtCpf.Text = ObjDrDados["cpf"].ToString();
                ObjfrmRegistrar.txtRg.Text = ObjDrDados["rg"].ToString();
                ObjfrmRegistrar.txtRegistarLogin.Text = ObjDrDados["usuario"].ToString();
                ObjfrmRegistrar.txtRegistrarSenha.Text = ObjDrDados["senha"].ToString();
                ObjfrmRegistrar.ShowDialog();
            }
        }

        private void escalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEscala ObjFrmEscala = new frmEscala();
            ObjFrmEscala.cboDiaSemana.SelectedIndex = 0;
            ObjFrmEscala.btnPesquisar.Visible = false;
            ObjFrmEscala.txtId.Visible = false;
            ObjFrmEscala.lblAidi.Visible = false;
            ObjFrmEscala.Text = "Consultar";
            ObjFrmEscala.mskBegin.Enabled = false;
            ObjFrmEscala.mskEnd.Enabled = false;
            ObjFrmEscala.mskIntervalBegin.Enabled = false;
            ObjFrmEscala.cboBegin.Visible = false;
            ObjFrmEscala.cboEnd.Visible = false;
            ObjFrmEscala.cboInterval.Visible = false;
            ObjFrmEscala.cboIntervalEnd.Visible = false;
            ObjFrmEscala.mskIntervalEnd.Enabled = false;
            ObjFrmEscala.lblAviso.Visible = false;
            ObjFrmEscala.btnGravar.Visible = false;
            ObjFrmEscala.ckDia.Enabled = false;
            ObjFrmEscala.btnPesquisar.Visible = false;
            ObjFrmEscala.lblUsuario.Location = new Point(ObjFrmEscala.lblUsuario.Location.X, ObjFrmEscala.lblUsuario.Location.Y - 40);
            SqlDataReader ObjDrDados, ObjDrNome, ObjDrId;
            ObjDrId = ObjClnPesquisar.LocalizarNivelAcesso(lblUser.Text);
            ObjDrId.Read();
            string id = ObjDrId["id_func"].ToString();
            ObjDrDados = ObjClnPesquisar.AchaDiaPorId(id, "Domingo");
            ObjDrNome = ObjClnPesquisar.LocalizarId(id);

            if (ObjDrDados.Read() && ObjDrNome.Read())
            {
                ObjFrmEscala.lblDia.Text = "";
                ObjFrmEscala.lblUsuario.Text = "Escala De: " + ObjDrNome["nome"].ToString();
                ObjFrmEscala.mskBegin.Text = ObjDrDados["horario_de_inicio"].ToString();
                ObjFrmEscala.mskEnd.Text = ObjDrDados["horario_de_termino"].ToString();
                ObjFrmEscala.mskIntervalBegin.Text = ObjDrDados["horario_intervalo"].ToString();
                ObjFrmEscala.mskIntervalEnd.Text = ObjDrDados["horario_termino_intervalo"].ToString();
            }
            else if (ObjDrNome.Read())
            {
                ObjFrmEscala.lblUsuario.Text = "Escala De: " + ObjDrNome["nome"].ToString();
            }
            ObjFrmEscala.id = id;
            ObjFrmEscala.ShowDialog();
        }

        private void rondasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRotas ObjFrmRotas = new frmRotas();
            SqlDataReader ObjDrId;
            ObjFrmRotas.btnPesquisar.Visible = false;
            ObjFrmRotas.txtAchaIDRonda.Visible = false;
            ObjDrId = ObjClnPesquisar.LocalizarNivelAcesso(lblUser.Text);
            ObjDrId.Read();
            string id = ObjDrId["id_func"].ToString();
            string user = ObjDrId["usuario"].ToString();
            ObjFrmRotas.lblIdRondas.Font = new Font(ObjFrmRotas.lblIdRondas.Font.FontFamily, 10);
            ObjFrmRotas.lblIdRondas.Text = "Exibindo a ronda de " + user;
            ObjFrmRotas.Text = "Consultar";
            ObjFrmRotas.id = id;
            ObjFrmRotas.txtAchaIDRonda.Text = id;
            ObjFrmRotas.btnPesquisar.Visible = false;
            ObjFrmRotas.ckDia.Enabled = false;
            ObjFrmRotas.btnSalvar.Visible = false;
            ObjFrmRotas.cboDiaSemana.SelectedIndex = 0;
            ObjFrmRotas.ShowDialog();
        }
    }
}
