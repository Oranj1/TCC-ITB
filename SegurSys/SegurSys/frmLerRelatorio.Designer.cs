namespace SegurSys
{
    partial class frmLerRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLerRelatorio));
            this.label1 = new System.Windows.Forms.Label();
            this.mskDataRel = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeRel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRel = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data de Registro:";
            // 
            // mskDataRel
            // 
            this.mskDataRel.Enabled = false;
            this.mskDataRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDataRel.Location = new System.Drawing.Point(141, 37);
            this.mskDataRel.Mask = "00/00/0000";
            this.mskDataRel.Name = "mskDataRel";
            this.mskDataRel.Size = new System.Drawing.Size(134, 23);
            this.mskDataRel.TabIndex = 1;
            this.mskDataRel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Relatado Por:";
            // 
            // txtNomeRel
            // 
            this.txtNomeRel.Enabled = false;
            this.txtNomeRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRel.Location = new System.Drawing.Point(117, 7);
            this.txtNomeRel.Name = "txtNomeRel";
            this.txtNomeRel.Size = new System.Drawing.Size(372, 23);
            this.txtNomeRel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Relatório:";
            // 
            // txtRel
            // 
            this.txtRel.Enabled = false;
            this.txtRel.Location = new System.Drawing.Point(15, 98);
            this.txtRel.Multiline = true;
            this.txtRel.Name = "txtRel";
            this.txtRel.Size = new System.Drawing.Size(611, 333);
            this.txtRel.TabIndex = 5;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.Red;
            this.btnQuitar.Location = new System.Drawing.Point(551, 7);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 11;
            this.btnQuitar.Text = "&Voltar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // frmLerRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(638, 443);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.txtRel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeRel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskDataRel);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLerRelatorio";
            this.Text = "Ler Relatorio";
            this.Load += new System.EventHandler(this.frmLerRelatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox mskDataRel;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtNomeRel;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtRel;
        public System.Windows.Forms.Button btnQuitar;
    }
}