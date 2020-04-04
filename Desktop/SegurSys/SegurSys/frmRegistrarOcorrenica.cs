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
    public partial class frmRegistrarOcorrencia : Form
    {
        clnUtil objUtil = new clnUtil();
        clnOcorrencia ObjClnOcorrencia = new clnOcorrencia();
        clnPesquisar ObjClnPesquisar = new clnPesquisar();
        frmMessageBoxAviso ObjMessageAviso = new frmMessageBoxAviso();

        public string user, id;

        public frmRegistrarOcorrencia()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaidai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOcorrencia_Click(object sender, EventArgs e)
        {
            clnUtil.ValidarHora(mskDataOcorrido.Text);
            objUtil.DataOcorrencia = mskDataOcorrido.Text;
            if (Text == "Consultar Ocorrência" && cboStatus.SelectedIndex != -1)
            {
                if (frmAdm.IdOcoPrincipal != "")
                {
                    //Executa update como frmAdm;
                    ObjClnOcorrencia.IdOco = frmAdm.IdOcoPrincipal;
                    frmAdm.IdOcoPrincipal = "";
                }
                else
                {
                    //Executa update como frmVerOco;
                    ObjClnOcorrencia.IdOco = frmVerOcorrencia.idOco;
                    frmVerOcorrencia.idOco = "";
                }
                ObjClnOcorrencia.Status = cboStatus.Text;
                ObjClnOcorrencia.MudarStatus();

                ObjMessageAviso.pcbCaution.Visible = false;
                ObjMessageAviso.lbl1.Text = "Status Alterado com sucesso";
                ObjMessageAviso.ShowDialog();

                btnOcorrencia.Visible = false;
                btnOcorrencia.Text = "Registrar &Ocorrência";
            }
            else
            {

                if (objUtil.ValidarData() == false)
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "Data inválida";
                    ObjMessageAviso.ShowDialog();
                }
                else if (mskBeginOcorrido.TextLength != 5 || mskEndOcorrido.TextLength != 5)
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "O horário deve ser preenchido";
                    ObjMessageAviso.ShowDialog();
                }
                else if (clnUtil.ValidarHora(mskBeginOcorrido.Text) == false || clnUtil.validarHoraNull(mskEndOcorrido.Text) == false)
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "Horário Inválido";
                    ObjMessageAviso.ShowDialog();
                }
                else if (txtFazerOcorrencia.TextLength <= 4)
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "A Ocorrência deve conter \n pelo menos 5 caracteres";
                    ObjMessageAviso.ShowDialog();
                }
                else if (cboNivel.SelectedIndex == -1)
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "Um nível deve ser escolhido";
                    ObjMessageAviso.ShowDialog();
                }
                else if (cboArea.SelectedIndex == -1)
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "Uma area deve ser escolhida";
                    ObjMessageAviso.ShowDialog();
                }
                else if (cboStatus.SelectedIndex == -1)
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "A ocorrência deve ter um status";
                    ObjMessageAviso.ShowDialog();
                }
                else
                {
                    if (Text != "Administrador - Registrar Ocorrência")
                    {
                        ObjClnOcorrencia.Area = cboArea.Text;
                        ObjClnOcorrencia.DataAcontecimento = mskDataOcorrido.Text.Substring(0, 2) + "/" + mskDataOcorrido.Text.Substring(2, 2) + "/" + mskDataOcorrido.Text.Substring(4);
                        if (mskEndOcorrido.Text.Length != 0)
                        {
                            ObjClnOcorrencia.Fim = mskEndOcorrido.Text.Substring(0, 2) + ":" + mskEndOcorrido.Text.Substring(2);
                        }
                        else
                        {
                            ObjClnOcorrencia.Fim = "";
                        }
                        ObjClnOcorrencia.Inicio = mskBeginOcorrido.Text.Substring(0, 2) + ":" + mskBeginOcorrido.Text.Substring(2);
                        ObjClnOcorrencia.Nivel = cboNivel.Text;
                        ObjClnOcorrencia.Texto = txtFazerOcorrencia.Text.Replace("'", "");
                        frmRegistrar ObjfrmRegistrar = new frmRegistrar();
                        SqlDataReader ObjDrDados, ObjDrFunc, ObjDrId;
                        ObjDrId = ObjClnPesquisar.LocalizarNivelAcesso(user);
                        ObjDrId.Read();
                        ObjClnOcorrencia.Id = ObjDrId["id_func"].ToString();
                        ObjDrDados = ObjClnPesquisar.PegaIdArea(cboArea.Text);
                        ObjDrDados.Read();
                        ObjClnOcorrencia.Area = ObjDrDados["id_area"].ToString();
                        ObjClnOcorrencia.Status = cboStatus.Text;
                        ObjDrFunc = ObjClnPesquisar.LocalizarIdPorNome(cboFunc.Text);
                        if (ObjDrFunc.Read())
                        {
                            ObjClnOcorrencia.IdVistoPor = ObjDrFunc["id_func"].ToString();
                        }
                        ObjClnOcorrencia.RegistrarOcorrencia();

                        ObjMessageAviso.pcbCaution.Visible = false;
                        ObjMessageAviso.lbl1.Text = "Ocorrência Registrada com sucesso";
                        ObjMessageAviso.ShowDialog();
                        LimparForm();
                    }
                    else
                    {
                        ObjClnOcorrencia.Area = cboArea.Text;
                        ObjClnOcorrencia.DataAcontecimento = mskDataOcorrido.Text.Substring(0, 2) + "/" + mskDataOcorrido.Text.Substring(2, 2) + "/" + mskDataOcorrido.Text.Substring(4);
                        if (mskEndOcorrido.Text.Length != 0)
                        {
                            ObjClnOcorrencia.Fim = mskEndOcorrido.Text.Substring(0, 2) + ":" + mskEndOcorrido.Text.Substring(2);
                        }
                        else
                        {
                            ObjClnOcorrencia.Fim = "";
                        }
                        ObjClnOcorrencia.Inicio = mskBeginOcorrido.Text.Substring(0, 2) + ":" + mskBeginOcorrido.Text.Substring(2);
                        ObjClnOcorrencia.Nivel = cboNivel.Text;
                        ObjClnOcorrencia.Texto = txtFazerOcorrencia.Text;
                        frmRegistrar ObjfrmRegistrar = new frmRegistrar();
                        SqlDataReader ObjDrDados, ObjDrFunc, ObjDrId;
                        ObjDrId = ObjClnPesquisar.LocalizarNivelAcesso(clnLogin.UsuarioAdm);
                        ObjDrId.Read();
                        ObjClnOcorrencia.Id = ObjDrId["id_func"].ToString();
                        ObjDrDados = ObjClnPesquisar.PegaIdArea(cboArea.Text);
                        ObjDrDados.Read();
                        ObjClnOcorrencia.Area = ObjDrDados["id_area"].ToString();
                        ObjClnOcorrencia.Status = cboStatus.Text;
                        ObjDrFunc = ObjClnPesquisar.LocalizarIdPorNome(cboFunc.Text);
                        if (ObjDrFunc.Read())
                        {
                            ObjClnOcorrencia.IdVistoPor = ObjDrFunc["id_func"].ToString();
                        }
                        ObjClnOcorrencia.RegistrarOcorrencia();

                        ObjMessageAviso.pcbCaution.Visible = false;
                        ObjMessageAviso.lbl1.Text = "Ocorrência Registrada com sucesso";
                        ObjMessageAviso.ShowDialog();
                        LimparForm();
                    }
                }
            }
        }

        private void frmRegistrarOcorrencia_Load(object sender, EventArgs e)
        {
            PreencherCombos();
            mskBeginOcorrido.BringToFront();
            mskEndOcorrido.BringToFront();
            if(mskDataOcorrido.Text == "")
            {
                DateTime dateAgora = DateTime.Now;
                string agora = dateAgora.ToString();
                agora = agora.Replace("/", "").Substring(0, 8);
                mskDataOcorrido.Text = agora;
            }
        }

        public void PreencherCombos()
        {
            cboArea.DataSource = ObjClnPesquisar.PreencherComboRonda();
            cboArea.ValueMember = "ponto";
            cboArea.SelectedIndex = -1;
            cboFunc.DataSource = ObjClnPesquisar.LocalizarPorNome("");
            cboFunc.ValueMember = "nome";
            if (Text != "Consultar Ocorrência")
            {
                cboFunc.SelectedIndex = -1;
                cboStatus.SelectedIndex = -1;
            }
        }

        private void mskDataOcorrido_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskDataOcorrido_TextChanged(object sender, EventArgs e)
        {
            epData.Clear();
        }

        private void mskBeginOcorrido_TextChanged(object sender, EventArgs e)
        {
            epIniOco.Clear();
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Text == "Consultar Ocorrência" && cboStatus.SelectedIndex != -1)
            {
                btnOcorrencia.Text = "Alterar &Status";
                btnOcorrencia.Visible = true;
            }
        }

        private void cboNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboBegin_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskBeginOcorrido.Text = cboBegin.Text.Replace(":", "");
        }

        private void cboEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskEndOcorrido.Text = cboEnd.Text.Replace(":", "");
        }

        private void btnAbrirCalendario_Click(object sender, EventArgs e)
        {
            if (mcCalendario.Visible == false)
            {
                mcCalendario.Visible = true;
                mcCalendario.BringToFront();
            }
            else
            {
                mcCalendario.Visible = false;
                mcCalendario.SendToBack();
            }
        }

        private void mcCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            string diaSelecionado = mcCalendario.SelectionRange.ToString().Substring(23, 10);
            mskDataOcorrido.Text = diaSelecionado.Replace("/", "");
        }

        private void mcCalendario_Leave(object sender, EventArgs e)
        {
            mcCalendario.Visible = false;
            mcCalendario.SendToBack();
        }

        private void frmRegistrarOcorrencia_Click(object sender, EventArgs e)
        {
            if (btnAbrirCalendario.Focused == true || mcCalendario.Focused == true)
            {
                mcCalendario.Visible = false;
                mcCalendario.SendToBack();
            }
        }

        private void btnAbrirCalendario_Leave(object sender, EventArgs e)
        {
            if (mcCalendario.Focused == false)
            {
                mcCalendario.Visible = false;
                mcCalendario.SendToBack();
            }
        }

        public void LimparForm()
        {
            txtFazerOcorrencia.Clear();
            mskBeginOcorrido.Clear();
            mskDataOcorrido.Clear();
            mskDataRe.Clear();
            mskEndOcorrido.Clear();
            mskHoraRe.Clear();
            cboArea.SelectedIndex = -1;
            cboNivel.SelectedIndex = -1;
            cboFunc.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
        }
    }
}
