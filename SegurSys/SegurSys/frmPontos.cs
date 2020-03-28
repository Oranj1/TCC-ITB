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
    public partial class frmPontos : Form
    {
        clnPesquisar ObjClnPesquisar = new clnPesquisar();
        frmMessageBoxAviso ObjMessageAviso = new frmMessageBoxAviso();
        clnRonda ObjClnRonda = new clnRonda();

        public static string areaCode;
        public static string nomeArea;

        public frmPontos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNewName.Text.IndexOf("-") != -1 || txtNewName.Text.IndexOf("_") != -1)
            {
                txtNewName.Text = txtNewName.Text.Replace("_", "").Replace("-", "");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNewName.Text == "")
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "O novo nome deve ser preenchido";
                ObjMessageAviso.ShowDialog();
            }
            else if (AreaJaExiste() == false)
            {
                if (btnAlterar.Text == "&Salvar")
                {
                    ObjClnRonda.Ponto = txtNewName.Text;
                    ObjClnRonda.NovoPonto();

                    ObjMessageAviso.pcbCaution.Visible = false;
                    ObjMessageAviso.lbl1.Text = "Novo ponto adicionado";
                    ObjMessageAviso.ShowDialog();

                    cboAreas.SelectedIndex = -1;
                    btnAlterar.Text = "&Alterar";
                    lblTitulo.Text = "Selecione a area que deseja alterar";
                    cboAreas.Enabled = true;
                    btnExcluir.Enabled = true;
                }
                else if (btnAlterar.Text == "&Alterar")
                {
                    ObjClnRonda.Ponto = txtNewName.Text;
                    ObjClnRonda.AntigoPonto = cboAreas.Text;
                    ObjClnRonda.AlterarPonto();

                    ObjMessageAviso.pcbCaution.Visible = false;
                    ObjMessageAviso.lbl1.Text = "Nome do ponto alterado";
                    ObjMessageAviso.ShowDialog();

                    cboAreas.SelectedIndex = -1;
                }
            }
            else
            {
                ObjMessageAviso.pcbCaution.Visible = true;
                ObjMessageAviso.lbl1.Text = "Já existe um ponto com \n o mesmo nome";
                ObjMessageAviso.ShowDialog();
            }
            PreencherCombo();
        }

        public bool AreaJaExiste()
        {
            SqlDataReader ObjDrExiste;
            ObjDrExiste = ObjClnPesquisar.PontoExistente(txtNewName.Text);
            if (ObjDrExiste.Read())
            {
                string temp = ObjDrExiste["ponto"].ToString();

                if (temp != "") return true;
                else return false;
            }
            else return false;                     
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPontos_Load(object sender, EventArgs e)
        {
            PreencherCombo();
            cboAreas.SelectedIndex = 0;

            if (cboAreas.SelectedIndex != -1)
            {
                txtNewName.Text = cboAreas.Text; 
            }
        }

        public void PreencherCombo()
        {
            cboAreas.DataSource = ObjClnPesquisar.PreencherComboRonda();
            cboAreas.ValueMember = "ponto";
            cboAreas.SelectedIndex = 0;
        }

        private void cboAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNewName.Text = cboAreas.Text;
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            cboAreas.SelectedIndex = -1;
            cboAreas.Enabled = false;
            txtNewName.Text = "";
            btnAlterar.Text = "&Salvar";
            lblTitulo.Text = "Digite o nome da nova area";
            btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ObjClnRonda.Ponto = cboAreas.Text;
            ObjClnRonda.ExcluirPonto();

            ObjMessageAviso.pcbCaution.Visible = false;
            ObjMessageAviso.lbl1.Text = "Ponto " + cboAreas.Text + " excluido";
            ObjMessageAviso.ShowDialog();

            PreencherCombo();
        }

        private void txtNewName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(45) || e.KeyChar == Convert.ToChar(95))
            {
                e.Handled = true;
            }

        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            nomeArea = cboAreas.Text;
            string areaNome = cboAreas.Text;
            SqlDataReader ObjDrDados;
            ObjDrDados = ObjClnPesquisar.IdArea(areaNome);

            if (ObjDrDados.Read())
            {
                areaCode = ObjDrDados["id_area"].ToString();
            }

            frmEscolher ObjfrmEscolher = new frmEscolher();
            ObjfrmEscolher.ShowDialog();
        }
    }
}