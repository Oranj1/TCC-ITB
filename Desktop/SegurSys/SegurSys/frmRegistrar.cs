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
    public partial class frmRegistrar : Form
    {
        string user, cpf;
        public string antigoUser, antigoCpf;

        frmLogin ObjfrmLogin = new frmLogin();
        clnPesquisar ObjClnPesquisar = new clnPesquisar();
        clnUtil ObjUtil = new clnUtil();
        frmMessageBoxAviso ObjMessageAviso = new frmMessageBoxAviso();

        public frmRegistrar()
        {
            InitializeComponent();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            epSenha.Clear();

            lblAvisoSenha.Visible = true;

            if (txtRegistrarSenha.Text.IndexOf(" ") != -1)
            {
                txtRegistrarSenha.Text = txtRegistrarSenha.Text.Replace(" ", "");
            }

            lblAvisoSenha.Text = "Senha Fraca";
            lblAvisoSenha.ForeColor = Color.Red;

            if (txtRegistrarSenha.TextLength >= 6 && ObjUtil.ValidarSenha(txtRegistrarSenha.Text) == true)
            {
                lblAvisoSenha.Text = "Senha Média";
                lblAvisoSenha.ForeColor = Color.Orange;

                if (txtRegistrarSenha.TextLength >= 8 && ObjUtil.ValidarSenha(txtRegistrarSenha.Text) == true && txtRegistrarSenha.Text.Any(s => char.IsSymbol(s)) || txtRegistrarSenha.TextLength > 11 && ObjUtil.ValidarSenha(txtRegistrarSenha.Text) == true)
                {
                    lblAvisoSenha.Text = "Senha Forte";
                    lblAvisoSenha.ForeColor = Color.Green;
                }
            }
            else if (txtRegistrarSenha.TextLength >= 21)
            {
                lblAvisoSenha.Text = "Senha Média";
                lblAvisoSenha.ForeColor = Color.Orange;
            }
        }

        public void frmConsultar_Load(object sender, EventArgs e)
        {
            txtNomeFull.ContextMenu = new ContextMenu();

            if (txtAchaID.Text != "")
            {
                SqlDataReader ObjDrDados;
                ObjDrDados = ObjClnPesquisar.LocalizarId(txtAchaID.Text);
                if (ObjDrDados.Read())
                {
                    txtNomeFull.Text = ObjDrDados["nome"].ToString();
                    txtTel.Text = ObjDrDados["telefone"].ToString();
                    mskCel.Text = ObjDrDados["celular"].ToString();
                    txtCpf.Text = ObjDrDados["cpf"].ToString();
                    txtRg.Text = ObjDrDados["rg"].ToString();
                    txtRegistarLogin.Text = ObjDrDados["usuario"].ToString();
                    txtRegistrarSenha.Text = ObjDrDados["senha"].ToString();
                    antigoCpf = txtCpf.Text;
                    antigoUser = txtRegistarLogin.Text;
                }
            }
            if (Text == "Registrar")
            {
                btnEscala.Visible = false;
            }
            if (txtNomeFull.Text == "")
            {
                btnEscala.Enabled = false;
            }
            else
            {
                btnEscala.Enabled = true;
            }
            txtNomeFull.Focus();
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void Limpar()
        {
            txtAchaID.Clear();
            txtNomeFull.Clear();
            txtRegistarLogin.Clear();
            txtRegistarLogin.Clear();
            txtRg.Clear();
            txtTel.Clear();
            mskCel.Clear();
            txtCpf.Clear();
            txtRegistrarSenha.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clnFuncionario ObjClnFuncionario = new clnFuncionario();
            ObjUtil.Cpf = txtCpf.Text;
            ObjUtil.ValidaCpf();
            //Verifica se tem pelo menos um caracter em cada txt;
            if (txtNomeFull.Text == "" || mskCel.Text == "" || txtRegistarLogin.Text == "" || txtRegistrarSenha.Text == "" || txtCpf.Text == "")
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "Os campos com * devem ser \n preenchidos";
                ObjMessageAviso.ShowDialog();

                if (txtRegistrarSenha.Text == "")
                {
                    epSenha.SetError(txtRegistrarSenha, "A senha deve ser preenchida");
                    txtRegistrarSenha.Focus();
                }
                if (txtRegistarLogin.Text == "")
                {
                    epUser.SetError(txtRegistarLogin, "O usuáiro deve ser preenchido");
                    txtRegistarLogin.Focus();
                }

                if (txtTel.Text == "")
                {
                    epTel.SetError(txtTel, "O número do telefone deve ser preenchido");
                    txtTel.Focus();
                }

                if (mskCel.Text == "")
                {
                    epCell.SetError(mskCel, "O número do celular deve ser preenchido");
                    mskCel.Focus();
                }

                if (txtNomeFull.Text == "")
                {
                    epNome.SetError(txtNomeFull, "O nome deve ser preenchido");
                    txtNomeFull.Focus();
                }
                if (txtCpf.Text == "")
                {
                    epCpf.SetError(txtNomeFull, "O CPF deve ser preenchido");
                    txtCpf.Focus();
                }
            }
            //Verifica se CPF validou com o Método ValidaCpf();
            else if (ObjUtil.ValidaCpf() == false)
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "CPF inválido";
                ObjMessageAviso.ShowDialog();

                txtCpf.Focus();
            }
            else if (ObjUtil.ValidarSenha(txtRegistrarSenha.Text) == false)
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "A senha deve conter pelo menos 6 \n caracteres com uma letra e um digito";
                ObjMessageAviso.ShowDialog();
                epSenha.SetError(txtRegistrarSenha, "A senha é muito fraca");
                txtRegistrarSenha.Focus();
            }
            else if (txtRegistarLogin.Text.IndexOf(" ") != -1)
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "O nome de usuario não pode \n conter espaço";
                ObjMessageAviso.ShowDialog();
            }
            else if (txtRegistrarSenha.Text.IndexOf(" ") != -1)
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "A senha não pode \n conter espaço";
                ObjMessageAviso.ShowDialog();
            }
            else if (mskCel.Text.Length != 11)
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "Número de celular incompleto";
                ObjMessageAviso.ShowDialog();

                epCell.SetError(mskCel, "O número está incompelto");
                mskCel.Focus();
            }
            else if (txtTel.Text.Length != 10)
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "Número de telefone incompleto";
                ObjMessageAviso.ShowDialog();

                epTel.SetError(txtTel, "O número está incompelto");
                txtTel.Focus();
            }
            //Se passar por tudo vem pra cá e altera;
            else if (btnModificar.Text == "&Alterar")
            {
                if (ExisteAlterarUser() == false && ExisteAlterarCpf() == false)
                {
                    //Códigio de alteração
                    ObjClnFuncionario.Id = txtAchaID.Text;
                    ObjClnFuncionario.Nome = txtNomeFull.Text.Replace("'","");
                    ObjClnFuncionario.Tel = txtTel.Text;
                    ObjClnFuncionario.Cel = mskCel.Text;
                    ObjClnFuncionario.Cpf = txtCpf.Text;
                    ObjClnFuncionario.Rg = txtRg.Text.Replace("'", "");
                    ObjClnFuncionario.User = txtRegistarLogin.Text.Replace("'", "");
                    ObjClnFuncionario.Pass = txtRegistrarSenha.Text.Replace("'", "");
                    ObjClnFuncionario.Alterar();

                    ObjMessageAviso.pcbCaution.Visible = false;
                    ObjMessageAviso.lbl1.Text = "Cadastro alterado com sucesso";
                    ObjMessageAviso.ShowDialog();

                    if (btnPesquisa.Visible == true)
                    {
                        Limpar();
                    }
                    if (btnPesquisa.Text == "&Limpar")
                    {
                        OutraPesquisa();
                        btnPesquisa.Text = "&Pesquisar";
                        btnPesquisa.Location = new Point(btnPesquisa.Location.X - 380, btnPesquisa.Location.Y);
                    }
                }
                else
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "Já existe um registro com \n mesmo CPF ou usuario";
                    ObjMessageAviso.ShowDialog();
                }
            }
            //Se passar por tudo e o nome do btn Modificar não for "&Alterar" e sim "&Registrar" registra;
            else if (btnModificar.Text == "&Registrar")
            {
                if (Existe() == false)
                {
                    //Código de novo registro
                    ObjClnFuncionario.Nome = txtNomeFull.Text.Replace("'", ""); ;
                    ObjClnFuncionario.Tel = txtTel.Text;
                    ObjClnFuncionario.Cel = mskCel.Text;
                    ObjClnFuncionario.Cpf = txtCpf.Text;
                    ObjClnFuncionario.Rg = txtRg.Text.Replace("'", "");
                    ObjClnFuncionario.User = txtRegistarLogin.Text.Replace("'", "");
                    ObjClnFuncionario.Pass = txtRegistrarSenha.Text.Replace("'", "");
                    ObjClnFuncionario.Registrar();

                    ObjMessageAviso.pcbCaution.Visible = false;
                    ObjMessageAviso.lbl1.Text = "Cadastro efetuado com sucesso";
                    ObjMessageAviso.ShowDialog();

                    OutraPesquisa();
                    Limpar();
                }
                else
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "Já existe um registro com \n mesmo CPF ou usuario";
                    ObjMessageAviso.ShowDialog();
                }
            }
        }

        private void txtNomeFull_TextChanged(object sender, EventArgs e)
        {
            // txtNomeFull.BorderStyle = BorderStyle.None;
            // Graphics g = this.CreateGraphics();
            // g.DrawRectangle(new Pen(Brushes.Gray), txtNomeFull.Location.X - 1, txtNomeFull.Location.Y - 1, txtNomeFull.Width + 1, txtNomeFull.Height + 6);
            epNome.Clear();
        }
        private bool Existe()
        {
            SqlDataReader Verificador;
            Verificador = ObjClnPesquisar.PesquisarUsuarioExistente(txtRegistarLogin.Text, txtCpf.Text);
            if (Verificador.Read())
            {
                user = Verificador["usuario"].ToString();
                cpf = Verificador["cpf"].ToString();
                if (user != "" || cpf != "")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private bool ExisteAlterarUser()
        {
            if (txtRegistarLogin.Text != antigoUser)
            {
                SqlDataReader Verificador;
                Verificador = ObjClnPesquisar.PesquisarExisteAlterar(txtRegistarLogin.Text, antigoUser);

                if (Verificador.Read())
                {
                    user = Verificador["usuario"].ToString();
                    if (user != "")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private bool ExisteAlterarCpf()
        {
            if (txtCpf.Text != antigoCpf)
            {
                SqlDataReader VerificadorCpf;
                VerificadorCpf = ObjClnPesquisar.PesquisarExisteAlterarCpf(txtCpf.Text, antigoCpf);
                if (VerificadorCpf.Read())
                {
                    cpf = VerificadorCpf["cpf"].ToString();
                    if (cpf != "")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private void mskCel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            epCell.Clear();
        }

        private void txtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            epTel.Clear();
        }

        private void txtRegistarLogin_TextChanged(object sender, EventArgs e)
        {
            epUser.Clear();
            if (txtRegistrarSenha.Text.IndexOf(" ") != -1)
            {
                txtRegistrarSenha.Text = txtRegistrarSenha.Text.Replace(" ", "");
            }
        }

        private void mskBegin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskEnd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskIntervalBegin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskIntervalEnd_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmRegistrar_TextChanged(object sender, EventArgs e)
        {

        }

        public void btnEscala_Click(object sender, EventArgs e)
        {
            frmEscala ObjFrmEscala = new frmEscala();
            ObjFrmEscala.btnPesquisar.Visible = false;
            ObjFrmEscala.txtId.Enabled = false;

            if (Text == "Consultar")
            {
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


                if (txtAchaID.Text != "")
                {
                    ObjFrmEscala.txtId.Text = txtAchaID.Text;
                    ObjFrmEscala.id = txtAchaID.Text;
                }
                if (lblAidi.Text != "ID:*")
                {
                    ObjFrmEscala.btnPesquisar.Visible = false;
                    ObjFrmEscala.lblAidi.Visible = false;
                    ObjFrmEscala.txtId.Visible = false;
                    ObjFrmEscala.id = lblAviso.Text;
                    ObjFrmEscala.lblUsuario.Location = new Point(ObjFrmEscala.lblUsuario.Location.X, ObjFrmEscala.lblUsuario.Location.Y - 40);
                }

                ObjFrmEscala.cboDiaSemana.SelectedIndex = 0;

                ObjFrmEscala.ShowDialog();
            }
            else if (Text == "Alterar")
            {
                ObjFrmEscala.Text = "Alterar";
                ObjFrmEscala.ckDia.Enabled = false;
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
                if (txtAchaID.Text != "")
                {
                    ObjFrmEscala.txtId.Text = txtAchaID.Text;
                    ObjFrmEscala.id = txtAchaID.Text;
                }
                ObjFrmEscala.ShowDialog();
            }

        }

        private void txtRegistarSenha_Leave(object sender, EventArgs e)
        {
            if(lblAvisoSenha.Text != "Senha Fraca") lblAvisoSenha.Visible = false;
        }

        private void txtRegistarSenha_Click(object sender, EventArgs e)
        {
            lblAvisoSenha.Visible = true;
        }

        private void txtRegistarLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && Text == "Registrar")
            {
                SqlDataReader Verificador;
                Verificador = ObjClnPesquisar.PesquisarUserExiste(txtRegistarLogin.Text);

                if (Verificador.Read())
                {
                    user = Verificador["usuario"].ToString();

                    if (user != "")
                    {
                        ObjMessageAviso.pcbCaution.Visible = true;
                        ObjMessageAviso.lbl1.Text = "Usuario inválido";
                        ObjMessageAviso.ShowDialog();
                    }
                    else
                    {
                        ObjMessageAviso.lbl1.Text = "Usuario válido";
                        ObjMessageAviso.ShowDialog();
                    }
                }
                else
                {
                    ObjMessageAviso.lbl1.Text = "Usuario válido";
                    ObjMessageAviso.ShowDialog();
                }
            }
            else if (e.KeyCode == Keys.Enter && Text == "Alterar")
            {
                if (txtRegistarLogin.Text != antigoUser)
                {
                    SqlDataReader Verificador;
                    Verificador = ObjClnPesquisar.PesquisarExisteAlterar(txtRegistarLogin.Text, antigoUser);

                    if (Verificador.Read())
                    {
                        user = Verificador["usuario"].ToString();
                        if (user != "")
                        {
                            ObjMessageAviso.lbl1.Text = "Usuario inválido";
                            ObjMessageAviso.ShowDialog();
                        }
                        else
                        {
                            ObjMessageAviso.pcbCaution.Visible = true;
                            ObjMessageAviso.lbl1.Text = "Usuario válido";
                            ObjMessageAviso.ShowDialog();
                        }
                    }
                    else
                    {
                        ObjMessageAviso.pcbCaution.Visible = true;
                        ObjMessageAviso.lbl1.Text = "Usuario válido";
                        ObjMessageAviso.ShowDialog();
                    }
                }
                else
                {
                    ObjMessageAviso.lbl1.Text = "Usuario válido";
                    ObjMessageAviso.ShowDialog();
                }
            }
        }

        private void txtRegistarLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRegistarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pcShowPass_MouseHover(object sender, EventArgs e)
        {
            txtRegistrarSenha.PasswordChar = '\0';
        }

        private void pcShowPass_MouseLeave(object sender, EventArgs e)
        {
            txtRegistrarSenha.PasswordChar = '*';
        }

        private void txtAchaID_KeyPress(object sender, KeyPressEventArgs e)
        {
            ObjUtil.ApenasNumeros(sender, e);
        }

        private void txtNomeFull_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNomeFull_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtNomeFull_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtNomeFull_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeFull_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void grpA_Enter(object sender, EventArgs e)
        {

        }

        private void txtNomeFull_Leave(object sender, EventArgs e)
        {
            if (Text == "Registrar" && txtNomeFull.Text.IndexOf(" ") != -1 && txtRegistarLogin.Text == "")
            {
                int x = txtNomeFull.Text.IndexOf(" ");
                txtRegistarLogin.Text = txtNomeFull.Text.Substring(0, x);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (Text == "Alterar" && btnPesquisa.Text != "&Limpar")
            {
                SqlDataReader ObjDrDados;
                ObjDrDados = ObjClnPesquisar.LocalizarId(txtAchaID.Text);
                if (ObjDrDados.Read())
                {
                    txtAchaID.Enabled = false;
                    btnPesquisa.Enabled = true;
                    btnPesquisa.Text = "&Limpar";
                    btnPesquisa.Location = new Point(btnPesquisa.Location.X + 380, btnPesquisa.Location.Y);
                    txtNomeFull.Enabled = true;
                    txtTel.Enabled = true;
                    txtCpf.Enabled = true;
                    txtRg.Enabled = true;
                    mskCel.Enabled = true;
                    txtRegistarLogin.Enabled = true;
                    txtRegistrarSenha.Enabled = true;
                    btnModificar.Enabled = true;
                    txtNomeFull.Text = ObjDrDados["nome"].ToString();
                    txtTel.Text = ObjDrDados["telefone"].ToString();
                    mskCel.Text = ObjDrDados["celular"].ToString();
                    txtCpf.Text = ObjDrDados["cpf"].ToString();
                    txtRg.Text = ObjDrDados["rg"].ToString();
                    txtRegistarLogin.Text = ObjDrDados["usuario"].ToString();
                    txtRegistrarSenha.Text = ObjDrDados["senha"].ToString();
                    antigoCpf = txtCpf.Text;
                    antigoUser = txtRegistarLogin.Text;
                    if (txtNomeFull.Text == "")
                    {
                        btnEscala.Enabled = false;
                    }
                    else
                    {
                        btnEscala.Enabled = true;
                    }
                }
                else
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "Esse Id não existe";
                    ObjMessageAviso.ShowDialog();

                    txtNomeFull.Enabled = false;
                    txtTel.Enabled = false;
                    txtCpf.Enabled = false;
                    txtRg.Enabled = false;
                    mskCel.Enabled = false;
                    txtRegistarLogin.Enabled = false;
                    txtRegistrarSenha.Enabled = false;
                    btnModificar.Enabled = false;
                    Limpar();
                }
            }
            else if (Text == "Consultar" && txtAchaID.Text != "")
            {
                txtNomeFull.Text = "";
                txtTel.Text = "";
                mskCel.Text = "";
                txtCpf.Text = "";
                txtRg.Text = "";
                txtRegistarLogin.Text = "";
                txtRegistrarSenha.Text = "";
                SqlDataReader ObjDrDados;
                ObjDrDados = ObjClnPesquisar.LocalizarId(txtAchaID.Text);
                if (ObjDrDados.Read())
                {
                    txtNomeFull.Text = ObjDrDados["nome"].ToString();
                    txtTel.Text = ObjDrDados["telefone"].ToString();
                    mskCel.Text = ObjDrDados["celular"].ToString();
                    txtCpf.Text = ObjDrDados["cpf"].ToString();
                    txtRg.Text = ObjDrDados["rg"].ToString();
                    txtRegistarLogin.Text = ObjDrDados["usuario"].ToString();
                    txtRegistrarSenha.Text = ObjDrDados["senha"].ToString();
                    if (txtNomeFull.Text == "")
                    {
                        btnEscala.Enabled = false;
                    }
                    else
                    {
                        btnEscala.Enabled = true;
                    }
                }
                else
                {
                    ObjMessageAviso.pcbCaution.Visible = true;
                    ObjMessageAviso.lbl1.Text = "Esse Id não existe";
                    ObjMessageAviso.ShowDialog();
                }
            }
            else if (btnPesquisa.Text == "&Limpar")
            {
                OutraPesquisa();
                btnPesquisa.Text = "&Pesquisar";
                btnPesquisa.Location = new Point(btnPesquisa.Location.X - 380, btnPesquisa.Location.Y);
            }
            else
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "Digite um ID";
                ObjMessageAviso.ShowDialog();
            }
        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            ObjUtil.Cpf = txtCpf.Text;
            ObjUtil.ValidaCpf();

            if (txtCpf.Text != "")
            {
                if (ObjUtil.ValidaCpf() == false)
                {
                    epCpf.SetError(txtCpf, "O CPF é invalido");
                }
                else
                {
                    epCpf.Clear();
                }
            }
        }
        /*private void mskBegin_TextChanged(object sender, EventArgs e)
          {
              if (mskBegin.Text != "")
              {
                  if (clnUtil.ValidarHora(mskBegin.Text) == false)
                  {
                      epInicio.SetError(mskBegin, "O horário é inválido");
                  }
                  else
                  {
                      epInicio.Clear();
                  }
              }
          }

          private void mskEnd_TextChanged(object sender, EventArgs e)
          {
              if (mskEnd.Text != "")
              {
                  if (clnUtil.ValidarHora(mskEnd.Text) == false)
                  {
                      epFim.SetError(mskEnd, "O horário é inválido");
                  }
                  else
                  {
                      epFim.Clear();
                  }
              }
          }

          private void mskIntervalBegin_TextChanged(object sender, EventArgs e)
          {
              if (mskIntervalBegin.Text != "")
              {
                  if (clnUtil.ValidarHora(mskIntervalBegin.Text) == false)
                  {
                      epIntevalo.SetError(mskIntervalBegin, "O horário é inválido");
                  }
                  else
                  {
                      epIntevalo.Clear();
                  }
              }
          }

          private void mskIntervalEnd_TextChanged(object sender, EventArgs e)
          {
              if (mskIntervalEnd.Text != "")
              {
                  if (clnUtil.ValidarHora(mskIntervalEnd.Text) == false)
                  {
                      epIntervaloFim.SetError(mskIntervalEnd, "O horário é inválido");
                  }
                  else
                  {
                      epIntervaloFim.Clear();
                  }
              }
          }
          */
        public void OutraPesquisa()
        {
            if (btnPesquisa.Visible == true)
            {
                Limpar();
                txtAchaID.Enabled = true;
                btnPesquisa.Enabled = true;
                btnModificar.Enabled = false;
                txtNomeFull.Enabled = false;
                txtTel.Enabled = false;
                txtCpf.Enabled = false;
                txtRg.Enabled = false;
                mskCel.Enabled = false;
                txtRegistarLogin.Enabled = false;
                txtRegistrarSenha.Enabled = false;
            }
        }
    }
}
