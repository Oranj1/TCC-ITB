namespace SegurSys
{
    partial class frmEscala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscala));
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblAidi = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.ckDia = new System.Windows.Forms.CheckBox();
            this.cboDiaSemana = new System.Windows.Forms.ComboBox();
            this.grpB = new System.Windows.Forms.GroupBox();
            this.cboIntervalEnd = new System.Windows.Forms.ComboBox();
            this.cboInterval = new System.Windows.Forms.ComboBox();
            this.cboEnd = new System.Windows.Forms.ComboBox();
            this.cboBegin = new System.Windows.Forms.ComboBox();
            this.mskIntervalEnd = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskIntervalBegin = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mskEnd = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskBegin = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAbreRonda = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.epInicio = new System.Windows.Forms.ErrorProvider(this.components);
            this.epFim = new System.Windows.Forms.ErrorProvider(this.components);
            this.epIntevalo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epIntervaloFim = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ckDomingo = new System.Windows.Forms.CheckBox();
            this.ckSexta = new System.Windows.Forms.CheckBox();
            this.ckQuinta = new System.Windows.Forms.CheckBox();
            this.ckQuarta = new System.Windows.Forms.CheckBox();
            this.ckTerca = new System.Windows.Forms.CheckBox();
            this.ckSegunda = new System.Windows.Forms.CheckBox();
            this.ckSabado = new System.Windows.Forms.CheckBox();
            this.grpB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIntevalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIntervaloFim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(39, 12);
            this.txtId.MaxLength = 100;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(81, 20);
            this.txtId.TabIndex = 0;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // lblAidi
            // 
            this.lblAidi.AutoSize = true;
            this.lblAidi.BackColor = System.Drawing.Color.Transparent;
            this.lblAidi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAidi.Location = new System.Drawing.Point(12, 15);
            this.lblAidi.Name = "lblAidi";
            this.lblAidi.Size = new System.Drawing.Size(24, 16);
            this.lblAidi.TabIndex = 1;
            this.lblAidi.Text = "ID:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(124, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(81, 30);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // ckDia
            // 
            this.ckDia.AutoSize = true;
            this.ckDia.BackColor = System.Drawing.Color.Transparent;
            this.ckDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckDia.Location = new System.Drawing.Point(252, 78);
            this.ckDia.Name = "ckDia";
            this.ckDia.Size = new System.Drawing.Size(147, 20);
            this.ckDia.TabIndex = 3;
            this.ckDia.Text = "Trabalha Esse Dia?";
            this.ckDia.UseVisualStyleBackColor = false;
            this.ckDia.CheckedChanged += new System.EventHandler(this.ckDia_CheckedChanged);
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
            this.cboDiaSemana.Location = new System.Drawing.Point(123, 78);
            this.cboDiaSemana.Name = "cboDiaSemana";
            this.cboDiaSemana.Size = new System.Drawing.Size(121, 21);
            this.cboDiaSemana.TabIndex = 4;
            this.cboDiaSemana.DropDown += new System.EventHandler(this.cboDiaSemana_DropDown);
            this.cboDiaSemana.SelectedIndexChanged += new System.EventHandler(this.cboDiaSemana_SelectedIndexChanged);
            this.cboDiaSemana.TextChanged += new System.EventHandler(this.cboDiaSemana_TextChanged);
            this.cboDiaSemana.Click += new System.EventHandler(this.cboDiaSemana_Click);
            // 
            // grpB
            // 
            this.grpB.BackColor = System.Drawing.Color.Transparent;
            this.grpB.Controls.Add(this.cboIntervalEnd);
            this.grpB.Controls.Add(this.cboInterval);
            this.grpB.Controls.Add(this.cboEnd);
            this.grpB.Controls.Add(this.cboBegin);
            this.grpB.Controls.Add(this.mskIntervalEnd);
            this.grpB.Controls.Add(this.label7);
            this.grpB.Controls.Add(this.mskIntervalBegin);
            this.grpB.Controls.Add(this.label8);
            this.grpB.Controls.Add(this.mskEnd);
            this.grpB.Controls.Add(this.label6);
            this.grpB.Controls.Add(this.mskBegin);
            this.grpB.Controls.Add(this.label5);
            this.grpB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpB.Location = new System.Drawing.Point(15, 188);
            this.grpB.Name = "grpB";
            this.grpB.Size = new System.Drawing.Size(431, 127);
            this.grpB.TabIndex = 5;
            this.grpB.TabStop = false;
            this.grpB.Text = "Dados de Turno:";
            // 
            // cboIntervalEnd
            // 
            this.cboIntervalEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIntervalEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboIntervalEnd.FormattingEnabled = true;
            this.cboIntervalEnd.Items.AddRange(new object[] {
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
            this.cboIntervalEnd.Location = new System.Drawing.Point(330, 67);
            this.cboIntervalEnd.Name = "cboIntervalEnd";
            this.cboIntervalEnd.Size = new System.Drawing.Size(57, 25);
            this.cboIntervalEnd.TabIndex = 19;
            this.cboIntervalEnd.SelectedIndexChanged += new System.EventHandler(this.cboIntervalEnd_SelectedIndexChanged);
            // 
            // cboInterval
            // 
            this.cboInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInterval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboInterval.FormattingEnabled = true;
            this.cboInterval.Items.AddRange(new object[] {
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
            this.cboInterval.Location = new System.Drawing.Point(133, 67);
            this.cboInterval.Name = "cboInterval";
            this.cboInterval.Size = new System.Drawing.Size(57, 25);
            this.cboInterval.TabIndex = 18;
            this.cboInterval.SelectedIndexChanged += new System.EventHandler(this.cboInterval_SelectedIndexChanged);
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
            this.cboEnd.Location = new System.Drawing.Point(305, 27);
            this.cboEnd.Name = "cboEnd";
            this.cboEnd.Size = new System.Drawing.Size(57, 25);
            this.cboEnd.TabIndex = 17;
            this.cboEnd.SelectedIndexChanged += new System.EventHandler(this.cboEnd_SelectedIndexChanged);
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
            this.cboBegin.Location = new System.Drawing.Point(119, 27);
            this.cboBegin.Name = "cboBegin";
            this.cboBegin.Size = new System.Drawing.Size(57, 25);
            this.cboBegin.TabIndex = 3;
            this.cboBegin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mskIntervalEnd
            // 
            this.mskIntervalEnd.Location = new System.Drawing.Point(331, 68);
            this.mskIntervalEnd.Mask = "00:00";
            this.mskIntervalEnd.Name = "mskIntervalEnd";
            this.mskIntervalEnd.Size = new System.Drawing.Size(41, 24);
            this.mskIntervalEnd.TabIndex = 10;
            this.mskIntervalEnd.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskIntervalEnd.ValidatingType = typeof(System.DateTime);
            this.mskIntervalEnd.TextChanged += new System.EventHandler(this.mskIntervalEnd_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fim do Intervalo: ";
            // 
            // mskIntervalBegin
            // 
            this.mskIntervalBegin.Location = new System.Drawing.Point(134, 68);
            this.mskIntervalBegin.Mask = "00:00";
            this.mskIntervalBegin.Name = "mskIntervalBegin";
            this.mskIntervalBegin.Size = new System.Drawing.Size(41, 24);
            this.mskIntervalBegin.TabIndex = 9;
            this.mskIntervalBegin.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskIntervalBegin.ValidatingType = typeof(System.DateTime);
            this.mskIntervalBegin.TextChanged += new System.EventHandler(this.mskIntervalBegin_TextChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Inicio do Intervalo: ";
            // 
            // mskEnd
            // 
            this.mskEnd.Location = new System.Drawing.Point(306, 28);
            this.mskEnd.Mask = "00:00";
            this.mskEnd.Name = "mskEnd";
            this.mskEnd.Size = new System.Drawing.Size(41, 24);
            this.mskEnd.TabIndex = 8;
            this.mskEnd.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskEnd.ValidatingType = typeof(System.DateTime);
            this.mskEnd.TextChanged += new System.EventHandler(this.mskEnd_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(203, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fim do Turno: ";
            // 
            // mskBegin
            // 
            this.mskBegin.Location = new System.Drawing.Point(120, 28);
            this.mskBegin.Mask = "00:00";
            this.mskBegin.Name = "mskBegin";
            this.mskBegin.Size = new System.Drawing.Size(41, 24);
            this.mskBegin.TabIndex = 7;
            this.mskBegin.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskBegin.ValidatingType = typeof(System.DateTime);
            this.mskBegin.TextChanged += new System.EventHandler(this.mskBegin_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Inicio do Turno: ";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.Red;
            this.btnQuitar.Location = new System.Drawing.Point(590, 7);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 52;
            this.btnQuitar.Text = "&Voltar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 53;
            this.label2.Text = "Dia da Semana:";
            // 
            // btnAbreRonda
            // 
            this.btnAbreRonda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbreRonda.Location = new System.Drawing.Point(12, 341);
            this.btnAbreRonda.Name = "btnAbreRonda";
            this.btnAbreRonda.Size = new System.Drawing.Size(136, 30);
            this.btnAbreRonda.TabIndex = 17;
            this.btnAbreRonda.Text = "&Ronda Nesse Dia";
            this.btnAbreRonda.UseVisualStyleBackColor = true;
            this.btnAbreRonda.Click += new System.EventHandler(this.btnAbreRonda_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(566, 370);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(94, 33);
            this.btnGravar.TabIndex = 54;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.Color.Transparent;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Black;
            this.lblAviso.Location = new System.Drawing.Point(9, 388);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(276, 15);
            this.lblAviso.TabIndex = 55;
            this.lblAviso.Text = "Todos os campos tem preenchimento obrigatório";
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
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(6, 48);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(84, 18);
            this.lblUsuario.TabIndex = 56;
            this.lblUsuario.Text = "Escala De: ";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.ForeColor = System.Drawing.Color.Red;
            this.lblDia.Location = new System.Drawing.Point(12, 163);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(269, 18);
            this.lblDia.TabIndex = 57;
            this.lblDia.Text = "Esse usúario não tem escala para \"Dia\"";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 113);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 17);
            this.lblTitle.TabIndex = 58;
            this.lblTitle.Text = "Aplicar também para:";
            this.lblTitle.Visible = false;
            // 
            // ckDomingo
            // 
            this.ckDomingo.AutoSize = true;
            this.ckDomingo.BackColor = System.Drawing.Color.Transparent;
            this.ckDomingo.Enabled = false;
            this.ckDomingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckDomingo.Location = new System.Drawing.Point(152, 112);
            this.ckDomingo.Name = "ckDomingo";
            this.ckDomingo.Size = new System.Drawing.Size(83, 21);
            this.ckDomingo.TabIndex = 59;
            this.ckDomingo.Text = "Domingo";
            this.ckDomingo.UseVisualStyleBackColor = false;
            this.ckDomingo.Visible = false;
            // 
            // ckSexta
            // 
            this.ckSexta.AutoSize = true;
            this.ckSexta.BackColor = System.Drawing.Color.Transparent;
            this.ckSexta.Enabled = false;
            this.ckSexta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSexta.Location = new System.Drawing.Point(531, 113);
            this.ckSexta.Name = "ckSexta";
            this.ckSexta.Size = new System.Drawing.Size(62, 21);
            this.ckSexta.TabIndex = 60;
            this.ckSexta.Text = "Sexta";
            this.ckSexta.UseVisualStyleBackColor = false;
            this.ckSexta.Visible = false;
            // 
            // ckQuinta
            // 
            this.ckQuinta.AutoSize = true;
            this.ckQuinta.BackColor = System.Drawing.Color.Transparent;
            this.ckQuinta.Enabled = false;
            this.ckQuinta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckQuinta.Location = new System.Drawing.Point(459, 113);
            this.ckQuinta.Name = "ckQuinta";
            this.ckQuinta.Size = new System.Drawing.Size(69, 21);
            this.ckQuinta.TabIndex = 61;
            this.ckQuinta.Text = "Quinta";
            this.ckQuinta.UseVisualStyleBackColor = false;
            this.ckQuinta.Visible = false;
            // 
            // ckQuarta
            // 
            this.ckQuarta.AutoSize = true;
            this.ckQuarta.BackColor = System.Drawing.Color.Transparent;
            this.ckQuarta.Enabled = false;
            this.ckQuarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckQuarta.Location = new System.Drawing.Point(385, 113);
            this.ckQuarta.Name = "ckQuarta";
            this.ckQuarta.Size = new System.Drawing.Size(71, 21);
            this.ckQuarta.TabIndex = 62;
            this.ckQuarta.Text = "Quarta";
            this.ckQuarta.UseVisualStyleBackColor = false;
            this.ckQuarta.Visible = false;
            // 
            // ckTerca
            // 
            this.ckTerca.AutoSize = true;
            this.ckTerca.BackColor = System.Drawing.Color.Transparent;
            this.ckTerca.Enabled = false;
            this.ckTerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckTerca.Location = new System.Drawing.Point(320, 113);
            this.ckTerca.Name = "ckTerca";
            this.ckTerca.Size = new System.Drawing.Size(64, 21);
            this.ckTerca.TabIndex = 63;
            this.ckTerca.Text = "Terça";
            this.ckTerca.UseVisualStyleBackColor = false;
            this.ckTerca.Visible = false;
            // 
            // ckSegunda
            // 
            this.ckSegunda.AutoSize = true;
            this.ckSegunda.BackColor = System.Drawing.Color.Transparent;
            this.ckSegunda.Enabled = false;
            this.ckSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSegunda.Location = new System.Drawing.Point(235, 113);
            this.ckSegunda.Name = "ckSegunda";
            this.ckSegunda.Size = new System.Drawing.Size(84, 21);
            this.ckSegunda.TabIndex = 64;
            this.ckSegunda.Text = "Segunda";
            this.ckSegunda.UseVisualStyleBackColor = false;
            this.ckSegunda.Visible = false;
            // 
            // ckSabado
            // 
            this.ckSabado.AutoSize = true;
            this.ckSabado.BackColor = System.Drawing.Color.Transparent;
            this.ckSabado.Enabled = false;
            this.ckSabado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSabado.Location = new System.Drawing.Point(595, 113);
            this.ckSabado.Name = "ckSabado";
            this.ckSabado.Size = new System.Drawing.Size(76, 21);
            this.ckSabado.TabIndex = 65;
            this.ckSabado.Text = "Sábado";
            this.ckSabado.UseVisualStyleBackColor = false;
            this.ckSabado.Visible = false;
            // 
            // frmEscala
            // 
            this.AcceptButton = this.btnGravar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(672, 415);
            this.Controls.Add(this.ckSabado);
            this.Controls.Add(this.ckSegunda);
            this.Controls.Add(this.ckTerca);
            this.Controls.Add(this.ckQuarta);
            this.Controls.Add(this.ckQuinta);
            this.Controls.Add(this.ckSexta);
            this.Controls.Add(this.ckDomingo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnAbreRonda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.grpB);
            this.Controls.Add(this.cboDiaSemana);
            this.Controls.Add(this.ckDia);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblAidi);
            this.Controls.Add(this.txtId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEscala";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escala";
            this.Load += new System.EventHandler(this.frmEscala_Load);
            this.grpB.ResumeLayout(false);
            this.grpB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIntevalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epIntervaloFim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.GroupBox grpB;
        public System.Windows.Forms.MaskedTextBox mskIntervalEnd;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox mskIntervalBegin;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.MaskedTextBox mskEnd;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox mskBegin;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblAviso;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.Label lblAidi;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.CheckBox ckDia;
        public System.Windows.Forms.ComboBox cboDiaSemana;
        public System.Windows.Forms.Button btnQuitar;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnAbreRonda;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.ErrorProvider epInicio;
        public System.Windows.Forms.ErrorProvider epFim;
        public System.Windows.Forms.ErrorProvider epIntevalo;
        public System.Windows.Forms.ErrorProvider epIntervaloFim;
        public System.Windows.Forms.Label lblDia;
        public System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.CheckBox ckSabado;
        private System.Windows.Forms.CheckBox ckSegunda;
        private System.Windows.Forms.CheckBox ckTerca;
        private System.Windows.Forms.CheckBox ckQuarta;
        private System.Windows.Forms.CheckBox ckQuinta;
        private System.Windows.Forms.CheckBox ckSexta;
        private System.Windows.Forms.CheckBox ckDomingo;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.ComboBox cboBegin;
        public System.Windows.Forms.ComboBox cboEnd;
        public System.Windows.Forms.ComboBox cboInterval;
        public System.Windows.Forms.ComboBox cboIntervalEnd;
    }
}