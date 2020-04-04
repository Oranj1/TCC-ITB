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
    public partial class frmRegistrarAdm : Form
    {
        clnFuncionario ObjClnFuncionario = new clnFuncionario();
        frmMessageBoxAviso ObjMessageAviso = new frmMessageBoxAviso();
        clnUtil ObjUtil = new clnUtil();
        clnPesquisar ObjClnPesquisar = new clnPesquisar();

        public frmRegistrarAdm()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '\0';
            txtConfirmarSenha.PasswordChar = '\0';
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void frmRegistrarAdm_Load(object sender, EventArgs e)
        {
            txtConfirmarSenha.ContextMenu = new ContextMenu();
        }

        private void frmRegistrarAdm_MouseLeave(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            txtConfirmarSenha.PasswordChar = '*';
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == "" || txtConfirmarSenha.Text == "" || txtUser.Text == "")
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "Todos dados devem ser preenchidos";
                ObjMessageAviso.ShowDialog();
            }
            else if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                ObjMessageAviso.lbl1.Text = "As senhas são difrentes";
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.ShowDialog();
            }
            else if (ObjUtil.ValidarSenha(txtSenha.Text) == false)
            {
                ObjMessageAviso.lbl1.Text = "A senha deve conter pelo menos 6 \n caracteres com uma letra e um digito";
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.ShowDialog();
            }
            else if (txtSenha.Text.IndexOf(" ") != -1)
            {
                ObjMessageAviso.lbl1.Text = "A senha não pode conter espaço";
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.ShowDialog();
            }
            else if(ExisteUser() == true)
            {
                ObjMessageAviso.lbl1.Text = "Esse usuário já existe";
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.ShowDialog();
            }
            else
            {
                ObjClnFuncionario.User = txtUser.Text;
                ObjClnFuncionario.Pass = txtSenha.Text;
                ObjClnFuncionario.RegistrarAdm();

                ObjMessageAviso.pcbCaution.Visible = false;
                ObjMessageAviso.lbl1.Text = "Administrador registrado";
                ObjMessageAviso.ShowDialog();

                this.Hide();
                frmLogin ObjFrmLogin = new frmLogin();
                ObjFrmLogin.ShowDialog();
            }
        }
        private bool ExisteUser()
        {
            string user = "";

            SqlDataReader Verificador;
            Verificador = ObjClnPesquisar.PesquisarExisteAdm(txtUser.Text);

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

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            lblAvisoSenha.Visible = true;

            if (txtSenha.Text.IndexOf(" ") != -1)
            {
                txtSenha.Text = txtSenha.Text.Replace(" ", "");
            }

            lblAvisoSenha.Text = "Senha Fraca";
            lblAvisoSenha.ForeColor = Color.Red;

            if (txtSenha.TextLength >= 6 && ObjUtil.ValidarSenha(txtSenha.Text) == true)
            {
                lblAvisoSenha.Text = "Senha Média";
                lblAvisoSenha.ForeColor = Color.Orange;

                if (txtSenha.TextLength >= 8 && ObjUtil.ValidarSenha(txtSenha.Text) == true && txtSenha.Text.Any(s => char.IsSymbol(s)) || txtSenha.TextLength > 11 && ObjUtil.ValidarSenha(txtSenha.Text) == true)
                {
                    lblAvisoSenha.Text = "Senha Forte";
                    lblAvisoSenha.ForeColor = Color.Green;
                }
            }
            else if (txtSenha.TextLength >= 12)
            {
                lblAvisoSenha.Text = "Senha Média";
                lblAvisoSenha.ForeColor = Color.Orange;
            }
        }

        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

            if (txtConfirmarSenha.Text.IndexOf(" ") != -1)
            {
                txtConfirmarSenha.Text = txtConfirmarSenha.Text.Replace(" ", "");
            }


            if (txtConfirmarSenha.Text != txtSenha.Text && lblAvisoSenha.Text != "Senha Fraca")
            {
                lblAvisoSenha.Visible = true;
                lblAvisoSenha.Text = "As senhas não são iguais";
                lblAvisoSenha.ForeColor = Color.Red;
            }
            else lblAvisoSenha.Visible = false;
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (lblAvisoSenha.Text != "Senha Fraca") lblAvisoSenha.Visible = false;
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            if (lblAvisoSenha.Text != "As senhas não são iguais") lblAvisoSenha.Visible = false;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlDataReader Verificador;
                Verificador = ObjClnPesquisar.PesquisarExisteAlterar(txtUser.Text, txtUser.Text);

                if (Verificador.Read())
                {
                    string user = Verificador["usuario"].ToString();
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
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtConfirmarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.IndexOf(" ") != -1)
            {
                txtUser.Text = txtUser.Text.Replace(" ", "");
            }
        }

        private void btnFachar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtConfirmarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
