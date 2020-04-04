namespace SegurSys
{
    partial class frmRotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRotas));
            this.txtAchaIDRonda = new System.Windows.Forms.TextBox();
            this.lblIdRondas = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbo1 = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl0_5 = new System.Windows.Forms.Label();
            this.cbo2 = new System.Windows.Forms.ComboBox();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDiaSemana = new System.Windows.Forms.ComboBox();
            this.ckDia = new System.Windows.Forms.CheckBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.grp = new System.Windows.Forms.GroupBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.ckSabado = new System.Windows.Forms.CheckBox();
            this.ckSexta = new System.Windows.Forms.CheckBox();
            this.ckQuarta = new System.Windows.Forms.CheckBox();
            this.ckTerca = new System.Windows.Forms.CheckBox();
            this.ckSegunda = new System.Windows.Forms.CheckBox();
            this.ckDomingo = new System.Windows.Forms.CheckBox();
            this.ckQuinta = new System.Windows.Forms.CheckBox();
            this.grpAplicar = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.mskTime = new System.Windows.Forms.MaskedTextBox();
            this.grp.SuspendLayout();
            this.grpAplicar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAchaIDRonda
            // 
            this.txtAchaIDRonda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAchaIDRonda.Location = new System.Drawing.Point(39, 12);
            this.txtAchaIDRonda.MaxLength = 100;
            this.txtAchaIDRonda.Name = "txtAchaIDRonda";
            this.txtAchaIDRonda.Size = new System.Drawing.Size(46, 21);
            this.txtAchaIDRonda.TabIndex = 0;
            this.txtAchaIDRonda.TextChanged += new System.EventHandler(this.txtAchaIDRonda_TextChanged);
            this.txtAchaIDRonda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAchaIDRonda_KeyPress);
            // 
            // lblIdRondas
            // 
            this.lblIdRondas.AutoSize = true;
            this.lblIdRondas.BackColor = System.Drawing.Color.Transparent;
            this.lblIdRondas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRondas.Location = new System.Drawing.Point(10, 14);
            this.lblIdRondas.Name = "lblIdRondas";
            this.lblIdRondas.Size = new System.Drawing.Size(24, 16);
            this.lblIdRondas.TabIndex = 1;
            this.lblIdRondas.Text = "ID:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(91, 10);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(79, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbo1
            // 
            this.cbo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo1.FormattingEnabled = true;
            this.cbo1.Items.AddRange(new object[] {
            ""});
            this.cbo1.Location = new System.Drawing.Point(54, 128);
            this.cbo1.Name = "cbo1";
            this.cbo1.Size = new System.Drawing.Size(84, 21);
            this.cbo1.TabIndex = 3;
            this.cbo1.SelectedIndexChanged += new System.EventHandler(this.cbo1_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(111, 17);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Rota de: \"nome\"";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(8, 130);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(46, 16);
            this.lbl.TabIndex = 5;
            this.lbl.Text = "Ponto:";
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.BackColor = System.Drawing.Color.Transparent;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.Location = new System.Drawing.Point(139, 130);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(24, 16);
            this.lbl0.TabIndex = 6;
            this.lbl0.Text = "ao";
            // 
            // lbl0_5
            // 
            this.lbl0_5.AutoSize = true;
            this.lbl0_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl0_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0_5.Location = new System.Drawing.Point(158, 131);
            this.lbl0_5.Name = "lbl0_5";
            this.lbl0_5.Size = new System.Drawing.Size(46, 16);
            this.lbl0_5.TabIndex = 7;
            this.lbl0_5.Text = "Ponto:";
            // 
            // cbo2
            // 
            this.cbo2.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "B",
            "C"});
            this.cbo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo2.FormattingEnabled = true;
            this.cbo2.Items.AddRange(new object[] {
            "",
            ""});
            this.cbo2.Location = new System.Drawing.Point(205, 129);
            this.cbo2.Name = "cbo2";
            this.cbo2.Size = new System.Drawing.Size(84, 21);
            this.cbo2.TabIndex = 8;
            this.cbo2.SelectedIndexChanged += new System.EventHandler(this.cbo2_SelectedIndexChanged);
            // 
            // btnMais
            // 
            this.btnMais.Image = ((System.Drawing.Image)(resources.GetObject("btnMais.Image")));
            this.btnMais.Location = new System.Drawing.Point(306, 122);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(31, 32);
            this.btnMais.TabIndex = 28;
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(628, 229);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 33);
            this.btnSalvar.TabIndex = 49;
            this.btnSalvar.Text = "&Gravar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(646, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 23);
            this.btnSair.TabIndex = 50;
            this.btnSair.Text = "&Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Dia da Semana:";
            // 
            // cboDiaSemana
            // 
            this.cboDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiaSemana.FormattingEnabled = true;
            this.cboDiaSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado"});
            this.cboDiaSemana.Location = new System.Drawing.Point(105, 73);
            this.cboDiaSemana.Name = "cboDiaSemana";
            this.cboDiaSemana.Size = new System.Drawing.Size(117, 21);
            this.cboDiaSemana.TabIndex = 59;
            this.cboDiaSemana.SelectedIndexChanged += new System.EventHandler(this.cboDiaSemana_SelectedIndexChanged);
            this.cboDiaSemana.TextChanged += new System.EventHandler(this.cboDiaSemana_TextChanged);
            // 
            // ckDia
            // 
            this.ckDia.AutoSize = true;
            this.ckDia.BackColor = System.Drawing.Color.Transparent;
            this.ckDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckDia.Location = new System.Drawing.Point(225, 74);
            this.ckDia.Name = "ckDia";
            this.ckDia.Size = new System.Drawing.Size(134, 19);
            this.ckDia.TabIndex = 58;
            this.ckDia.Text = "Trabalha Esse Dia?";
            this.ckDia.UseVisualStyleBackColor = false;
            this.ckDia.CheckedChanged += new System.EventHandler(this.ckDia_CheckedChanged);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(8, 102);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(272, 16);
            this.lblAviso.TabIndex = 61;
            this.lblAviso.Text = "Esse Funcionário não tem Ronda para \"Dia\"";
            // 
            // grp
            // 
            this.grp.BackColor = System.Drawing.Color.Transparent;
            this.grp.Controls.Add(this.txtCaminho);
            this.grp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp.ForeColor = System.Drawing.Color.Black;
            this.grp.Location = new System.Drawing.Point(398, 29);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(328, 189);
            this.grp.TabIndex = 62;
            this.grp.TabStop = false;
            this.grp.Text = "Rota";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Enabled = false;
            this.txtCaminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminho.Location = new System.Drawing.Point(6, 19);
            this.txtCaminho.Multiline = true;
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(316, 164);
            this.txtCaminho.TabIndex = 0;
            this.txtCaminho.TextChanged += new System.EventHandler(this.txtCaminho_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(274, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 23);
            this.btnBack.TabIndex = 64;
            this.btnBack.Text = "&Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenos.BackgroundImage")));
            this.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenos.Location = new System.Drawing.Point(352, 121);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(31, 32);
            this.btnMenos.TabIndex = 65;
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // ckSabado
            // 
            this.ckSabado.AutoSize = true;
            this.ckSabado.BackColor = System.Drawing.Color.Transparent;
            this.ckSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSabado.Location = new System.Drawing.Point(242, 194);
            this.ckSabado.Name = "ckSabado";
            this.ckSabado.Size = new System.Drawing.Size(76, 21);
            this.ckSabado.TabIndex = 66;
            this.ckSabado.Text = "Sábado";
            this.ckSabado.UseVisualStyleBackColor = false;
            this.ckSabado.Visible = false;
            // 
            // ckSexta
            // 
            this.ckSexta.AutoSize = true;
            this.ckSexta.BackColor = System.Drawing.Color.Transparent;
            this.ckSexta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSexta.Location = new System.Drawing.Point(180, 194);
            this.ckSexta.Name = "ckSexta";
            this.ckSexta.Size = new System.Drawing.Size(62, 21);
            this.ckSexta.TabIndex = 67;
            this.ckSexta.Text = "Sexta";
            this.ckSexta.UseVisualStyleBackColor = false;
            this.ckSexta.Visible = false;
            // 
            // ckQuarta
            // 
            this.ckQuarta.AutoSize = true;
            this.ckQuarta.BackColor = System.Drawing.Color.Transparent;
            this.ckQuarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckQuarta.Location = new System.Drawing.Point(106, 194);
            this.ckQuarta.Name = "ckQuarta";
            this.ckQuarta.Size = new System.Drawing.Size(71, 21);
            this.ckQuarta.TabIndex = 69;
            this.ckQuarta.Text = "Quarta";
            this.ckQuarta.UseVisualStyleBackColor = false;
            this.ckQuarta.Visible = false;
            // 
            // ckTerca
            // 
            this.ckTerca.AutoSize = true;
            this.ckTerca.BackColor = System.Drawing.Color.Transparent;
            this.ckTerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTerca.Location = new System.Drawing.Point(106, 216);
            this.ckTerca.Name = "ckTerca";
            this.ckTerca.Size = new System.Drawing.Size(64, 21);
            this.ckTerca.TabIndex = 68;
            this.ckTerca.Text = "Terça";
            this.ckTerca.UseVisualStyleBackColor = false;
            this.ckTerca.Visible = false;
            // 
            // ckSegunda
            // 
            this.ckSegunda.AutoSize = true;
            this.ckSegunda.BackColor = System.Drawing.Color.Transparent;
            this.ckSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSegunda.Location = new System.Drawing.Point(17, 194);
            this.ckSegunda.Name = "ckSegunda";
            this.ckSegunda.Size = new System.Drawing.Size(84, 21);
            this.ckSegunda.TabIndex = 71;
            this.ckSegunda.Text = "Segunda";
            this.ckSegunda.UseVisualStyleBackColor = false;
            this.ckSegunda.Visible = false;
            // 
            // ckDomingo
            // 
            this.ckDomingo.AutoSize = true;
            this.ckDomingo.BackColor = System.Drawing.Color.Transparent;
            this.ckDomingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckDomingo.Location = new System.Drawing.Point(7, 56);
            this.ckDomingo.Name = "ckDomingo";
            this.ckDomingo.Size = new System.Drawing.Size(83, 21);
            this.ckDomingo.TabIndex = 70;
            this.ckDomingo.Text = "Domingo";
            this.ckDomingo.UseVisualStyleBackColor = false;
            this.ckDomingo.Visible = false;
            // 
            // ckQuinta
            // 
            this.ckQuinta.AutoSize = true;
            this.ckQuinta.BackColor = System.Drawing.Color.Transparent;
            this.ckQuinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckQuinta.Location = new System.Drawing.Point(180, 217);
            this.ckQuinta.Name = "ckQuinta";
            this.ckQuinta.Size = new System.Drawing.Size(69, 21);
            this.ckQuinta.TabIndex = 72;
            this.ckQuinta.Text = "Quinta";
            this.ckQuinta.UseVisualStyleBackColor = false;
            this.ckQuinta.Visible = false;
            // 
            // grpAplicar
            // 
            this.grpAplicar.BackColor = System.Drawing.Color.Transparent;
            this.grpAplicar.Controls.Add(this.ckDomingo);
            this.grpAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAplicar.Location = new System.Drawing.Point(11, 160);
            this.grpAplicar.Name = "grpAplicar";
            this.grpAplicar.Size = new System.Drawing.Size(308, 91);
            this.grpAplicar.TabIndex = 73;
            this.grpAplicar.TabStop = false;
            this.grpAplicar.Text = "Aplicar Também Para:";
            this.grpAplicar.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(400, 229);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(148, 16);
            this.lblTime.TabIndex = 74;
            this.lblTime.Text = "Tempo em cada ponto:";
            this.lblTime.Visible = false;
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "00:05",
            "00:10",
            "00:15",
            "00:20",
            "00:25",
            "00:30",
            "00:45",
            "01:00",
            "01:30",
            "02:00",
            "03:00"});
            this.cboTime.Location = new System.Drawing.Point(547, 227);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(57, 21);
            this.cboTime.TabIndex = 75;
            this.cboTime.Visible = false;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            // 
            // mskTime
            // 
            this.mskTime.Enabled = false;
            this.mskTime.Location = new System.Drawing.Point(548, 228);
            this.mskTime.Mask = "00:00";
            this.mskTime.Name = "mskTime";
            this.mskTime.Size = new System.Drawing.Size(41, 20);
            this.mskTime.TabIndex = 76;
            this.mskTime.ValidatingType = typeof(System.DateTime);
            this.mskTime.Visible = false;
            // 
            // frmRotas
            // 
            this.AcceptButton = this.btnMais;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(738, 274);
            this.Controls.Add(this.mskTime);
            this.Controls.Add(this.cboTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.cboDiaSemana);
            this.Controls.Add(this.ckQuinta);
            this.Controls.Add(this.ckSegunda);
            this.Controls.Add(this.ckQuarta);
            this.Controls.Add(this.ckTerca);
            this.Controls.Add(this.ckSexta);
            this.Controls.Add(this.ckSabado);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckDia);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.cbo2);
            this.Controls.Add(this.lbl0_5);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbo1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblIdRondas);
            this.Controls.Add(this.txtAchaIDRonda);
            this.Controls.Add(this.grpAplicar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRotas";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rondas";
            this.Activated += new System.EventHandler(this.frmRotas_Activated);
            this.Load += new System.EventHandler(this.frmRotas_Load);
            this.Shown += new System.EventHandler(this.frmRotas_Shown);
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.grpAplicar.ResumeLayout(false);
            this.grpAplicar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtAchaIDRonda;
        public System.Windows.Forms.Label lblIdRondas;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.ComboBox cbo1;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.Label lbl0;
        public System.Windows.Forms.Label lbl0_5;
        public System.Windows.Forms.ComboBox cbo2;
        public System.Windows.Forms.Button btnMais;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cboDiaSemana;
        public System.Windows.Forms.CheckBox ckDia;
        public System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.GroupBox grp;
        public System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtCaminho;
        public System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.CheckBox ckSabado;
        private System.Windows.Forms.CheckBox ckSexta;
        private System.Windows.Forms.CheckBox ckQuarta;
        private System.Windows.Forms.CheckBox ckTerca;
        private System.Windows.Forms.CheckBox ckSegunda;
        private System.Windows.Forms.CheckBox ckDomingo;
        private System.Windows.Forms.CheckBox ckQuinta;
        private System.Windows.Forms.GroupBox grpAplicar;
        private System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.ComboBox cboTime;
        public System.Windows.Forms.MaskedTextBox mskTime;
    }
}