namespace paLibras
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
            this.btnProxima = new System.Windows.Forms.Button();
            this.imgLetra = new System.Windows.Forms.PictureBox();
            this.imgImagem = new System.Windows.Forms.PictureBox();
            this.lblLetra = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJogoAdivinha = new System.Windows.Forms.Button();
            this.btnJogoForca = new System.Windows.Forms.Button();
            this.btnJogoMemoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgLetra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProxima
            // 
            this.btnProxima.Location = new System.Drawing.Point(524, 312);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(120, 36);
            this.btnProxima.TabIndex = 0;
            this.btnProxima.Text = "Proxima Imagem >>";
            this.btnProxima.UseVisualStyleBackColor = true;
            this.btnProxima.Click += new System.EventHandler(this.Proximo_Click);
            // 
            // imgLetra
            // 
            this.imgLetra.Location = new System.Drawing.Point(365, 35);
            this.imgLetra.Name = "imgLetra";
            this.imgLetra.Size = new System.Drawing.Size(300, 250);
            this.imgLetra.TabIndex = 2;
            this.imgLetra.TabStop = false;
            // 
            // imgImagem
            // 
            this.imgImagem.Location = new System.Drawing.Point(16, 35);
            this.imgImagem.Name = "imgImagem";
            this.imgImagem.Size = new System.Drawing.Size(325, 475);
            this.imgImagem.TabIndex = 3;
            this.imgImagem.TabStop = false;
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.Location = new System.Drawing.Point(325, 250);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(10, 13);
            this.lblLetra.TabIndex = 4;
            this.lblLetra.Text = ".";
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(387, 312);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(122, 36);
            this.btnAnterior.TabIndex = 10;
            this.btnAnterior.Text = "<< Imagem Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJogoAdivinha);
            this.groupBox1.Controls.Add(this.btnJogoForca);
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.btnJogoMemoria);
            this.groupBox1.Controls.Add(this.btnProxima);
            this.groupBox1.Controls.Add(this.imgLetra);
            this.groupBox1.Controls.Add(this.imgImagem);
            this.groupBox1.Controls.Add(this.lblLetra);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 540);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aprendendo Alfabeto de Libras";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnJogoAdivinha
            // 
            this.btnJogoAdivinha.Location = new System.Drawing.Point(387, 377);
            this.btnJogoAdivinha.Name = "btnJogoAdivinha";
            this.btnJogoAdivinha.Size = new System.Drawing.Size(122, 36);
            this.btnJogoAdivinha.TabIndex = 22;
            this.btnJogoAdivinha.Text = "Jogo de Adivinhacao";
            this.btnJogoAdivinha.UseVisualStyleBackColor = true;
            this.btnJogoAdivinha.Click += new System.EventHandler(this.btnJogoAdivinha_Click);
            // 
            // btnJogoForca
            // 
            this.btnJogoForca.Location = new System.Drawing.Point(387, 474);
            this.btnJogoForca.Name = "btnJogoForca";
            this.btnJogoForca.Size = new System.Drawing.Size(122, 36);
            this.btnJogoForca.TabIndex = 21;
            this.btnJogoForca.Text = "Jogo da Forca";
            this.btnJogoForca.UseVisualStyleBackColor = true;
            this.btnJogoForca.Click += new System.EventHandler(this.btnJogoForca_Click);
            // 
            // btnJogoMemoria
            // 
            this.btnJogoMemoria.Location = new System.Drawing.Point(387, 428);
            this.btnJogoMemoria.Name = "btnJogoMemoria";
            this.btnJogoMemoria.Size = new System.Drawing.Size(122, 36);
            this.btnJogoMemoria.TabIndex = 20;
            this.btnJogoMemoria.Text = "Jogo da Memoria";
            this.btnJogoMemoria.UseVisualStyleBackColor = true;
            this.btnJogoMemoria.Click += new System.EventHandler(this.btnJogoMemoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 574);
            this.Controls.Add(this.groupBox1);
            this.Name = "Forca";
            this.Text = "Aprendendo Alfabeto de Libras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLetra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.PictureBox imgLetra;
        private System.Windows.Forms.PictureBox imgImagem;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJogoForca;
        private System.Windows.Forms.Button btnJogoMemoria;
        private System.Windows.Forms.Button btnJogoAdivinha;
    }
}

