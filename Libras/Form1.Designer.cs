namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnLetraNext = new System.Windows.Forms.Button();
            this.BtnLetraback = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnImagBack = new System.Windows.Forms.Button();
            this.btnImagnext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgLetra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProxima
            // 
            this.btnProxima.Location = new System.Drawing.Point(621, 348);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(120, 36);
            this.btnProxima.TabIndex = 0;
            this.btnProxima.Text = "Proxima Imagem >>";
            this.btnProxima.UseVisualStyleBackColor = true;
            this.btnProxima.Click += new System.EventHandler(this.Proximo_Click);
            // 
            // imgLetra
            // 
            this.imgLetra.Location = new System.Drawing.Point(435, 19);
            this.imgLetra.Name = "imgLetra";
            this.imgLetra.Size = new System.Drawing.Size(400, 300);
            this.imgLetra.TabIndex = 2;
            this.imgLetra.TabStop = false;
            // 
            // imgImagem
            // 
            this.imgImagem.Location = new System.Drawing.Point(16, 19);
            this.imgImagem.Name = "imgImagem";
            this.imgImagem.Size = new System.Drawing.Size(402, 502);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, -13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Escolha uma Figura e Monte sua Palavra";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, -23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Começar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(484, 348);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(122, 36);
            this.btnAnterior.TabIndex = 10;
            this.btnAnterior.Text = "<< Imagem Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnterior);
            this.groupBox1.Controls.Add(this.btnProxima);
            this.groupBox1.Controls.Add(this.imgLetra);
            this.groupBox1.Controls.Add(this.imgImagem);
            this.groupBox1.Controls.Add(this.lblLetra);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 540);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aprendendo Alfabeto de Libras";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnLetraNext);
            this.groupBox2.Controls.Add(this.BtnLetraback);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnOk);
            this.groupBox2.Controls.Add(this.btnImagBack);
            this.groupBox2.Controls.Add(this.btnImagnext);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(880, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 540);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teste de Conhecimento";
            // 
            // BtnLetraNext
            // 
            this.BtnLetraNext.Location = new System.Drawing.Point(377, 240);
            this.BtnLetraNext.Name = "BtnLetraNext";
            this.BtnLetraNext.Size = new System.Drawing.Size(75, 23);
            this.BtnLetraNext.TabIndex = 17;
            this.BtnLetraNext.Text = "Letra >>";
            this.BtnLetraNext.UseVisualStyleBackColor = true;
            this.BtnLetraNext.Click += new System.EventHandler(this.BtnLetraNext_Click);
            // 
            // BtnLetraback
            // 
            this.BtnLetraback.Location = new System.Drawing.Point(279, 240);
            this.BtnLetraback.Name = "BtnLetraback";
            this.BtnLetraback.Size = new System.Drawing.Size(75, 23);
            this.BtnLetraback.TabIndex = 16;
            this.BtnLetraback.Text = "<< Letra";
            this.BtnLetraback.UseVisualStyleBackColor = true;
            this.BtnLetraback.Click += new System.EventHandler(this.BtnLetraback_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(279, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 156);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(377, 275);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "Confirmar";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnImagBack
            // 
            this.btnImagBack.Location = new System.Drawing.Point(48, 406);
            this.btnImagBack.Name = "btnImagBack";
            this.btnImagBack.Size = new System.Drawing.Size(75, 23);
            this.btnImagBack.TabIndex = 13;
            this.btnImagBack.Text = "<< Imagen";
            this.btnImagBack.UseVisualStyleBackColor = true;
            this.btnImagBack.Click += new System.EventHandler(this.btnImagBack_Click);
            // 
            // btnImagnext
            // 
            this.btnImagnext.Location = new System.Drawing.Point(148, 406);
            this.btnImagnext.Name = "btnImagnext";
            this.btnImagnext.Size = new System.Drawing.Size(75, 23);
            this.btnImagnext.TabIndex = 12;
            this.btnImagnext.Text = "Imagen >>";
            this.btnImagnext.UseVisualStyleBackColor = true;
            this.btnImagnext.Click += new System.EventHandler(this.btnImagnext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(29, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 316);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ESCOLHA UMA IMAGEM E INFORME A LETRA EM LIBRAS QUE LHE REPRESENTA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aprendendo Alfabeto de Libras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLetra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgImagem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.PictureBox imgLetra;
        private System.Windows.Forms.PictureBox imgImagem;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImagnext;
        private System.Windows.Forms.Button btnImagBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button BtnLetraNext;
        private System.Windows.Forms.Button BtnLetraback;
    }
}

