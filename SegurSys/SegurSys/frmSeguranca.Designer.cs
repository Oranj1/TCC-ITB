namespace SegurSys
{
    partial class frmSeguranca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguranca));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarOcorrênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rondasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLast = new System.Windows.Forms.GroupBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.tmAttFormSegur = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.grpLast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarOcorrênciaToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(137, 250);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarOcorrênciaToolStripMenuItem
            // 
            this.registrarOcorrênciaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.registrarOcorrênciaToolStripMenuItem.Name = "registrarOcorrênciaToolStripMenuItem";
            this.registrarOcorrênciaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 98, 0, 0);
            this.registrarOcorrênciaToolStripMenuItem.Size = new System.Drawing.Size(136, 121);
            this.registrarOcorrênciaToolStripMenuItem.Text = "Registrar Ocorrência";
            this.registrarOcorrênciaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.registrarOcorrênciaToolStripMenuItem.Click += new System.EventHandler(this.registrarOcorrênciaToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dadosToolStripMenuItem,
            this.escalaToolStripMenuItem,
            this.rondasToolStripMenuItem});
            this.consultarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 98, 0, 0);
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(136, 121);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.dadosToolStripMenuItem.Text = "Dados";
            this.dadosToolStripMenuItem.Click += new System.EventHandler(this.dadosToolStripMenuItem_Click);
            // 
            // escalaToolStripMenuItem
            // 
            this.escalaToolStripMenuItem.Name = "escalaToolStripMenuItem";
            this.escalaToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.escalaToolStripMenuItem.Text = "Escala";
            this.escalaToolStripMenuItem.Click += new System.EventHandler(this.escalaToolStripMenuItem_Click);
            // 
            // rondasToolStripMenuItem
            // 
            this.rondasToolStripMenuItem.Name = "rondasToolStripMenuItem";
            this.rondasToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.rondasToolStripMenuItem.Text = "Rondas";
            this.rondasToolStripMenuItem.Click += new System.EventHandler(this.rondasToolStripMenuItem_Click);
            // 
            // grpLast
            // 
            this.grpLast.Controls.Add(this.txtLast);
            this.grpLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.grpLast.Location = new System.Drawing.Point(154, 37);
            this.grpLast.Name = "grpLast";
            this.grpLast.Size = new System.Drawing.Size(629, 202);
            this.grpLast.TabIndex = 1;
            this.grpLast.TabStop = false;
            this.grpLast.Text = "Ultima Ocorrêcnia";
            // 
            // txtLast
            // 
            this.txtLast.Enabled = false;
            this.txtLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLast.Location = new System.Drawing.Point(6, 20);
            this.txtLast.Multiline = true;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(617, 176);
            this.txtLast.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(708, 8);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(597, 3);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Visible = false;
            // 
            // tmAttFormSegur
            // 
            this.tmAttFormSegur.Tick += new System.EventHandler(this.tmAttFormSegur_Tick);
            // 
            // frmSeguranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(791, 250);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpLast);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmSeguranca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Segurança";
            this.Load += new System.EventHandler(this.frmSeguranca_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpLast.ResumeLayout(false);
            this.grpLast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox grpLast;
        private System.Windows.Forms.ToolStripMenuItem registrarOcorrênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rondasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Timer tmAttFormSegur;
    }
}