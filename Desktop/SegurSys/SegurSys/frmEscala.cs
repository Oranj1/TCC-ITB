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
    public partial class frmEscala : Form
    {
        public string id;

        clnFuncionario ObjClnFuncionario = new clnFuncionario();
        clnPesquisar ObjClnPesquisar = new clnPesquisar();
        frmMessageBoxAviso ObjMessageAviso = new frmMessageBoxAviso();
        clnUtil ObjUtil = new clnUtil();


        public frmEscala()
        {
            InitializeComponent();
        }

        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (Text == "Consultar")
            {
                if (txtId.Text != "")
                {
                    SqlDataReader ObjDrDados;
                    SqlDataReader ObjDrNome;
                    ObjDrNome = ObjClnPesquisar.LocalizarId(txtId.Text);
                    ObjDrDados = ObjClnPesquisar.AchaTurnoPorID(txtId.Text);
                    if (ObjDrDados.Read() && ObjDrNome.Read())
                    {
                        id = txtId.Text;
                        PreencherMasks();
                        btnAbreRonda.Enabled = true;
                    }
                    else if (ObjDrNome.Read())
                    {
                        id = txtId.Text;
                        lblUsuario.Text = "Escala De: " + ObjDrNome["nome"].ToString();
                        PreencherMasks();

                        ObjMessageAviso.pcbCaution.Visible = true;
                        ObjMessageAviso.lbl1.Text = "Esse funcionario não tem escala";
                        ObjMessageAviso.ShowDialog();
                    }
                    else
                    {
                        ObjMessageAviso.pcbCaution.Visible = true;
                        ObjMessageAviso.lbl1.Text = "Esse funcionario não existe";
                        ObjMessageAviso.ShowDialog();

                        txtId.Clear();
                    }
                }
                else
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "Digite um ID";
                    ObjMessageAviso.ShowDialog();
                }

            }
            else if (Text == "Alterar")
            {

                if (txtId.Text != "")
                {
                    SqlDataReader ObjDrDados;
                    SqlDataReader ObjDrNome;
                    ObjDrNome = ObjClnPesquisar.LocalizarId(txtId.Text);
                    ObjDrDados = ObjClnPesquisar.AchaTurnoPorID(txtId.Text);

                    if (ObjDrDados.Read() && ObjDrNome.Read())
                    {
                        lblUsuario.Text = "Escala De: " + ObjDrNome["nome"].ToString();
                        id = txtId.Text;
                        ckDia.Enabled = true;
                        cboDiaSemana.Enabled = true;
                        lblAviso.Visible = true;
                        ckDomingo.Visible = true;
                        ckSegunda.Visible = true;
                        ckTerca.Visible = true;
                        ckQuarta.Visible = true;
                        ckQuinta.Visible = true;
                        ckSexta.Visible = true;
                        ckSabado.Visible = true;
                        lblTitle.Visible = true;
                        PreencherMasks();

                        if (lblUsuario.Text == "")
                        {
                            btnAbreRonda.Enabled = false;
                        }
                        else
                        {
                            btnAbreRonda.Enabled = true;
                        }
                    }
                    else if (ObjDrNome.Read())
                    {
                        id = txtId.Text;
                        lblUsuario.Text = "Escala De: " + ObjDrNome["nome"].ToString();

                        ObjMessageAviso.pcbCaution.Visible = true;
                        ObjMessageAviso.lbl1.Text = "Esse funcionario não tem escala";
                        ObjMessageAviso.ShowDialog();

                        if (lblUsuario.Text == "")
                        {
                            btnAbreRonda.Enabled = false;
                            ckDia.Enabled = false;
                            cboDiaSemana.Enabled = false;
                        }
                        else
                        {
                            btnAbreRonda.Enabled = true;
                            ckDia.Enabled = true;
                            cboDiaSemana.Enabled = true;
                        }
                    }
                    else
                    {
                        ObjMessageAviso.pcbCaution.Visible = true;
                        ObjMessageAviso.lbl1.Text = "Esse funcionario não existe";
                        ObjMessageAviso.ShowDialog();

                        txtId.Clear();
                    }
                }
                else
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "Digite um ID";
                    ObjMessageAviso.ShowDialog();
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDiaSemana_TextChanged(object sender, EventArgs e)
        {
            PreencherMasks();
            if (lblUsuario.Text == "")
            {
                btnAbreRonda.Enabled = false;
            }
            else
            {
                btnAbreRonda.Enabled = true;
            }

        }

        public void PreencherMasks()
        {
            SqlDataReader ObjDrDados, ObjDrNome;
            ObjDrDados = ObjClnPesquisar.AchaDiaPorId(id, cboDiaSemana.Text);
            ObjDrNome = ObjClnPesquisar.LocalizarId(id);

            if (ObjDrDados.Read() && ObjDrNome.Read())
            {
                lblDia.Text = "";
                lblUsuario.Text = "Escala De: " + ObjDrNome["nome"].ToString();
                mskBegin.Text = ObjDrDados["horario_de_inicio"].ToString();
                mskEnd.Text = ObjDrDados["horario_de_termino"].ToString();
                mskIntervalBegin.Text = ObjDrDados["horario_intervalo"].ToString();
                mskIntervalEnd.Text = ObjDrDados["horario_termino_intervalo"].ToString();
            }
            else
            {
                lblDia.Text = "Esse usúario não tem escala para " + cboDiaSemana.Text;
                mskBegin.Clear();
                mskEnd.Clear();
                mskIntervalBegin.Clear();
                mskIntervalEnd.Clear();
            }
            CheckMarcada();
            CheckMarcadaConsultar();
        }

        public void frmEscala_Load(object sender, EventArgs e)
        {
            mskBegin.BringToFront();
            mskEnd.BringToFront();
            mskIntervalBegin.BringToFront();
            mskIntervalEnd.BringToFront();

            if (lblAidi.Visible == true)
            {
                cboDiaSemana.SelectedIndex = 0;
                lblDia.Text = "";
                lblUsuario.Text = "";

                if (txtId.Text != "")
                {
                    SqlDataReader ObjDrDados, ObjDrNome;
                    ObjDrDados = ObjClnPesquisar.AchaDiaPorId(txtId.Text, "Domingo");
                    ObjDrNome = ObjClnPesquisar.LocalizarId(id);

                    ckDomingo.Enabled = true;
                    ckSegunda.Enabled = true;
                    ckTerca.Enabled = true;
                    ckQuarta.Enabled = true;
                    ckQuinta.Enabled = true;
                    ckSexta.Enabled = true;
                    ckSabado.Enabled = true;

                    if (ObjDrDados.Read() && ObjDrNome.Read())
                    {
                        lblDia.Text = "";
                        lblUsuario.Text = "Escala De: " + ObjDrNome["nome"].ToString();
                        mskBegin.Text = ObjDrDados["horario_de_inicio"].ToString();
                        mskEnd.Text = ObjDrDados["horario_de_termino"].ToString();
                        mskIntervalBegin.Text = ObjDrDados["horario_intervalo"].ToString();
                        mskIntervalEnd.Text = ObjDrDados["horario_termino_intervalo"].ToString();
                    }
                    else if (ObjDrNome.Read())
                    {
                        lblUsuario.Text = "Escala De: " + ObjDrNome["nome"].ToString();
                    }
                    CheckMarcada();
                    CheckMarcadaConsultar();
                }
                if (mskBegin.Text != "" && Text != "Consultar")
                {
                    ckDia.Enabled = true;
                    mskBegin.Enabled = true;
                    mskEnd.Enabled = true;
                    mskIntervalBegin.Enabled = true;
                    mskIntervalEnd.Enabled = true;
                    lblAviso.Visible = true;
                    btnGravar.Visible = true;
                    ckDomingo.Visible = true;
                    ckSegunda.Visible = true;
                    ckTerca.Visible = true;
                    ckQuarta.Visible = true;
                    ckQuinta.Visible = true;
                    ckSexta.Visible = true;
                    ckSabado.Visible = true;
                    lblTitle.Visible = true;
                    cboBegin.Visible = true;
                    cboEnd.Visible = true;
                    cboInterval.Visible = true;
                    cboIntervalEnd.Visible = true;
                }

                if (Text == "Alterar")
                {
                    ckDia.Enabled = true;
                }
                else if (Text == "Alterar" && ckDia.Checked == true)
                {
                    ckDomingo.Visible = true;
                    ckSegunda.Visible = true;
                    ckTerca.Visible = true;
                    ckQuarta.Visible = true;
                    ckQuinta.Visible = true;
                    ckSexta.Visible = true;
                    ckSabado.Visible = true;
                    lblTitle.Visible = true;
                    cboBegin.Visible = true;
                    cboEnd.Visible = true;
                    cboInterval.Visible = true;
                    cboIntervalEnd.Visible = true;
                }

                if (btnPesquisar.Visible == false)
                {
                    PreencherMasks();
                    btnPesquisar.PerformClick();
                }

                PreencherMasks();
            }

            if (btnPesquisar.Visible == true)
            {
                ckDia.Enabled = false;
            }

            if (lblUsuario.Text == "")
            {
                btnAbreRonda.Enabled = false;
            }
            else
            {
                btnAbreRonda.Enabled = true;
            }
        }

        private void cboDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void CheckMarcada()
        {
            if (Text == "Alterar")
            {
                if (mskBegin.Text != "")
                {
                    ckDia.Checked = true;
                    ckDia.Enabled = true;
                }
                else
                {
                    ckDia.Checked = false;
                }
            }
        }
        public void CheckMarcadaConsultar()
        {
            if (Text == "Consultar")
            {
                if (mskBegin.Text != "")
                {
                    ckDia.Checked = true;
                }
                else
                {
                    ckDia.Checked = false;
                }
            }
        }

        private void ckDia_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDia.Checked && Text == "Alterar")
            {
                mskBegin.Enabled = true;
                mskEnd.Enabled = true;
                mskIntervalBegin.Enabled = true;
                mskIntervalEnd.Enabled = true;
                btnGravar.Visible = true;
                ckDomingo.Enabled = true;
                ckSegunda.Enabled = true;
                ckTerca.Enabled = true;
                ckQuarta.Enabled = true;
                ckQuinta.Enabled = true;
                ckSexta.Enabled = true;
                ckSabado.Enabled = true;
                ckDomingo.Visible = true;
                ckSegunda.Visible = true;
                ckTerca.Visible = true;
                ckQuarta.Visible = true;
                ckQuinta.Visible = true;
                ckSexta.Visible = true;
                ckSabado.Visible = true;
                lblTitle.Visible = true;
                cboBegin.Visible = true;
                cboEnd.Visible = true;
                cboInterval.Visible = true;
                cboIntervalEnd.Visible = true;
            }
            else if (Text == "Alterar")
            {
                mskBegin.Enabled = false;
                mskEnd.Enabled = false;
                mskIntervalBegin.Enabled = false;
                mskIntervalEnd.Enabled = false;
                mskBegin.Clear();
                mskEnd.Clear();
                mskIntervalBegin.Clear();
                mskIntervalEnd.Clear();
                ckDomingo.Enabled = false;
                ckSegunda.Enabled = false;
                ckTerca.Enabled = false;
                ckQuarta.Enabled = false;
                ckQuinta.Enabled = false;
                ckSexta.Enabled = false;
                ckSabado.Enabled = false;
                cboBegin.Visible = false;
                cboEnd.Visible = false;
                cboInterval.Visible = false;
                cboIntervalEnd.Visible = false;
                LImparCks();
            }
            else
            {
                mskBegin.Enabled = false;
                mskEnd.Enabled = false;
                mskIntervalBegin.Enabled = false;
                mskIntervalEnd.Enabled = false;
                cboBegin.Visible = false;
                cboEnd.Visible = false;
                cboInterval.Visible = false;
                cboIntervalEnd.Visible = false;
            }
        }

        private void cboDiaSemana_Click(object sender, EventArgs e)
        {
        }

        private void cboDiaSemana_DropDown(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (ckDia.Checked)
            {
                if (clnUtil.ValidarHora(mskBegin.Text) == false || clnUtil.ValidarHora(mskEnd.Text) == false || clnUtil.ValidarHora(mskIntervalBegin.Text) == false || clnUtil.ValidarHora(mskIntervalEnd.Text) == false)
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "Horário Inválido";
                    ObjMessageAviso.ShowDialog();
                }
                else if (Text == "Alterar")
                {
                    if (ckDia.Checked)
                    {
                        ObjClnFuncionario.IniTurno = mskBegin.Text.Substring(0, 2) + ":" + mskBegin.Text.Substring(2);
                        ObjClnFuncionario.IniInterval = mskIntervalBegin.Text.Substring(0, 2) + ":" + mskIntervalBegin.Text.Substring(2);
                        ObjClnFuncionario.FimInterval = mskIntervalEnd.Text.Substring(0, 2) + ":" + mskIntervalEnd.Text.Substring(2);
                        ObjClnFuncionario.FimTurno = mskEnd.Text.Substring(0, 2) + ":" + mskEnd.Text.Substring(2);
                        ObjClnFuncionario.DiaSemana = cboDiaSemana.Text;
                        ObjClnFuncionario.Id = id;

                        SqlDataReader Verificador;
                        Verificador = ObjClnPesquisar.PesquisaDia(id, cboDiaSemana.Text);

                        if (Verificador.Read())
                        {

                            ObjClnFuncionario.AlterarEscala();
                            AlterarComCk();
                            lblDia.Text = "";

                            ObjMessageAviso.pcbCaution.Visible = false;
                            ObjMessageAviso.lbl1.Text = "Turno de " + cboDiaSemana.Text + " alterado com sucesso";
                            ObjMessageAviso.ShowDialog();
                            LImparCks();
                        }
                        else
                        {
                            ObjClnFuncionario.EscalarTurno();
                            ObjClnFuncionario.FazerLigacaoTurnoFunc();
                            AlterarComCk();
                            lblDia.Text = "";

                            ObjMessageAviso.pcbCaution.Visible = false;
                            ObjMessageAviso.lbl1.Text = "Turno de " + cboDiaSemana.Text + " escalado com sucesso";
                            ObjMessageAviso.ShowDialog();
                            LImparCks();
                        }
                    }
                }
            }
            else
            {
                ObjClnFuncionario.Id = id;
                ObjClnFuncionario.DiaSemana = cboDiaSemana.Text;
                ObjClnFuncionario.NaoTrabalha();
                lblDia.Text = "Esse usúario não tem escala para " + cboDiaSemana.Text;

                ObjMessageAviso.pcbCaution.Visible = false;
                ObjMessageAviso.lbl1.Text = "Turno de " + cboDiaSemana.Text + " para o id  " + id + " removido";
                ObjMessageAviso.ShowDialog();

            }
        }

        public void LImparCks()
        {
            ckDomingo.Checked = false;
            ckSegunda.Checked = false;
            ckTerca.Checked = false;
            ckQuarta.Checked = false;
            ckQuinta.Checked = false;
            ckSexta.Checked = false;
            ckSabado.Checked = false;
        }

        public void AlterarComCk()
        {
            ObjClnFuncionario.IniTurno = mskBegin.Text.Substring(0, 2) + ":" + mskBegin.Text.Substring(2);
            ObjClnFuncionario.IniInterval = mskIntervalBegin.Text.Substring(0, 2) + ":" + mskIntervalBegin.Text.Substring(2);
            ObjClnFuncionario.FimInterval = mskIntervalEnd.Text.Substring(0, 2) + ":" + mskIntervalEnd.Text.Substring(2);
            ObjClnFuncionario.FimTurno = mskEnd.Text.Substring(0, 2) + ":" + mskEnd.Text.Substring(2);
            ObjClnFuncionario.DiaSemana = cboDiaSemana.Text;
            ObjClnFuncionario.Id = id;

            if (ckDomingo.Checked == true)
            {
                ObjClnFuncionario.IniTurno = mskBegin.Text.Substring(0, 2) + ":" + mskBegin.Text.Substring(2);
                ObjClnFuncionario.IniInterval = mskIntervalBegin.Text.Substring(0, 2) + ":" + mskIntervalBegin.Text.Substring(2);
                ObjClnFuncionario.FimInterval = mskIntervalEnd.Text.Substring(0, 2) + ":" + mskIntervalEnd.Text.Substring(2);
                ObjClnFuncionario.FimTurno = mskEnd.Text.Substring(0, 2) + ":" + mskEnd.Text.Substring(2);
                ObjClnFuncionario.DiaSemana = "Domingo";
                ObjClnFuncionario.Id = id;

                SqlDataReader Verificador;
                Verificador = ObjClnPesquisar.PesquisaDia(id, "Domingo");

                if (Verificador.Read())
                {
                    ObjClnFuncionario.AlterarEscala();
                }
                else
                {
                    ObjClnFuncionario.EscalarTurno();
                    ObjClnFuncionario.FazerLigacaoTurnoFunc();
                }
            }

            if (ckSegunda.Checked == true)
            {
                ObjClnFuncionario.IniTurno = mskBegin.Text.Substring(0, 2) + ":" + mskBegin.Text.Substring(2);
                ObjClnFuncionario.IniInterval = mskIntervalBegin.Text.Substring(0, 2) + ":" + mskIntervalBegin.Text.Substring(2);
                ObjClnFuncionario.FimInterval = mskIntervalEnd.Text.Substring(0, 2) + ":" + mskIntervalEnd.Text.Substring(2);
                ObjClnFuncionario.FimTurno = mskEnd.Text.Substring(0, 2) + ":" + mskEnd.Text.Substring(2);
                ObjClnFuncionario.DiaSemana = "Segunda";
                ObjClnFuncionario.Id = id;

                SqlDataReader Verificador;
                Verificador = ObjClnPesquisar.PesquisaDia(id, "Segunda");

                if (Verificador.Read())
                {
                    ObjClnFuncionario.AlterarEscala();
                }
                else
                {
                    ObjClnFuncionario.EscalarTurno();
                    ObjClnFuncionario.FazerLigacaoTurnoFunc();
                }
            }

            if (ckTerca.Checked == true)
            {
                ObjClnFuncionario.IniTurno = mskBegin.Text.Substring(0, 2) + ":" + mskBegin.Text.Substring(2);
                ObjClnFuncionario.IniInterval = mskIntervalBegin.Text.Substring(0, 2) + ":" + mskIntervalBegin.Text.Substring(2);
                ObjClnFuncionario.FimInterval = mskIntervalEnd.Text.Substring(0, 2) + ":" + mskIntervalEnd.Text.Substring(2);
                ObjClnFuncionario.FimTurno = mskEnd.Text.Substring(0, 2) + ":" + mskEnd.Text.Substring(2);
                ObjClnFuncionario.DiaSemana = "Terça";
                ObjClnFuncionario.Id = id;

                SqlDataReader Verificador;
                Verificador = ObjClnPesquisar.PesquisaDia(id, "Terça");

                if (Verificador.Read())
                {
                    ObjClnFuncionario.AlterarEscala();
                }
                else
                {
                    ObjClnFuncionario.EscalarTurno();
                    ObjClnFuncionario.FazerLigacaoTurnoFunc();
                }
            }

            if (ckQuarta.Checked == true)
            {
                ObjClnFuncionario.IniTurno = mskBegin.Text.Substring(0, 2) + ":" + mskBegin.Text.Substring(2);
                ObjClnFuncionario.IniInterval = mskIntervalBegin.Text.Substring(0, 2) + ":" + mskIntervalBegin.Text.Substring(2);
                ObjClnFuncionario.FimInterval = mskIntervalEnd.Text.Substring(0, 2) + ":" + mskIntervalEnd.Text.Substring(2);
                ObjClnFuncionario.FimTurno = mskEnd.Text.Substring(0, 2) + ":" + mskEnd.Text.Substring(2);
                ObjClnFuncionario.DiaSemana = "Quarta";
                ObjClnFuncionario.Id = id;

                SqlDataReader Verificador;
                Verificador = ObjClnPesquisar.PesquisaDia(id, "Quarta");

                if (Verificador.Read())
                {
                    ObjClnFuncionario.AlterarEscala();
                }
                else
                {
                    ObjClnFuncionario.EscalarTurno();
                    ObjClnFuncionario.FazerLigacaoTurnoFunc();
                }
            }

            if (ckQuinta.Checked == true)
            {
                ObjClnFuncionario.IniTurno = mskBegin.Text.Substring(0, 2) + ":" + mskBegin.Text.Substring(2);
                ObjClnFuncionario.IniInterval = mskIntervalBegin.Text.Substring(0, 2) + ":" + mskIntervalBegin.Text.Substring(2);
                ObjClnFuncionario.FimInterval = mskIntervalEnd.Text.Substring(0, 2) + ":" + mskIntervalEnd.Text.Substring(2);
                ObjClnFuncionario.FimTurno = mskEnd.Text.Substring(0, 2) + ":" + mskEnd.Text.Substring(2);
                ObjClnFuncionario.DiaSemana = "Quinta";
                ObjClnFuncionario.Id = id;

                SqlDataReader Verificador;
                Verificador = ObjClnPesquisar.PesquisaDia(id, "Quinta");

                if (Verificador.Read())
                {
                    ObjClnFuncionario.AlterarEscala();
                }
                else
                {
                    ObjClnFuncionario.EscalarTurno();
                    ObjClnFuncionario.FazerLigacaoTurnoFunc();
                }
            }

            if (ckSexta.Checked == true)
            {
                ObjClnFuncionario.IniTurno = mskBegin.Text.Substring(0, 2) + ":" + mskBegin.Text.Substring(2);
                ObjClnFuncionario.IniInterval = mskIntervalBegin.Text.Substring(0, 2) + ":" + mskIntervalBegin.Text.Substring(2);
                ObjClnFuncionario.FimInterval = mskIntervalEnd.Text.Substring(0, 2) + ":" + mskIntervalEnd.Text.Substring(2);
                ObjClnFuncionario.FimTurno = mskEnd.Text.Substring(0, 2) + ":" + mskEnd.Text.Substring(2);
                ObjClnFuncionario.DiaSemana = "Sexta";
                ObjClnFuncionario.Id = id;

                SqlDataReader Verificador;
                Verificador = ObjClnPesquisar.PesquisaDia(id, "Sexta");

                if (Verificador.Read())
                {
                    ObjClnFuncionario.AlterarEscala();
                }
                else
                {
                    ObjClnFuncionario.EscalarTurno();
                    ObjClnFuncionario.FazerLigacaoTurnoFunc();
                }
            }

            if (ckSabado.Checked == true)
            {
                ObjClnFuncionario.IniTurno = mskBegin.Text.Substring(0, 2) + ":" + mskBegin.Text.Substring(2);
                ObjClnFuncionario.IniInterval = mskIntervalBegin.Text.Substring(0, 2) + ":" + mskIntervalBegin.Text.Substring(2);
                ObjClnFuncionario.FimInterval = mskIntervalEnd.Text.Substring(0, 2) + ":" + mskIntervalEnd.Text.Substring(2);
                ObjClnFuncionario.FimTurno = mskEnd.Text.Substring(0, 2) + ":" + mskEnd.Text.Substring(2);
                ObjClnFuncionario.DiaSemana = "Sábado";
                ObjClnFuncionario.Id = id;

                SqlDataReader Verificador;
                Verificador = ObjClnPesquisar.PesquisaDia(id, "Sábado");

                if (Verificador.Read())
                {
                    ObjClnFuncionario.AlterarEscala();
                }
                else
                {
                    ObjClnFuncionario.EscalarTurno();
                    ObjClnFuncionario.FazerLigacaoTurnoFunc();
                }
            }
        }

        private void mskBegin_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskIntervalBegin_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskIntervalEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskBegin_TextChanged_1(object sender, EventArgs e)
        {
            if (mskBegin.Text != "")
            {
                if (clnUtil.ValidarHora(mskBegin.Text) == false)
                {
                    epInicio.SetError(cboBegin, "O horário é inválido");
                }
                else
                {
                    epInicio.Clear();
                }
            }
        }

        private void mskEnd_TextChanged_1(object sender, EventArgs e)
        {
            if (mskEnd.Text != "")
            {
                if (clnUtil.ValidarHora(mskEnd.Text) == false)
                {
                    epFim.SetError(cboEnd, "O horário é inválido");
                }
                else
                {
                    epFim.Clear();
                }
            }
        }

        private void mskIntervalBegin_TextChanged_1(object sender, EventArgs e)
        {
            if (mskIntervalBegin.Text != "")
            {
                if (clnUtil.ValidarHora(mskIntervalBegin.Text) == false)
                {
                    epIntevalo.SetError(cboInterval, "O horário é inválido");
                }
                else
                {
                    epIntevalo.Clear();
                }
            }
        }

        private void mskIntervalEnd_TextChanged_1(object sender, EventArgs e)
        {
            if (mskIntervalEnd.Text != "")
            {
                if (clnUtil.ValidarHora(mskIntervalEnd.Text) == false)
                {
                    epIntervaloFim.SetError(cboIntervalEnd, "O horário é inválido");
                }
                else
                {
                    epIntervaloFim.Clear();
                }
            }
        }

        public void btnAbreRonda_Click(object sender, EventArgs e)
        {
            frmRotas ObjFrmRotas = new frmRotas();
            ObjFrmRotas.btnPesquisar.Visible = false;
            ObjFrmRotas.txtAchaIDRonda.Enabled = false;

            if (Text == "Consultar")
            {
                ObjFrmRotas.Text = "Consultar";
                ObjFrmRotas.cboDiaSemana.Text = cboDiaSemana.Text;
                ObjFrmRotas.id = id;
                ObjFrmRotas.txtAchaIDRonda.Text = id;
                ObjFrmRotas.btnPesquisar.Visible = false;
                ObjFrmRotas.ckDia.Enabled = false;
                ObjFrmRotas.btnSalvar.Visible = false;
                ObjFrmRotas.cboTime.Visible = false;
                ObjFrmRotas.ShowDialog();
            }
            else
            {
                ObjFrmRotas.Text = "Rondas";
                ObjFrmRotas.cboDiaSemana.Text = cboDiaSemana.Text;
                ObjFrmRotas.id = id;
                ObjFrmRotas.txtAchaIDRonda.Text = id;
                ObjFrmRotas.btnPesquisar.Visible = false;
                ObjFrmRotas.lbl.Visible = true;
                ObjFrmRotas.ShowDialog();
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ObjUtil.ApenasNumeros(sender, e);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskBegin.Text = cboBegin.Text.Replace(":", "");
        }

        private void cboEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskEnd.Text = cboEnd.Text.Replace(":", "");
        }

        private void cboInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskIntervalBegin.Text = cboInterval.Text.Replace(":", "");
        }

        private void cboIntervalEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskIntervalEnd.Text = cboIntervalEnd.Text.Replace(":", "");
        }
    }
}
