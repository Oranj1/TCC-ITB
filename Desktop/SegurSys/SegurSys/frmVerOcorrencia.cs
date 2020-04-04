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
    public partial class frmVerOcorrencia : Form
    {
        clnPesquisar ObjClnPesquisar = new clnPesquisar();
        frmMessageBoxAviso ObjMessageAviso = new frmMessageBoxAviso();
        frmRegistrarOcorrencia ObjOcorrencia = new frmRegistrarOcorrencia();
        clnUtil ObjUtil = new clnUtil();
        public static string idOco = "";

        public void CarregaDataGridPorId()
        {
            dgvOcorrorencias.DataSource = ObjClnPesquisar.LocalizarIdOcorrencia(txtAchaId.Text);
            dgvOcorrorencias.Columns[0].HeaderText = ("ID");
            dgvOcorrorencias.Columns[1].HeaderText = ("Data e Hora de Registro");
            dgvOcorrorencias.Columns[2].HeaderText = ("Funcionario que Registrou");
            dgvOcorrorencias.Columns[3].HeaderText = ("Nivel da Ocorrência");
            dgvOcorrorencias.Columns[4].HeaderText = ("Status");
            dgvOcorrorencias.AutoResizeColumns();
            limparDgv();
        }
        public frmVerOcorrencia()
        {
            InitializeComponent();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVerOcorrencia_Load(object sender, EventArgs e)
        {
            CarregaTodoGrid();
        }
        public void limparDgv()
        {
            if (dgvOcorrorencias.RowCount == 0)
            {
                btnMais.Enabled = false;

            }
            else
            {
                btnMais.Enabled = true;
            }
        }

        private void btnAcha_Click(object sender, EventArgs e)
        {
            if(txtAchaId.Text == "")
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "Digite um ID";
                ObjMessageAviso.ShowDialog();
            }
            else
            {
                CarregaDataGridPorId();
            }
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            CarregaTodoGrid();
        }

        public void CarregaTodoGrid()
        {
            dgvOcorrorencias.DataSource = ObjClnPesquisar.LocalizarIdOcorrenciaSemId();
            dgvOcorrorencias.Columns[0].HeaderText = ("ID");
            dgvOcorrorencias.Columns[1].HeaderText = ("Data e Hora de Registro");
            dgvOcorrorencias.Columns[2].HeaderText = ("Funcionario que Registrou");
            dgvOcorrorencias.Columns[3].HeaderText = ("Nivel da Ocorrência");
            dgvOcorrorencias.Columns[4].HeaderText = ("Status");
            dgvOcorrorencias.AutoResizeColumns();
            limparDgv();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            SqlDataReader ObjDrDados, ObjDrNome;
            ObjDrDados = ObjClnPesquisar.PesquisaOcorrencia(Convert.ToString(dgvOcorrorencias.CurrentRow.Cells[0].Value));
            idOco = Convert.ToString(dgvOcorrorencias.CurrentRow.Cells[0].Value);
            ObjDrDados.Read();
            ObjOcorrencia.Text = "Consultar Ocorrência";
            ObjOcorrencia.id = ObjDrDados["id_ocorrencia"].ToString();
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
            CarregaTodoGrid();
        }

        private void txtAchaId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ObjUtil.ApenasNumeros(sender, e);
        }

        private void txtAchaId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvOcorrorencias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataReader ObjDrDados, ObjDrNome;
            ObjDrDados = ObjClnPesquisar.PesquisaOcorrencia(Convert.ToString(dgvOcorrorencias.CurrentRow.Cells[0].Value));
            idOco = Convert.ToString(dgvOcorrorencias.CurrentRow.Cells[0].Value);
            ObjDrDados.Read();
            ObjOcorrencia.Text = "Consultar Ocorrência";
            ObjOcorrencia.id = ObjDrDados["id_ocorrencia"].ToString();
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
            CarregaTodoGrid();
        }

        private void dgvOcorrorencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
