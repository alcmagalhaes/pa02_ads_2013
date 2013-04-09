namespace libras
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nível2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nível1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nível2ToolStripMenuItem,
            this.nível1ToolStripMenuItem,
            this.examesToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // nível2ToolStripMenuItem
            // 
            this.nível2ToolStripMenuItem.Name = "nível2ToolStripMenuItem";
            this.nível2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nível2ToolStripMenuItem.Text = "Login";
            this.nível2ToolStripMenuItem.Click += new System.EventHandler(this.nível2ToolStripMenuItem_Click);
            // 
            // nível1ToolStripMenuItem
            // 
            this.nível1ToolStripMenuItem.Name = "nível1ToolStripMenuItem";
            this.nível1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nível1ToolStripMenuItem.Text = "Cadastro";
            this.nível1ToolStripMenuItem.Click += new System.EventHandler(this.nível1ToolStripMenuItem_Click);
            // 
            // examesToolStripMenuItem
            // 
            this.examesToolStripMenuItem.Name = "examesToolStripMenuItem";
            this.examesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.examesToolStripMenuItem.Text = "Exames";
            this.examesToolStripMenuItem.Click += new System.EventHandler(this.examesToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 506);
            this.panel1.TabIndex = 1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 563);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "SISTEMA DE APRENDIZAGEM DE LIBRAS";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nível1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nível2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem examesToolStripMenuItem;
    }
}