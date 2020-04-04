namespace SegurSys
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSaidai = new System.Windows.Forms.Button();
            this.btnRegistrarAdm = new System.Windows.Forms.Button();
            this.pcbShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(390, 150);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(117, 46);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "&Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(14, 51);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 18);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Usuário:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(84, 52);
            this.txtUser.MaxLength = 150;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(423, 22);
            this.txtUser.TabIndex = 3;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(14, 87);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(54, 18);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(74, 88);
            this.txtPass.MaxLength = 100;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(401, 22);
            this.txtPass.TabIndex = 5;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(153, 20);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Por Favor Digite:";
            // 
            // btnSaidai
            // 
            this.btnSaidai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSaidai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaidai.ForeColor = System.Drawing.Color.Red;
            this.btnSaidai.Location = new System.Drawing.Point(6, 175);
            this.btnSaidai.Name = "btnSaidai";
            this.btnSaidai.Size = new System.Drawing.Size(53, 26);
            this.btnSaidai.TabIndex = 11;
            this.btnSaidai.Text = "&Sair";
            this.btnSaidai.UseVisualStyleBackColor = true;
            this.btnSaidai.Click += new System.EventHandler(this.btnSaidai_Click);
            // 
            // btnRegistrarAdm
            // 
            this.btnRegistrarAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarAdm.Location = new System.Drawing.Point(193, 134);
            this.btnRegistrarAdm.Name = "btnRegistrarAdm";
            this.btnRegistrarAdm.Size = new System.Drawing.Size(119, 34);
            this.btnRegistrarAdm.TabIndex = 12;
            this.btnRegistrarAdm.Text = "&Registrar";
            this.btnRegistrarAdm.UseVisualStyleBackColor = true;
            this.btnRegistrarAdm.Visible = false;
            this.btnRegistrarAdm.Click += new System.EventHandler(this.btnRegistrarAdm_Click);
            // 
            // pcbShow
            // 
            this.pcbShow.BackColor = System.Drawing.Color.Transparent;
            this.pcbShow.Image = ((System.Drawing.Image)(resources.GetObject("pcbShow.Image")));
            this.pcbShow.Location = new System.Drawing.Point(479, 79);
            this.pcbShow.Name = "pcbShow";
            this.pcbShow.Size = new System.Drawing.Size(34, 34);
            this.pcbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbShow.TabIndex = 13;
            this.pcbShow.TabStop = false;
            this.pcbShow.Click += new System.EventHandler(this.pcbShow_Click);
            this.pcbShow.MouseLeave += new System.EventHandler(this.pcbShow_MouseLeave);
            this.pcbShow.MouseHover += new System.EventHandler(this.pcbShow_MouseHover);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnSaidai;
            this.ClientSize = new System.Drawing.Size(519, 208);
            this.Controls.Add(this.pcbShow);
            this.Controls.Add(this.btnRegistrarAdm);
            this.Controls.Add(this.btnSaidai);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pcbShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSaidai;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistrarAdm;
        private System.Windows.Forms.PictureBox pcbShow;
    }
}