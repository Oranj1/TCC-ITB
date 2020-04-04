namespace SegurSys
{
    partial class frmRegistrar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.grpA = new System.Windows.Forms.GroupBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNomeFull = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAvisoSenha = new System.Windows.Forms.Label();
            this.txtRegistrarSenha = new System.Windows.Forms.TextBox();
            this.txtRegistarLogin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblAidi = new System.Windows.Forms.Label();
            this.txtAchaID = new System.Windows.Forms.TextBox();
            this.epNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCell = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTel = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSenha = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCpf = new System.Windows.Forms.ErrorProvider(this.components);
            this.epInicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFim = new System.Windows.Forms.ErrorProvider(this.components);
            this.epIntevalo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epIntervaloFim = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEscala = new System.Windows.Forms.Button();
            this.pcShowPass = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.grpA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIntevalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIntervaloFim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcShowPass)).BeginInit();
            this.SuspendLayout();
            // 
            // grpA
            // 
            this.grpA.BackColor = System.Drawing.Color.Transparent;
            this.grpA.Controls.Add(this.txtRg);
            this.grpA.Controls.Add(this.txtCpf);
            this.grpA.Controls.Add(this.txtTel);
            this.grpA.Controls.Add(this.mskCel);
            this.grpA.Controls.Add(this.label4);
            this.grpA.Controls.Add(this.label3);
            this.grpA.Controls.Add(this.label2);
            this.grpA.Controls.Add(this.lblCpf);
            this.grpA.Controls.Add(this.txtNomeFull);
            this.grpA.Controls.Add(this.label1);
            this.grpA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpA.Location = new System.Drawing.Point(12, 37);
            this.grpA.Name = "grpA";
            this.grpA.Size = new System.Drawing.Size(592, 135);
            this.grpA.TabIndex = 0;
            this.grpA.TabStop = false;
            this.grpA.Text = "Dados Pessoais:";
            this.grpA.Enter += new System.EventHandler(this.grpA_Enter);
            // 
            // txtRg
            // 
            this.txtRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(225, 98);
            this.txtRg.Mask = "aaaaaaaaaaaaaa";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(132, 22);
            this.txtRg.TabIndex = 6;
            this.txtRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(63, 97);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(107, 22);
            this.txtCpf.TabIndex = 5;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCpf_MaskInputRejected);
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(310, 62);
            this.txtTel.Mask = "(99) 0000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(116, 23);
            this.txtTel.TabIndex = 4;
            this.txtTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTel_MaskInputRejected);
            // 
            // mskCel
            // 
            this.mskCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCel.Location = new System.Drawing.Point(86, 62);
            this.mskCel.Mask = "(99) 90000-0000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(120, 23);
            this.mskCel.TabIndex = 3;
            this.mskCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCel_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(231, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefone:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Celular: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "RG:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(15, 100);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(43, 17);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF:*";
            // 
            // txtNomeFull
            // 
            this.txtNomeFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFull.Location = new System.Drawing.Point(142, 31);
            this.txtNomeFull.MaxLength = 150;
            this.txtNomeFull.Name = "txtNomeFull";
            this.txtNomeFull.Size = new System.Drawing.Size(446, 22);
            this.txtNomeFull.TabIndex = 2;
            this.txtNomeFull.Click += new System.EventHandler(this.txtNomeFull_Click);
            this.txtNomeFull.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNomeFull_MouseClick);
            this.txtNomeFull.TextChanged += new System.EventHandler(this.txtNomeFull_TextChanged);
            this.txtNomeFull.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNomeFull_KeyDown);
            this.txtNomeFull.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFull_KeyPress);
            this.txtNomeFull.Leave += new System.EventHandler(this.txtNomeFull_Leave);
            this.txtNomeFull.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNomeFull_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo: *";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblAvisoSenha);
            this.groupBox1.Controls.Add(this.txtRegistrarSenha);
            this.groupBox1.Controls.Add(this.txtRegistarLogin);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Login:";
            // 
            // lblAvisoSenha
            // 
            this.lblAvisoSenha.AutoSize = true;
            this.lblAvisoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAvisoSenha.ForeColor = System.Drawing.Color.Red;
            this.lblAvisoSenha.Location = new System.Drawing.Point(67, 94);
            this.lblAvisoSenha.Name = "lblAvisoSenha";
            this.lblAvisoSenha.Size = new System.Drawing.Size(77, 15);
            this.lblAvisoSenha.TabIndex = 20;
            this.lblAvisoSenha.Text = "Senha Fraca";
            this.lblAvisoSenha.Visible = false;
            // 
            // txtRegistrarSenha
            // 
            this.txtRegistrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistrarSenha.Location = new System.Drawing.Point(69, 68);
            this.txtRegistrarSenha.MaxLength = 16;
            this.txtRegistrarSenha.Name = "txtRegistrarSenha";
            this.txtRegistrarSenha.PasswordChar = '*';
            this.txtRegistrarSenha.Size = new System.Drawing.Size(253, 22);
            this.txtRegistrarSenha.TabIndex = 8;
            this.txtRegistrarSenha.Click += new System.EventHandler(this.txtRegistarSenha_Click);
            this.txtRegistrarSenha.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtRegistrarSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegistarSenha_KeyPress);
            this.txtRegistrarSenha.Leave += new System.EventHandler(this.txtRegistarSenha_Leave);
            // 
            // txtRegistarLogin
            // 
            this.txtRegistarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistarLogin.Location = new System.Drawing.Point(76, 28);
            this.txtRegistarLogin.MaxLength = 50;
            this.txtRegistarLogin.Name = "txtRegistarLogin";
            this.txtRegistarLogin.Size = new System.Drawing.Size(246, 22);
            this.txtRegistarLogin.TabIndex = 7;
            this.txtRegistarLogin.TextChanged += new System.EventHandler(this.txtRegistarLogin_TextChanged);
            this.txtRegistarLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRegistarLogin_KeyDown);
            this.txtRegistarLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegistarLogin_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Senha: *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Usuário: *";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Black;
            this.lblAviso.Location = new System.Drawing.Point(12, 323);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(286, 15);
            this.lblAviso.TabIndex = 90;
            this.lblAviso.Text = "Os campos com * tem o preenchimento obrigatório";
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(381, 299);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 35);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "&Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblAidi
            // 
            this.lblAidi.AutoSize = true;
            this.lblAidi.BackColor = System.Drawing.Color.Transparent;
            this.lblAidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAidi.Location = new System.Drawing.Point(12, 9);
            this.lblAidi.Name = "lblAidi";
            this.lblAidi.Size = new System.Drawing.Size(29, 16);
            this.lblAidi.TabIndex = 10;
            this.lblAidi.Text = "ID:*";
            // 
            // txtAchaID
            // 
            this.txtAchaID.BackColor = System.Drawing.Color.White;
            this.txtAchaID.Location = new System.Drawing.Point(45, 8);
            this.txtAchaID.MaxLength = 100;
            this.txtAchaID.Name = "txtAchaID";
            this.txtAchaID.Size = new System.Drawing.Size(95, 20);
            this.txtAchaID.TabIndex = 1;
            this.txtAchaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAchaID_KeyPress);
            // 
            // epNome
            // 
            this.epNome.ContainerControl = this;
            this.epNome.Icon = ((System.Drawing.Icon)(resources.GetObject("epNome.Icon")));
            // 
            // epCell
            // 
            this.epCell.ContainerControl = this;
            this.epCell.Icon = ((System.Drawing.Icon)(resources.GetObject("epCell.Icon")));
            // 
            // epTel
            // 
            this.epTel.ContainerControl = this;
            this.epTel.Icon = ((System.Drawing.Icon)(resources.GetObject("epTel.Icon")));
            // 
            // epUser
            // 
            this.epUser.ContainerControl = this;
            this.epUser.Icon = ((System.Drawing.Icon)(resources.GetObject("epUser.Icon")));
            // 
            // epSenha
            // 
            this.epSenha.ContainerControl = this;
            this.epSenha.Icon = ((System.Drawing.Icon)(resources.GetObject("epSenha.Icon")));
            // 
            // epCpf
            // 
            this.epCpf.ContainerControl = this;
            this.epCpf.Icon = ((System.Drawing.Icon)(resources.GetObject("epCpf.Icon")));
            // 
            // epInicio
            // 
            this.epInicio.ContainerControl = this;
            this.epInicio.Icon = ((System.Drawing.Icon)(resources.GetObject("epInicio.Icon")));
            // 
            // epFim
            // 
            this.epFim.ContainerControl = this;
            this.epFim.Icon = ((System.Drawing.Icon)(resources.GetObject("epFim.Icon")));
            // 
            // epIntevalo
            // 
            this.epIntevalo.ContainerControl = this;
            this.epIntevalo.Icon = ((System.Drawing.Icon)(resources.GetObject("epIntevalo.Icon")));
            // 
            // epIntervaloFim
            // 
            this.epIntervaloFim.ContainerControl = this;
            this.epIntervaloFim.Icon = ((System.Drawing.Icon)(resources.GetObject("epIntervaloFim.Icon")));
            // 
            // btnEscala
            // 
            this.btnEscala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscala.Location = new System.Drawing.Point(499, 187);
            this.btnEscala.Name = "btnEscala";
            this.btnEscala.Size = new System.Drawing.Size(105, 51);
            this.btnEscala.TabIndex = 10;
            this.btnEscala.Text = "&Escala Desse Funcionario";
            this.btnEscala.UseVisualStyleBackColor = true;
            this.btnEscala.Click += new System.EventHandler(this.btnEscala_Click);
            // 
            // pcShowPass
            // 
            this.pcShowPass.BackColor = System.Drawing.Color.Transparent;
            this.pcShowPass.Image = ((System.Drawing.Image)(resources.GetObject("pcShowPass.Image")));
            this.pcShowPass.Location = new System.Drawing.Point(357, 240);
            this.pcShowPass.Name = "pcShowPass";
            this.pcShowPass.Size = new System.Drawing.Size(35, 33);
            this.pcShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcShowPass.TabIndex = 93;
            this.pcShowPass.TabStop = false;
            this.pcShowPass.MouseLeave += new System.EventHandler(this.pcShowPass_MouseLeave);
            this.pcShowPass.MouseHover += new System.EventHandler(this.pcShowPass_MouseHover);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(530, 309);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(74, 29);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(146, 8);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(83, 23);
            this.btnPesquisa.TabIndex = 94;
            this.btnPesquisa.Text = "&Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // frmRegistrar
            // 
            this.AcceptButton = this.btnModificar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(625, 343);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.pcShowPass);
            this.Controls.Add(this.btnEscala);
            this.Controls.Add(this.txtAchaID);
            this.Controls.Add(this.lblAidi);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistrar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.frmConsultar_Load);
            this.TextChanged += new System.EventHandler(this.frmRegistrar_TextChanged);
            this.grpA.ResumeLayout(false);
            this.grpA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIntevalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIntervaloFim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcShowPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnModificar;
        public System.Windows.Forms.GroupBox grpA;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblCpf;
        public System.Windows.Forms.TextBox txtNomeFull;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtRegistrarSenha;
        public System.Windows.Forms.TextBox txtRegistarLogin;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lblAviso;
        public System.Windows.Forms.Label lblAidi;
        public System.Windows.Forms.TextBox txtAchaID;
        public System.Windows.Forms.MaskedTextBox txtTel;
        public System.Windows.Forms.MaskedTextBox mskCel;
        public System.Windows.Forms.MaskedTextBox txtCpf;
        public System.Windows.Forms.ErrorProvider epNome;
        public System.Windows.Forms.MaskedTextBox txtRg;
        public System.Windows.Forms.ErrorProvider epCell;
        public System.Windows.Forms.ErrorProvider epTel;
        public System.Windows.Forms.ErrorProvider epUser;
        public System.Windows.Forms.ErrorProvider epSenha;
        public System.Windows.Forms.ErrorProvider epCpf;
        public System.Windows.Forms.ErrorProvider epInicio;
        public System.Windows.Forms.ErrorProvider epFim;
        public System.Windows.Forms.ErrorProvider epIntevalo;
        private System.Windows.Forms.ErrorProvider epIntervaloFim;
        private System.Windows.Forms.Button btnEscala;
        private System.Windows.Forms.Label lblAvisoSenha;
        private System.Windows.Forms.PictureBox pcShowPass;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnPesquisa;
    }
}