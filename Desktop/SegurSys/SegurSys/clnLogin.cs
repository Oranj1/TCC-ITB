using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SegurSys
{
    class clnLogin
    {
        string comandoUser;
        string comandoSenha;

        cldBancoDados ObjBancoDados = new cldBancoDados();

        private string _user, _senha;
        public int v = 0;
        private static string _usuarioAdm;

        public string User { get => _user; set => _user = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public static string UsuarioAdm { get => _usuarioAdm; set => _usuarioAdm = value; }

        public void VerificarLogin()
        {
            comandoUser = "select usuario from funcionario where usuario = '" + _user +"'";
            comandoSenha = "select senha from funcionario where senha = '" + _senha + "' and usuario = '" + _user + "'";
            SqlDataReader VerificadorUser;
            SqlDataReader VerificadorSenha;
            VerificadorUser = ObjBancoDados.RetornaLinha(comandoUser);
            VerificadorSenha = ObjBancoDados.RetornaLinha(comandoSenha);
            if (VerificadorUser.Read() && VerificadorSenha.Read())
            {
                string achaUser = VerificadorUser["usuario"].ToString();
                string achaSenha = VerificadorSenha["senha"].ToString();

                if (achaUser != "" && achaSenha != "")
                {
                    comandoUser = "select nivel_acesso from funcionario where usuario = '" + _user + "'";
                    VerificadorUser = ObjBancoDados.RetornaLinha(comandoUser);
                    VerificadorUser.Read();
                    achaUser = VerificadorUser["nivel_acesso"].ToString();

                    if (achaUser == "1")
                    {
                        frmAdm ObjLoginAsAdm = new frmAdm();
                        UsuarioAdm = _user;
                        ObjLoginAsAdm.Show();
                        v = 1;
                    }
                    else
                    {
                        frmSeguranca ObjLoginAsSegur = new frmSeguranca();
                        ObjLoginAsSegur.lblUser.Text = _user;
                        ObjLoginAsSegur.lblUser.Visible = false;
                        ObjLoginAsSegur.Show();
                        v = 2;
                    }
                }
            }
            else
            {
                frmMessageBoxAviso ObjMessageAviso = new frmMessageBoxAviso();
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "Usuario ou Senha Inválidos";
                ObjMessageAviso.ShowDialog();
            }
        }
    }
}
