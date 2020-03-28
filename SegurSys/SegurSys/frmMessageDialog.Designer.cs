namespace SegurSys
{
    partial class frmMessageDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageDialog));
            this.btnNemPensar = new System.Windows.Forms.Button();
            this.btnSimEuQuero = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.pcbQuestion = new System.Windows.Forms.PictureBox();
            this.pcClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNemPensar
            // 
            this.btnNemPensar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNemPensar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNemPensar.Location = new System.Drawing.Point(99, 131);
            this.btnNemPensar.Name = "btnNemPensar";
            this.btnNemPensar.Size = new System.Drawing.Size(81, 27);
            this.btnNemPensar.TabIndex = 0;
            this.btnNemPensar.Text = "&Não";
            this.btnNemPensar.UseVisualStyleBackColor = true;
            this.btnNemPensar.Click += new System.EventHandler(this.btnNemPensar_Click);
            // 
            // btnSimEuQuero
            // 
            this.btnSimEuQuero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimEuQuero.Location = new System.Drawing.Point(12, 131);
            this.btnSimEuQuero.Name = "btnSimEuQuero";
            this.btnSimEuQuero.Size = new System.Drawing.Size(81, 27);
            this.btnSimEuQuero.TabIndex = 1;
            this.btnSimEuQuero.Text = "&Sim";
            this.btnSimEuQuero.UseVisualStyleBackColor = true;
            this.btnSimEuQuero.Click += new System.EventHandler(this.btnSimEuQuero_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 45);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(117, 17);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Inserir texto aqui*";
            // 
            // pcbSair
            // 
            this.pcbSair.Image = ((System.Drawing.Image)(resources.GetObject("pcbSair.Image")));
            this.pcbSair.Location = new System.Drawing.Point(275, 28);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(121, 125);
            this.pcbSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSair.TabIndex = 4;
            this.pcbSair.TabStop = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(12, 85);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(171, 17);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Segunda frase (opicional)";
            this.lbl2.Visible = false;
            // 
            // pcbQuestion
            // 
            this.pcbQuestion.BackColor = System.Drawing.Color.Transparent;
            this.pcbQuestion.Image = ((System.Drawing.Image)(resources.GetObject("pcbQuestion.Image")));
            this.pcbQuestion.Location = new System.Drawing.Point(275, 28);
            this.pcbQuestion.Name = "pcbQuestion";
            this.pcbQuestion.Size = new System.Drawing.Size(121, 125);
            this.pcbQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbQuestion.TabIndex = 6;
            this.pcbQuestion.TabStop = false;
            this.pcbQuestion.Visible = false;
            // 
            // pcClose
            // 
            this.pcClose.BackColor = System.Drawing.Color.Transparent;
            this.pcClose.Image = ((System.Drawing.Image)(resources.GetObject("pcClose.Image")));
            this.pcClose.Location = new System.Drawing.Point(369, 2);
            this.pcClose.Name = "pcClose";
            this.pcClose.Size = new System.Drawing.Size(32, 33);
            this.pcClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcClose.TabIndex = 7;
            this.pcClose.TabStop = false;
            this.pcClose.Click += new System.EventHandler(this.pcClose_Click);
            // 
            // frmMessageDialog
            // 
            this.AcceptButton = this.btnNemPensar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.btnNemPensar;
            this.ClientSize = new System.Drawing.Size(403, 167);
            this.Controls.Add(this.pcbQuestion);
            this.Controls.Add(this.pcClose);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.pcbSair);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnSimEuQuero);
            this.Controls.Add(this.btnNemPensar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessageDialog";
            this.Load += new System.EventHandler(this.frmMessageDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNemPensar;
        private System.Windows.Forms.Button btnSimEuQuero;
        public System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pcbSair;
        public System.Windows.Forms.Label lbl2;
        public System.Windows.Forms.PictureBox pcbQuestion;
        private System.Windows.Forms.PictureBox pcClose;
    }
}