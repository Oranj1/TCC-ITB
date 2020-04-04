namespace SegurSys
{
    partial class frmRegistrarOcorrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarOcorrencia));
            this.txtFazerOcorrencia = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.mskDataOcorrido = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskBeginOcorrido = new System.Windows.Forms.MaskedTextBox();
            this.mskEndOcorrido = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btnOcorrencia = new System.Windows.Forms.Button();
            this.btnSaidai = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNivel = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblDataRe = new System.Windows.Forms.Label();
            this.mskDataRe = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraRe = new System.Windows.Forms.Label();
            this.mskHoraRe = new System.Windows.Forms.MaskedTextBox();
            this.txtPonto = new System.Windows.Forms.TextBox();
            this.epData = new System.Windows.Forms.ErrorProvider(this.components);
            this.epIniOco = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFimOco = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cboFunc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtPor = new System.Windows.Forms.TextBox();
            this.cboBegin = new System.Windows.Forms.ComboBox();
            this.cboEnd = new System.Windows.Forms.ComboBox();
            this.btnAbrirCalendario = new System.Windows.Forms.Button();
            this.mcCalendario = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.epData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIniOco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFimOco)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFazerOcorrencia
            // 
            this.txtFazerOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFazerOcorrencia.Location = new System.Drawing.Point(12, 39);
            this.txtFazerOcorrencia.Multiline = true;
            this.txtFazerOcorrencia.Name = "txtFazerOcorrencia";
            this.txtFazerOcorrencia.Size = new System.Drawing.Size(780, 280);
            this.txtFazerOcorrencia.TabIndex = 0;
            this.txtFazerOcorrencia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 18);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Digite a Ocorrência:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(6, 331);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(45, 16);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data:*";
            // 
            // mskDataOcorrido
            // 
            this.mskDataOcorrido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataOcorrido.Location = new System.Drawing.Point(49, 329);
            this.mskDataOcorrido.Mask = "00/00/0000";
            this.mskDataOcorrido.Name = "mskDataOcorrido";
            this.mskDataOcorrido.Size = new System.Drawing.Size(64, 20);
            this.mskDataOcorrido.TabIndex = 3;
            this.mskDataOcorrido.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskDataOcorrido.ValidatingType = typeof(System.DateTime);
            this.mskDataOcorrido.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDataOcorrido_MaskInputRejected);
            this.mskDataOcorrido.TextChanged += new System.EventHandler(this.mskDataOcorrido_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Horario do Começo:*";
            // 
            // mskBeginOcorrido
            // 
            this.mskBeginOcorrido.Location = new System.Drawing.Point(277, 328);
            this.mskBeginOcorrido.Mask = "00:00";
            this.mskBeginOcorrido.Name = "mskBeginOcorrido";
            this.mskBeginOcorrido.Size = new System.Drawing.Size(34, 20);
            this.mskBeginOcorrido.TabIndex = 5;
            this.mskBeginOcorrido.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskBeginOcorrido.ValidatingType = typeof(System.DateTime);
            this.mskBeginOcorrido.TextChanged += new System.EventHandler(this.mskBeginOcorrido_TextChanged);
            // 
            // mskEndOcorrido
            // 
            this.mskEndOcorrido.Location = new System.Drawing.Point(484, 328);
            this.mskEndOcorrido.Mask = "00:00";
            this.mskEndOcorrido.Name = "mskEndOcorrido";
            this.mskEndOcorrido.Size = new System.Drawing.Size(34, 20);
            this.mskEndOcorrido.TabIndex = 7;
            this.mskEndOcorrido.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskEndOcorrido.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(370, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Horario do Fim:";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Black;
            this.lblAviso.Location = new System.Drawing.Point(9, 443);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(311, 15);
            this.lblAviso.TabIndex = 21;
            this.lblAviso.Text = "Todos os campos com * tem preenchimento obrigatório";
            // 
            // btnOcorrencia
            // 
            this.btnOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcorrencia.Location = new System.Drawing.Point(664, 411);
            this.btnOcorrencia.Name = "btnOcorrencia";
            this.btnOcorrencia.Size = new System.Drawing.Size(128, 47);
            this.btnOcorrencia.TabIndex = 22;
            this.btnOcorrencia.Text = "Registrar &Ocorrência";
            this.btnOcorrencia.UseVisualStyleBackColor = true;
            this.btnOcorrencia.Click += new System.EventHandler(this.btnOcorrencia_Click);
            // 
            // btnSaidai
            // 
            this.btnSaidai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaidai.ForeColor = System.Drawing.Color.Red;
            this.btnSaidai.Location = new System.Drawing.Point(724, 4);
            this.btnSaidai.Name = "btnSaidai";
            this.btnSaidai.Size = new System.Drawing.Size(68, 23);
            this.btnSaidai.TabIndex = 23;
            this.btnSaidai.Text = "&Voltar";
            this.btnSaidai.UseVisualStyleBackColor = true;
            this.btnSaidai.Click += new System.EventHandler(this.btnSaidai_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nivel da Ocorrência:*";
            // 
            // cboNivel
            // 
            this.cboNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNivel.FormattingEnabled = true;
            this.cboNivel.Items.AddRange(new object[] {
            "Alto",
            "Médio",
            "Baixo"});
            this.cboNivel.Location = new System.Drawing.Point(712, 327);
            this.cboNivel.Name = "cboNivel";
            this.cboNivel.Size = new System.Drawing.Size(80, 23);
            this.cboNivel.TabIndex = 25;
            this.cboNivel.SelectedIndexChanged += new System.EventHandler(this.cboNivel_SelectedIndexChanged);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.BackColor = System.Drawing.Color.Transparent;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(3, 364);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(141, 17);
            this.lblArea.TabIndex = 26;
            this.lblArea.Text = "Area da Ocorrência:*";
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(147, 360);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(126, 21);
            this.cboArea.TabIndex = 27;
            // 
            // lblDataRe
            // 
            this.lblDataRe.AutoSize = true;
            this.lblDataRe.BackColor = System.Drawing.Color.Transparent;
            this.lblDataRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataRe.Location = new System.Drawing.Point(2, 399);
            this.lblDataRe.Name = "lblDataRe";
            this.lblDataRe.Size = new System.Drawing.Size(113, 16);
            this.lblDataRe.TabIndex = 28;
            this.lblDataRe.Text = "Data de Registro:";
            this.lblDataRe.Visible = false;
            // 
            // mskDataRe
            // 
            this.mskDataRe.Enabled = false;
            this.mskDataRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataRe.Location = new System.Drawing.Point(113, 398);
            this.mskDataRe.Mask = "00/00/0000";
            this.mskDataRe.Name = "mskDataRe";
            this.mskDataRe.Size = new System.Drawing.Size(64, 20);
            this.mskDataRe.TabIndex = 29;
            this.mskDataRe.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskDataRe.ValidatingType = typeof(System.DateTime);
            this.mskDataRe.Visible = false;
            // 
            // lblHoraRe
            // 
            this.lblHoraRe.AutoSize = true;
            this.lblHoraRe.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraRe.Location = new System.Drawing.Point(179, 400);
            this.lblHoraRe.Name = "lblHoraRe";
            this.lblHoraRe.Size = new System.Drawing.Size(129, 16);
            this.lblHoraRe.TabIndex = 30;
            this.lblHoraRe.Text = "Horario de Registro:";
            this.lblHoraRe.Visible = false;
            // 
            // mskHoraRe
            // 
            this.mskHoraRe.Enabled = false;
            this.mskHoraRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskHoraRe.Location = new System.Drawing.Point(309, 397);
            this.mskHoraRe.Mask = "00:00";
            this.mskHoraRe.Name = "mskHoraRe";
            this.mskHoraRe.Size = new System.Drawing.Size(39, 20);
            this.mskHoraRe.TabIndex = 31;
            this.mskHoraRe.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskHoraRe.ValidatingType = typeof(System.DateTime);
            this.mskHoraRe.Visible = false;
            // 
            // txtPonto
            // 
            this.txtPonto.Enabled = false;
            this.txtPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPonto.Location = new System.Drawing.Point(147, 363);
            this.txtPonto.Name = "txtPonto";
            this.txtPonto.Size = new System.Drawing.Size(126, 21);
            this.txtPonto.TabIndex = 32;
            this.txtPonto.Visible = false;
            // 
            // epData
            // 
            this.epData.ContainerControl = this;
            // 
            // epIniOco
            // 
            this.epIniOco.ContainerControl = this;
            // 
            // epFimOco
            // 
            this.epFimOco.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Visto Por:";
            // 
            // cboFunc
            // 
            this.cboFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunc.FormattingEnabled = true;
            this.cboFunc.Location = new System.Drawing.Point(344, 361);
            this.cboFunc.Name = "cboFunc";
            this.cboFunc.Size = new System.Drawing.Size(206, 21);
            this.cboFunc.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Status:*";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Solucionado",
            "Em Aberto",
            "Encaminhado para a Policia"});
            this.cboStatus.Location = new System.Drawing.Point(608, 362);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(184, 23);
            this.cboStatus.TabIndex = 36;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // txtPor
            // 
            this.txtPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPor.Location = new System.Drawing.Point(344, 362);
            this.txtPor.Name = "txtPor";
            this.txtPor.Size = new System.Drawing.Size(206, 21);
            this.txtPor.TabIndex = 37;
            this.txtPor.Visible = false;
            // 
            // cboBegin
            // 
            this.cboBegin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBegin.FormattingEnabled = true;
            this.cboBegin.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.cboBegin.Location = new System.Drawing.Point(274, 328);
            this.cboBegin.Name = "cboBegin";
            this.cboBegin.Size = new System.Drawing.Size(57, 21);
            this.cboBegin.TabIndex = 38;
            this.cboBegin.SelectedIndexChanged += new System.EventHandler(this.cboBegin_SelectedIndexChanged);
            // 
            // cboEnd
            // 
            this.cboEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEnd.FormattingEnabled = true;
            this.cboEnd.Items.AddRange(new object[] {
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30",
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30"});
            this.cboEnd.Location = new System.Drawing.Point(481, 328);
            this.cboEnd.Name = "cboEnd";
            this.cboEnd.Size = new System.Drawing.Size(57, 21);
            this.cboEnd.TabIndex = 39;
            this.cboEnd.SelectedIndexChanged += new System.EventHandler(this.cboEnd_SelectedIndexChanged);
            // 
            // btnAbrirCalendario
            // 
            this.btnAbrirCalendario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbrirCalendario.BackgroundImage")));
            this.btnAbrirCalendario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrirCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbrirCalendario.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirCalendario.Image")));
            this.btnAbrirCalendario.Location = new System.Drawing.Point(114, 329);
            this.btnAbrirCalendario.Name = "btnAbrirCalendario";
            this.btnAbrirCalendario.Size = new System.Drawing.Size(22, 20);
            this.btnAbrirCalendario.TabIndex = 40;
            this.btnAbrirCalendario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirCalendario.UseVisualStyleBackColor = true;
            this.btnAbrirCalendario.Click += new System.EventHandler(this.btnAbrirCalendario_Click);
            this.btnAbrirCalendario.Leave += new System.EventHandler(this.btnAbrirCalendario_Leave);
            // 
            // mcCalendario
            // 
            this.mcCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcCalendario.Location = new System.Drawing.Point(136, 309);
            this.mcCalendario.Name = "mcCalendario";
            this.mcCalendario.TabIndex = 41;
            this.mcCalendario.Visible = false;
            this.mcCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcCalendario_DateChanged);
            this.mcCalendario.Leave += new System.EventHandler(this.mcCalendario_Leave);
            // 
            // frmRegistrarOcorrencia
            // 
            this.AcceptButton = this.btnOcorrencia;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 470);
            this.Controls.Add(this.mcCalendario);
            this.Controls.Add(this.btnAbrirCalendario);
            this.Controls.Add(this.cboEnd);
            this.Controls.Add(this.cboBegin);
            this.Controls.Add(this.txtPor);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboFunc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPonto);
            this.Controls.Add(this.mskHoraRe);
            this.Controls.Add(this.lblHoraRe);
            this.Controls.Add(this.mskDataRe);
            this.Controls.Add(this.lblDataRe);
            this.Controls.Add(this.cboArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.cboNivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSaidai);
            this.Controls.Add(this.btnOcorrencia);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.mskEndOcorrido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskBeginOcorrido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskDataOcorrido);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtFazerOcorrencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegistrarOcorrencia";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Ocorrência";
            this.Load += new System.EventHandler(this.frmRegistrarOcorrencia_Load);
            this.Click += new System.EventHandler(this.frmRegistrarOcorrencia_Click);
            ((System.ComponentModel.ISupportInitialize)(this.epData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIniOco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFimOco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtFazerOcorrencia;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblData;
        public System.Windows.Forms.MaskedTextBox mskDataOcorrido;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox mskBeginOcorrido;
        public System.Windows.Forms.MaskedTextBox mskEndOcorrido;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblAviso;
        public System.Windows.Forms.Button btnOcorrencia;
        public System.Windows.Forms.Button btnSaidai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblArea;
        public System.Windows.Forms.MaskedTextBox mskDataRe;
        public System.Windows.Forms.MaskedTextBox mskHoraRe;
        public System.Windows.Forms.ComboBox cboNivel;
        public System.Windows.Forms.ComboBox cboArea;
        public System.Windows.Forms.Label lblHoraRe;
        public System.Windows.Forms.Label lblDataRe;
        public System.Windows.Forms.TextBox txtPonto;
        private System.Windows.Forms.ErrorProvider epData;
        private System.Windows.Forms.ErrorProvider epIniOco;
        private System.Windows.Forms.ErrorProvider epFimOco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPor;
        public System.Windows.Forms.ComboBox cboStatus;
        public System.Windows.Forms.ComboBox cboFunc;
        public System.Windows.Forms.ComboBox cboBegin;
        public System.Windows.Forms.ComboBox cboEnd;
        private System.Windows.Forms.MonthCalendar mcCalendario;
        public System.Windows.Forms.Button btnAbrirCalendario;
    }
}