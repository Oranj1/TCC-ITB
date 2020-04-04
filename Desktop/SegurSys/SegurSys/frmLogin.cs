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
using System.Globalization;
using System.Threading;

namespace SegurSys
{
    public partial class frmLogin : Form
    {
        clnLogin ObjClnLogin = new clnLogin();
        frmSeguranca ObjFrmSeguranca = new frmSeguranca();
        clnPesquisar ObjClnPesquisar = new clnPesquisar();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ObjClnLogin.User = txtUser.Text.Replace("'", "");
            ObjClnLogin.Senha = txtPass.Text.Replace("'", "");
            ObjFrmSeguranca.Id = txtUser.Text;
            ObjClnLogin.VerificarLogin();

            if(ObjClnLogin.v == 1 || ObjClnLogin.v == 2)
            {
                this.Hide();
            }
        }

        private void btnSaidai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            SqlDataReader ObjDrAdmin;
            ObjDrAdmin = ObjClnPesquisar.TemAdmin();

            if (ObjDrAdmin.Read())
            {
                btnRegistrarAdm.Visible = false;
                btnLogin.Enabled = true;
            }
            else
            {
                btnRegistrarAdm.Visible = true;
                btnLogin.Enabled = false;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_MouseClick(object sender, MouseEventArgs e)
        {
            txtUser.Focus();
        }

        private void btnRegistrarAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrarAdm ObjFrmRegistrarAdm = new frmRegistrarAdm();
            ObjFrmRegistrarAdm.ShowDialog();
        }

        private void pcbShow_Click(object sender, EventArgs e)
        {

        }

        private void pcbShow_MouseHover(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '\0';
        }

        private void pcbShow_MouseLeave(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
    }
}
