namespace SegurSys
{
    partial class frmVerOcorrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerOcorrencia));
            this.txtAchaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcha = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.dgvOcorrorencias = new System.Windows.Forms.DataGridView();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnTodas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrorencias)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAchaId
            // 
            this.txtAchaId.Location = new System.Drawing.Point(89, 16);
            this.txtAchaId.MaxLength = 400;
            this.txtAchaId.Name = "txtAchaId";
            this.txtAchaId.Size = new System.Drawing.Size(102, 20);
            this.txtAchaId.TabIndex = 0;
            this.txtAchaId.TextChanged += new System.EventHandler(this.txtAchaId_TextChanged);
            this.txtAchaId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAchaId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Procurar ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAcha
            // 
            this.btnAcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcha.Location = new System.Drawing.Point(196, 12);
            this.btnAcha.Name = "btnAcha";
            this.btnAcha.Size = new System.Drawing.Size(79, 26);
            this.btnAcha.TabIndex = 2;
            this.btnAcha.Text = "&Pesquisar";
            this.btnAcha.UseVisualStyleBackColor = true;
            this.btnAcha.Click += new System.EventHandler(this.btnAcha_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.Red;
            this.btnQuitar.Location = new System.Drawing.Point(686, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 3;
            this.btnQuitar.Text = "&Voltar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // dgvOcorrorencias
            // 
            this.dgvOcorrorencias.AllowUserToAddRows = false;
            this.dgvOcorrorencias.AllowUserToDeleteRows = false;
            this.dgvOcorrorencias.AllowUserToResizeColumns = false;
            this.dgvOcorrorencias.AllowUserToResizeRows = false;
            this.dgvOcorrorencias.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvOcorrorencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcorrorencias.Location = new System.Drawing.Point(11, 56);
            this.dgvOcorrorencias.Name = "dgvOcorrorencias";
            this.dgvOcorrorencias.ReadOnly = true;
            this.dgvOcorrorencias.Size = new System.Drawing.Size(747, 303);
            this.dgvOcorrorencias.TabIndex = 4;
            this.dgvOcorrorencias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOcorrorencias_CellContentClick);
            this.dgvOcorrorencias.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOcorrorencias_CellContentDoubleClick);
            // 
            // btnMais
            // 
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(8, 370);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(115, 42);
            this.btnMais.TabIndex = 5;
            this.btnMais.Text = "Ver Ocorrência";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnTodas
            // 
            this.btnTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodas.Location = new System.Drawing.Point(554, 369);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.Size = new System.Drawing.Size(103, 43);
            this.btnTodas.TabIndex = 6;
            this.btnTodas.Text = "&Mostrar Todas";
            this.btnTodas.UseVisualStyleBackColor = true;
            this.btnTodas.Click += new System.EventHandler(this.btnTodas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 320);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // frmVerOcorrencia
            // 
            this.AcceptButton = this.btnAcha;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 422);
            this.Controls.Add(this.btnTodas);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.dgvOcorrorencias);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAcha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAchaId);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVerOcorrencia";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ocorrêncais Registradas";
            this.Load += new System.EventHandler(this.frmVerOcorrencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcorrorencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAchaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcha;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridView dgvOcorrorencias;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnTodas;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}