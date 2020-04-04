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
    public partial class frmRotas : Form
    {
        clnUtil ObjUtil = new clnUtil();
        clnRonda ObjClnRonda = new clnRonda();

        int i = 0, c = 0, t = 1;

        string mostrarCaminho = "", caminho = "";

        public string id;
        public static bool verificador = false;

        frmEscala ObjFrmEscala = new frmEscala();

        public frmRotas()
        {
            InitializeComponent();
        }

        clnPesquisar ObjClnPesquisar = new clnPesquisar();
        frmMessageBoxAviso ObjMessageAviso = new frmMessageBoxAviso();

        private void btnMais_Click(object sender, EventArgs e)
        {
            //Errei feio, errei rude;
        }

        private void frmRotas_Load(object sender, EventArgs e)
        {
            cboTime.SelectedIndex = 1;
            lblAviso.Text = "";
            lblTitulo.Text = "";

            CarregarRotas();

            if (btnPesquisar.Visible == true)
            {
                cboDiaSemana.SelectedIndex = 0;
                ckDia.Enabled = false;
                btnMais.Enabled = false;
            }

            if (Text == "Consultar")
            {
                btnMais.Visible = false;
                btnMenos.Visible = false;
                ckDia.Visible = false;
                lbl.Visible = false;
                lbl0.Visible = false;
                lbl0_5.Visible = false;
                cbo1.Visible = false;
                cbo2.Visible = false;

                DeixarInvisivelAplicacoes();
            }

            PrencherComboRonda();

            grp.Text = "Rota de " + cboDiaSemana.Text;
            this.Size = new Size(this.Size.Width - 393, this.Size.Height + 0);
        }

        private void DeixarInvisivelAplicacoes()
        {
            grpAplicar.Visible = false;
            ckDomingo.Visible = false;
            ckSegunda.Visible = false;
            ckTerca.Visible = false;
            ckQuarta.Visible = false;
            ckQuinta.Visible = false;
            ckSexta.Visible = false;
            ckSabado.Visible = false;
        }

        public void PrencherComboRonda()
        {
            cbo1.DataSource = ObjClnPesquisar.PreencherComboRonda();
            cbo1.ValueMember = "ponto";
            cbo1.SelectedIndex = -1;
            cbo2.DataSource = ObjClnPesquisar.PreencherComboRonda();
            cbo2.ValueMember = "ponto";
            cbo2.SelectedIndex = -1;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnMais_Click_1(object sender, EventArgs e)
        {
            t = 0;
            ckDia.Enabled = true;

            if (mostrarCaminho != "")
            {
                ++c;
            }

            if (i == 0)
            {
                this.Size = new Size(this.Size.Width + 393, this.Size.Height + 0);
                btnBack.Visible = false;
                ++i;
            }
            if (c == 0)
            {
                if (cbo1.SelectedIndex != -1 && cbo2.SelectedIndex == -1)
                {
                    mostrarCaminho += cbo1.Text;
                    caminho += cbo1.Text + "_";
                    ++c;
                }
                else if (cbo2.SelectedIndex != -1 && cbo1.SelectedIndex == -1)
                {
                    mostrarCaminho += cbo2.Text;
                    caminho += cbo2.Text + "_";
                    ++c;
                }
                else if (cbo1.SelectedIndex != -1 && cbo2.SelectedIndex != -1)
                {
                    mostrarCaminho += cbo1.Text + " ------ " + cbo2.Text;
                    caminho += cbo1.Text + "_" + cbo2.Text;
                    ++c;
                }
            }
            else
            {
                if (cbo1.SelectedIndex != -1 && cbo2.SelectedIndex != -1)
                {
                    mostrarCaminho += " ------ " + cbo1.Text + " ------ " + cbo2.Text;
                    caminho += "_" + cbo1.Text + "_" + cbo2.Text;
                }
                else if (cbo1.SelectedIndex != -1 && cbo2.SelectedIndex == -1)
                {
                    mostrarCaminho += " ------ " + cbo1.Text;
                    caminho += "_" + cbo1.Text;

                }
                else if (cbo2.SelectedIndex != -1 && cbo1.SelectedIndex == -1)
                {
                    mostrarCaminho += " ------ " + cbo2.Text;
                    caminho += "_" + cbo2.Text;
                }
            }

            cbo1.SelectedIndex = -1;
            cbo2.SelectedIndex = -1;
            txtCaminho.Text = mostrarCaminho;
        }
        //public void AddNewComboBox()
        //{
        //    //Adiciona o tamanho do firm
        //    width = this.Width;

        //    //Define posição top
        //    var top = contador * 25;

        //    //Verifica se irá ultrapassar o form
        //    if (top >= width)
        //    {
        //        MessageBox.Show("Seu Form não tem tamanho para adicionar esse item");
        //        return;
        //    }

        //    //Novo textBox watts
        //    ComboBox cbo = new ComboBox();
        //    cbo.Top = top;
        //    cbo.Left = 10;
        //    cbo.Text = "Watts  " + this.contador.ToString();
        //    cbo.Name = "watts" + contador;
        //    //Adiciona no Form
        //    this.Controls.Add(cbo);

        //    ++contador;
        //}

        private void btnMais2_Click(object sender, EventArgs e)
        {

        }

        private void btnMais3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GravarNoBanco();

            if (ckSegunda.Checked == true)
            {
                GravarNoBancoSegunda();
            }
            if (ckTerca.Checked == true)
            {
                GravarNoBancoTerca();
            }
            if (ckQuarta.Checked == true)
            {
                GravarNoBancoQuarta();
            }
            if (ckQuinta.Checked == true)
            {
                GravarNoBancoQuinta();
            }
            if (ckSexta.Checked == true)
            {
                GravarNoBancoSexta();
            }
            if (ckSabado.Checked == true)
            {
                GravarNoBancoSabado();
            }
            if (ckDomingo.Checked == true)
            {
                GravarNoBancoDomingo();
            }
        }

        public void GravarNoBancoSegunda()
        {
            SqlDataReader ObjDrEscala;
            ObjDrEscala = ObjClnPesquisar.PesquisaDia(id, "Segunda");
            if (ObjDrEscala.Read())
            {
                ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                string escala = ObjDrEscala["id_Escala"].ToString();
                SqlDataReader ObjDrRonda;
                ObjDrRonda = ObjClnPesquisar.AchaRonda(escala);

                if (ObjDrRonda.Read())
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.AlterarRonda();

                }
                else
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.NovaRonda();
                }
            }
            else
            {
                frmMessageBoxAviso ObjFrmMessageBoxAviso = new frmMessageBoxAviso();
                ObjFrmMessageBoxAviso.pcbCaution.Visible = true;
                ObjFrmMessageBoxAviso.lbl1.Text = "Não foi possível aplicar também para \n segunda pois o funcionario não tem \n escala para o mesmo";
                ObjFrmMessageBoxAviso.ShowDialog();
            }
        }
        public void GravarNoBancoTerca()
        {
            SqlDataReader ObjDrEscala;
            ObjDrEscala = ObjClnPesquisar.PesquisaDia(id, "Terça");
            if (ObjDrEscala.Read())
            {
                ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                string escala = ObjDrEscala["id_Escala"].ToString();
                SqlDataReader ObjDrRonda;
                ObjDrRonda = ObjClnPesquisar.AchaRonda(escala);

                if (ObjDrRonda.Read())
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.AlterarRonda();

                }
                else
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.NovaRonda();
                }
            }
            else
            {
                frmMessageBoxAviso ObjFrmMessageBoxAviso = new frmMessageBoxAviso();
                ObjFrmMessageBoxAviso.pcbCaution.Visible = true;
                ObjFrmMessageBoxAviso.lbl1.Text = "Não foi possível aplicar também para \n terça pois o funcionario não tem \n escala para o mesmo";
                ObjFrmMessageBoxAviso.ShowDialog();
            }
        }
        public void GravarNoBancoQuarta()
        {
            SqlDataReader ObjDrEscala;
            ObjDrEscala = ObjClnPesquisar.PesquisaDia(id, "Quarta");
            if (ObjDrEscala.Read())
            {
                ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                string escala = ObjDrEscala["id_Escala"].ToString();
                SqlDataReader ObjDrRonda;
                ObjDrRonda = ObjClnPesquisar.AchaRonda(escala);

                if (ObjDrRonda.Read())
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.AlterarRonda();

                }
                else
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.NovaRonda();
                }
            }
            else
            {
                frmMessageBoxAviso ObjFrmMessageBoxAviso = new frmMessageBoxAviso();
                ObjFrmMessageBoxAviso.pcbCaution.Visible = true;
                ObjFrmMessageBoxAviso.lbl1.Text = "Não foi possível aplicar também para \n quarta pois o funcionario não tem \n escala para o mesmo";
                ObjFrmMessageBoxAviso.ShowDialog();
            }
        }
        public void GravarNoBancoQuinta()
        {
            SqlDataReader ObjDrEscala;
            ObjDrEscala = ObjClnPesquisar.PesquisaDia(id, "Quinta");
            if (ObjDrEscala.Read())
            {
                ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                string escala = ObjDrEscala["id_Escala"].ToString();
                SqlDataReader ObjDrRonda;
                ObjDrRonda = ObjClnPesquisar.AchaRonda(escala);

                if (ObjDrRonda.Read())
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.AlterarRonda();

                }
                else
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.NovaRonda();
                }
            }
            else
            {
                frmMessageBoxAviso ObjFrmMessageBoxAviso = new frmMessageBoxAviso();
                ObjFrmMessageBoxAviso.pcbCaution.Visible = true;
                ObjFrmMessageBoxAviso.lbl1.Text = "Não foi possível aplicar também para \n quinta pois o funcionario não tem \n escala para o mesmo";
                ObjFrmMessageBoxAviso.ShowDialog();
            }
        }
        public void GravarNoBancoSexta()
        {
            SqlDataReader ObjDrEscala;
            ObjDrEscala = ObjClnPesquisar.PesquisaDia(id, "Sexta");
            if (ObjDrEscala.Read())
            {
                ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                string escala = ObjDrEscala["id_Escala"].ToString();
                SqlDataReader ObjDrRonda;
                ObjDrRonda = ObjClnPesquisar.AchaRonda(escala);

                if (ObjDrRonda.Read())
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.AlterarRonda();

                }
                else
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.NovaRonda();
                }
            }
            else
            {
                frmMessageBoxAviso ObjFrmMessageBoxAviso = new frmMessageBoxAviso();
                ObjFrmMessageBoxAviso.pcbCaution.Visible = true;
                ObjFrmMessageBoxAviso.lbl1.Text = "Não foi possível aplicar também para \n sexta pois o funcionario não tem \n escala para o mesmo";
                ObjFrmMessageBoxAviso.ShowDialog();
            }
        }
        public void GravarNoBancoSabado()
        {
            SqlDataReader ObjDrEscala;
            ObjDrEscala = ObjClnPesquisar.PesquisaDia(id, "Sábado");
            if (ObjDrEscala.Read())
            {
                ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                string escala = ObjDrEscala["id_Escala"].ToString();
                SqlDataReader ObjDrRonda;
                ObjDrRonda = ObjClnPesquisar.AchaRonda(escala);

                if (ObjDrRonda.Read())
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.AlterarRonda();

                }
                else
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.NovaRonda();
                }
            }
            else
            {
                frmMessageBoxAviso ObjFrmMessageBoxAviso = new frmMessageBoxAviso();
                ObjFrmMessageBoxAviso.pcbCaution.Visible = true;
                ObjFrmMessageBoxAviso.lbl1.Text = "Não foi possível aplicar também para \n sábado pois o funcionario não tem \n escala para o mesmo";
                ObjFrmMessageBoxAviso.ShowDialog();
            }
        }

        public void GravarNoBancoDomingo()
        {
            SqlDataReader ObjDrEscala;
            ObjDrEscala = ObjClnPesquisar.PesquisaDia(id, "Domingo");
            if (ObjDrEscala.Read())
            {
                ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                string escala = ObjDrEscala["id_Escala"].ToString();
                SqlDataReader ObjDrRonda;
                ObjDrRonda = ObjClnPesquisar.AchaRonda(escala);

                if (ObjDrRonda.Read())
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.AlterarRonda();

                }
                else
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.NovaRonda();
                }
            }
            else
            {
                frmMessageBoxAviso ObjFrmMessageBoxAviso = new frmMessageBoxAviso();
                ObjFrmMessageBoxAviso.pcbCaution.Visible = true;
                ObjFrmMessageBoxAviso.lbl1.Text = "Não foi possível aplicar também para \n domingo pois o funcionario não tem \n escala para o mesmo";
                ObjFrmMessageBoxAviso.ShowDialog();
            }
        }

        public void GravarNoBanco()
        {
            SqlDataReader ObjDrEscala;
            ObjDrEscala = ObjClnPesquisar.PesquisaDia(id, cboDiaSemana.Text);
            if (ObjDrEscala.Read())
            {
                ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                string escala = ObjDrEscala["id_Escala"].ToString();
                SqlDataReader ObjDrRonda;
                ObjDrRonda = ObjClnPesquisar.AchaRonda(escala);

                if (ckDia.Checked == false)
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = "";
                    ObjClnRonda.Tempo = "";
                    ObjClnRonda.AlterarRonda();

                    ObjMessageAviso.pcbCaution.Visible = false;
                    ObjMessageAviso.lbl1.Text = "Rota excluida com sucesso";
                    ObjMessageAviso.ShowDialog();
                    

                }
                else if (ObjDrRonda.Read())
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.AlterarRonda();

                    ObjMessageAviso.pcbCaution.Visible = false;
                    ObjMessageAviso.lbl1.Text = "Rota alterada com sucesso";
                    ObjMessageAviso.ShowDialog();
                    lblAviso.Text = "";
                }
                else
                {
                    ObjClnRonda.Escala = ObjDrEscala["id_Escala"].ToString();
                    ObjClnRonda.Caminho = caminho;
                    ObjClnRonda.Escala = escala;
                    ObjClnRonda.Tempo = mskTime.Text;
                    ObjClnRonda.NovaRonda();

                    ObjMessageAviso.pcbCaution.Visible = false;
                    ObjMessageAviso.lbl1.Text = "Rota definida com sucesso";
                    ObjMessageAviso.ShowDialog();
                    lblAviso.Text = "";
                }
            }
            else
            {
                frmMessageDialog ObjMessageDialog = new frmMessageDialog();
                ObjMessageDialog.pcbQuestion.Visible = true;
                ObjMessageDialog.lbl1.Text = "Esse funcionário não pode ter uma \n ronda para " + cboDiaSemana.Text + ", pois não tem \n escala para o mesmo. \n\n Gostaria de escalá-lo ?";
                ObjMessageDialog.ShowDialog();

                if (verificador == true && btnPesquisar.Visible == false)
                {
                    verificador = false;
                    ObjFrmEscala.cboDiaSemana.Text = cboDiaSemana.Text;
                    this.Hide();
                }
                else if (verificador == true)
                {
                    verificador = false;
                    ObjFrmEscala.id = id;
                    ObjFrmEscala.txtId.Text = id;
                    ObjFrmEscala.txtId.Enabled = false;
                    ObjFrmEscala.btnPesquisar.Visible = false;
                    ObjFrmEscala.btnAbreRonda.Visible = false;
                    ObjFrmEscala.Text = "Alterar";
                    ObjFrmEscala.ShowDialog();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMais4_Click(object sender, EventArgs e)
        {

        }

        private void btnMais5_Click(object sender, EventArgs e)
        {

        }

        private void btnMais6_Click(object sender, EventArgs e)
        {

        }

        private void btnMais7_Click(object sender, EventArgs e)
        {

        }

        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "";
            id = txtAchaIDRonda.Text;

            CarregarRotasBtnPesquisar();

            if (lblTitulo.Text == "")
            {
                cboDiaSemana.Enabled = false;
                cbo1.Enabled = false;
                cbo2.Enabled = false;
                btnMais.Enabled = false;
                ResetarForm();

                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "Esse Funcionario não existe";
                ObjMessageAviso.ShowDialog();

                ckDia.Checked = false;
                ckDia.Enabled = false;
            }

            else if (Text == "Rondas")
            {
                cbo1.Enabled = true;
                cbo2.Enabled = true;
                cboDiaSemana.Enabled = true;
                btnMais.Enabled = true;
                ckDia.Enabled = true;
            }
        }

        public void cboDiaSemana_TextChanged(object sender, EventArgs e)
        {
            grp.Text = "Rota de " + cboDiaSemana.Text;

            if (lblAviso.Visible == true && t == 0)
            {
                ResetarForm();
            }

            CarregarRotas();
        }

        public void CarregarRotas()
        {
            frmEscala ObjFrmlEscala = new frmEscala();
            SqlDataReader ObjDrDados, ObjDrNome, ObjDrExiste, ObjDrCaminho;
            ObjDrExiste = ObjClnPesquisar.AchaEscala(id);
            ObjDrNome = ObjClnPesquisar.LocalizarId(id);
            ObjDrDados = ObjClnPesquisar.PesquisaDia(id, cboDiaSemana.Text);

            if (ObjDrExiste.Read())
            {
                if (ObjDrNome.Read())
                {
                    string nome = ObjDrNome["nome"].ToString();
                    lblTitulo.Text = "Rota de: " + nome;

                    if (ObjDrDados.Read())
                    {
                        string escala = ObjDrDados["id_Escala"].ToString();

                        ObjDrCaminho = ObjClnPesquisar.AchaRonda(escala);

                        if (ObjDrCaminho.Read())
                        {
                            mostrarCaminho = ObjDrCaminho["rota"].ToString();
                            mostrarCaminho = mostrarCaminho.Replace("_", " ------ ");
                            txtCaminho.Text = mostrarCaminho;
                            mskTime.Text = ObjDrCaminho["tempo"].ToString().Replace(":","");
                            caminho = ObjDrCaminho["rota"].ToString();
                            lblAviso.Visible = false;

                            if (txtCaminho.Text != "")
                            {
                                c = 0;
                            }

                        }
                        else
                        {
                            ResetarForm();
                            lblAviso.Text = "Esse Funcionário não tem ronda para " + cboDiaSemana.Text;
                            lblAviso.Visible = true;
                        }

                    }
                    else
                    {
                        lblAviso.Text = "Esse Funcionário não tem Ronda para " + cboDiaSemana.Text;
                        LimparFormTodo();
                    }
                }
            }
            Check();
        }
        public void CarregarRotasBtnPesquisar()
        {
            frmEscala ObjFrmlEscala = new frmEscala();
            SqlDataReader ObjDrDados, ObjDrExiste, ObjDrEscala, ObjDrCaminho;
            ObjDrEscala = ObjClnPesquisar.AchaEscala(id);
            ObjDrExiste = ObjClnPesquisar.LocalizarId(id);
            ObjDrDados = ObjClnPesquisar.PesquisaDia(id, cboDiaSemana.Text);

            if (ObjDrExiste.Read())
            {
                LimparPesquisa();
                string nome = ObjDrExiste["nome"].ToString();
                lblTitulo.Text = "Rota de: " + nome;

                if (ObjDrDados.Read())
                {
                    string escala = "";
                    escala = ObjDrDados["id_Escala"].ToString();

                    ObjDrCaminho = ObjClnPesquisar.AchaRonda(escala);
                    if (ObjDrCaminho.Read())
                    {
                        mostrarCaminho = ObjDrCaminho["rota"].ToString();
                        mostrarCaminho = mostrarCaminho.Replace("_", " ------ ");
                        txtCaminho.Text = mostrarCaminho;
                        caminho = ObjDrCaminho["rota"].ToString();
                        mskTime.Text = ObjDrCaminho["tempo"].ToString().Replace(":", "");
                        lblAviso.Visible = false;

                        if (txtCaminho.Text != "")
                        {
                            c = 0;
                        }

                    }
                    else
                    {
                        ResetarForm();
                        lblAviso.Text = "Esse Funcionário não tem ronda para " + cboDiaSemana.Text;
                        lblAviso.Visible = true;
                    }

                }

            }
            Check();
        }

        public void LimparFormTodo()
        {
            ResetarForm();
        }

        private void cboDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResetarForm()
        {
            if (i == 1)
            {
                this.Size = new Size(this.Size.Width - 393, this.Size.Height + 0);
                btnBack.Visible = true;
                t = 1;
                i = 0;
                c = 0;
            }

            cbo1.Enabled = false;
            cbo2.Enabled = false;
            btnMais.Enabled = false;

            mostrarCaminho = "";
            caminho = "";
            txtCaminho.Text = "";

            if (Text == "Rondas" && ckDia.Checked == true)
            {
                cbo1.Enabled = true;
                cbo2.Enabled = true;
                btnMais.Enabled = true;
            }
        }
        public void LimparPesquisa()
        {
            if (i == 1)
            {
                this.Size = new Size(this.Size.Width - 393, this.Size.Height + 0);
                btnBack.Visible = true;
                t = 1;
                i = 0;
                c = 0;
            }

            cbo1.Enabled = false;
            cbo2.Enabled = false;
            btnMais.Enabled = false;

            mostrarCaminho = "";
            caminho = "";
            txtCaminho.Text = "";
        }

        private void frmRotas_Shown(object sender, EventArgs e)
        {

        }

        private void frmRotas_Activated(object sender, EventArgs e)
        {

        }
        public void Check()
        {
            if (mostrarCaminho != "")
            {
                ckDia.Checked = true;
            }
            else
            {
                ckDia.Checked = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (mostrarCaminho.IndexOf(" ------") != -1)
            {
                mostrarCaminho = mostrarCaminho.Substring(0, mostrarCaminho.LastIndexOf(" ------"));
            }
            else
            {
                mostrarCaminho = "";
                c = 0;
            }

            if (caminho.IndexOf("_") != -1)
            {
                caminho = caminho.Substring(0, caminho.LastIndexOf("_"));
            }
            else
            {
                caminho = "";
                c = 0;
            }

            txtCaminho.Text = mostrarCaminho;
        }

        private void txtCaminho_TextChanged(object sender, EventArgs e)
        {
            ckDia.Enabled = true;
        }

        private void cbo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAchaIDRonda_KeyPress(object sender, KeyPressEventArgs e)
        {
            ObjUtil.ApenasNumeros(sender, e);
        }

        private void txtAchaIDRonda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            GravarNoBanco();
        }

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            mskTime.Text = cboTime.Text; 
        }

        private void cbo1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ckDia_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDia.Checked == false)
            {
                LimparFormTodo();
                DeixarInvisivelAplicacoes();
            }

            if (ckDia.Checked == true && i == 0)
            {
                this.Size = new Size(this.Size.Width + 393, this.Size.Height + 0);
                btnBack.Visible = false;
                ++i;
                cbo1.Enabled = true;
                cbo2.Enabled = true;
                btnMais.Enabled = true;

                if (Text != "Consultar")
                {
                    AtivarAplicacoesExtras();
                }
            }
        }

        public void AtivarAplicacoesExtras()
        {
            grpAplicar.Visible = true;
            ckDomingo.Visible = true;
            ckSegunda.Visible = true;
            ckTerca.Visible = true;
            ckQuarta.Visible = true;
            ckQuinta.Visible = true;
            ckSexta.Visible = true;
            ckSabado.Visible = true;
        }
    }
}
