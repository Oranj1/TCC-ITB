namespace SegurSys
{
    partial class frmMonitoramento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonitoramento));
            this.dgvAtual = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tmAttFormAtual = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtual)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAtual
            // 
            this.dgvAtual.AllowUserToAddRows = false;
            this.dgvAtual.AllowUserToDeleteRows = false;
            this.dgvAtual.AllowUserToResizeColumns = false;
            this.dgvAtual.AllowUserToResizeRows = false;
            this.dgvAtual.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAtual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtual.GridColor = System.Drawing.Color.Gray;
            this.dgvAtual.Location = new System.Drawing.Point(12, 46);
            this.dgvAtual.Name = "dgvAtual";
            this.dgvAtual.ReadOnly = true;
            this.dgvAtual.Size = new System.Drawing.Size(777, 349);
            this.dgvAtual.TabIndex = 3;
            this.dgvAtual.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtual_CellContentClick);
            this.dgvAtual.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtual_CellContentDoubleClick);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(712, 8);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(77, 28);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "&Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTitulo.Location = new System.Drawing.Point(12, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 18);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Estão Trabalhando Agora:";
            // 
            // tmAttFormAtual
            // 
            this.tmAttFormAtual.Tick += new System.EventHandler(this.tmAttFormAtual_Tick);
            // 
            // frmMonitoramento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvAtual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMonitoramento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoramento em Tempo Real";
            this.Load += new System.EventHandler(this.frmMonitoramento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAtual;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Timer tmAttFormAtual;
    }
}