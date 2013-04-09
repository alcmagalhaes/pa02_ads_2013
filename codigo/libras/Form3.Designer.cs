namespace libras
{
    partial class frmSistemas
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
            this.btnNivel2 = new System.Windows.Forms.Button();
            this.btnNivel3 = new System.Windows.Forms.Button();
            this.lblnivel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnnivel1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNivel2
            // 
            this.btnNivel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNivel2.Location = new System.Drawing.Point(17, 144);
            this.btnNivel2.Name = "btnNivel2";
            this.btnNivel2.Size = new System.Drawing.Size(97, 95);
            this.btnNivel2.TabIndex = 2;
            this.btnNivel2.Text = "Nivel 2";
            this.btnNivel2.UseVisualStyleBackColor = true;
            // 
            // btnNivel3
            // 
            this.btnNivel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNivel3.Location = new System.Drawing.Point(17, 258);
            this.btnNivel3.Name = "btnNivel3";
            this.btnNivel3.Size = new System.Drawing.Size(97, 95);
            this.btnNivel3.TabIndex = 3;
            this.btnNivel3.Text = "Nivel 3";
            this.btnNivel3.UseVisualStyleBackColor = true;
            this.btnNivel3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblnivel1
            // 
            this.lblnivel1.AutoSize = true;
            this.lblnivel1.Location = new System.Drawing.Point(160, 35);
            this.lblnivel1.Name = "lblnivel1";
            this.lblnivel1.Size = new System.Drawing.Size(96, 13);
            this.lblnivel1.TabIndex = 4;
            this.lblnivel1.Text = "Informação Nivel 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Informação Nivel 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Informação Nivel 3";
            // 
            // btnnivel1
            // 
            this.btnnivel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnivel1.Location = new System.Drawing.Point(17, 23);
            this.btnnivel1.Name = "btnnivel1";
            this.btnnivel1.Size = new System.Drawing.Size(97, 95);
            this.btnnivel1.TabIndex = 1;
            this.btnnivel1.Text = "Nivel 1";
            this.btnnivel1.UseVisualStyleBackColor = true;
            // 
            // frmSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(386, 365);
            this.Controls.Add(this.btnnivel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnivel1);
            this.Controls.Add(this.btnNivel3);
            this.Controls.Add(this.btnNivel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSistemas";
            this.Text = "ESCOLHA SEU TESTE DE APRENDIZAGEM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNivel2;
        private System.Windows.Forms.Button btnNivel3;
        private System.Windows.Forms.Label lblnivel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnnivel1;
    }
}