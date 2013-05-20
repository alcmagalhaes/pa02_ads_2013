using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int Posicao = 0;
        int Posicao1 = 0;
        int Posicao2 = 0;
        DataTable Alfabeto;
        DataTable Alfabeto1;
        DataTable Alfabeto2;

        public Form1()
        {
            InitializeComponent();
        }

        protected void Form1_Load(object sender, EventArgs e)
        {
            BuscarDoBanco();
            CarregarImagem();
            BuscarDoBanco1();
            CarregarImagem1();
            BuscarDoBanco2();
            CarregarImagem2();
        }

        private void BuscarDoBanco()
        {
            Alfabeto = new DataTable();
            Alfabeto.Columns.Add("idAlfabeto");
            Alfabeto.Columns.Add("imagem");
            Alfabeto.Columns.Add("libras");

            Alfabeto.Rows.Add("A", @"C:\UNA\Libras\Imagens\A.jpg", @"C:\UNA\Libras\Alfabeto_Libras\A.jpg");
            Alfabeto.Rows.Add("B", @"C:\UNA\Libras\Imagens\B.jpg", @"C:\UNA\Libras\Alfabeto_Libras\B.jpg");
            Alfabeto.Rows.Add("C", @"C:\UNA\Libras\Imagens\C.jpg", @"C:\UNA\Libras\Alfabeto_Libras\C.jpg");
            Alfabeto.Rows.Add("D", @"C:\UNA\Libras\Imagens\D.jpg", @"C:\UNA\Libras\Alfabeto_Libras\D.jpg");
            Alfabeto.Rows.Add("E", @"C:\UNA\Libras\Imagens\E.jpg", @"C:\UNA\Libras\Alfabeto_Libras\E.jpg");
            Alfabeto.Rows.Add("F", @"C:\UNA\Libras\Imagens\F.jpg", @"C:\UNA\Libras\Alfabeto_Libras\F.jpg");
            Alfabeto.Rows.Add("G", @"C:\UNA\Libras\Imagens\G.jpg", @"C:\UNA\Libras\Alfabeto_Libras\G.jpg");
            Alfabeto.Rows.Add("G", @"C:\UNA\Libras\Imagens\H.jpg", @"C:\UNA\Libras\Alfabeto_Libras\H.jpg");
            Alfabeto.Rows.Add("G", @"C:\UNA\Libras\Imagens\I.jpg", @"C:\UNA\Libras\Alfabeto_Libras\I.jpg");
            Alfabeto.Rows.Add("G", @"C:\UNA\Libras\Imagens\J.jpg", @"C:\UNA\Libras\Alfabeto_Libras\J.jpg");
        }

        private void BuscarDoBanco1()
        {
            Alfabeto1 = new DataTable();
            Alfabeto1.Columns.Add("idAlfabeto");
            Alfabeto1.Columns.Add("imagem");
            Alfabeto1.Columns.Add("libras");

            Alfabeto1.Rows.Add("A", @"C:\UNA\Libras\Imagens\A.jpg"); 
            Alfabeto1.Rows.Add("B", @"C:\UNA\Libras\Imagens\B.jpg"); 
            Alfabeto1.Rows.Add("C", @"C:\UNA\Libras\Imagens\C.jpg"); 
            Alfabeto1.Rows.Add("D", @"C:\UNA\Libras\Imagens\D.jpg"); 
            Alfabeto1.Rows.Add("E", @"C:\UNA\Libras\Imagens\E.jpg"); 
            Alfabeto1.Rows.Add("F", @"C:\UNA\Libras\Imagens\F.jpg"); 
            Alfabeto1.Rows.Add("G", @"C:\UNA\Libras\Imagens\G.jpg"); 
            Alfabeto1.Rows.Add("G", @"C:\UNA\Libras\Imagens\H.jpg");
            Alfabeto1.Rows.Add("G", @"C:\UNA\Libras\Imagens\I.jpg"); 
            Alfabeto1.Rows.Add("G", @"C:\UNA\Libras\Imagens\J.jpg");
           
        }

        private void BuscarDoBanco2()
        {
            Alfabeto2 = new DataTable();
            Alfabeto2.Columns.Add("idAlfabeto");
            Alfabeto2.Columns.Add("libras");

            Alfabeto2.Rows.Add("A", @"C:\UNA\Libras\Alfabeto_Libras\A.jpg");
            Alfabeto2.Rows.Add("B", @"C:\UNA\Libras\Alfabeto_Libras\B.jpg");
            Alfabeto2.Rows.Add("C", @"C:\UNA\Libras\Alfabeto_Libras\C.jpg");
            Alfabeto2.Rows.Add("D", @"C:\UNA\Libras\Alfabeto_Libras\D.jpg");
            Alfabeto2.Rows.Add("E", @"C:\UNA\Libras\Alfabeto_Libras\E.jpg");
            Alfabeto2.Rows.Add("F", @"C:\UNA\Libras\Alfabeto_Libras\F.jpg");
            Alfabeto2.Rows.Add("G", @"C:\UNA\Libras\Alfabeto_Libras\G.jpg");
            Alfabeto2.Rows.Add("H", @"C:\UNA\Libras\Alfabeto_Libras\H.jpg");
            Alfabeto2.Rows.Add("I", @"C:\UNA\Libras\Alfabeto_Libras\I.jpg");
            Alfabeto2.Rows.Add("J", @"C:\UNA\Libras\Alfabeto_Libras\J.jpg");

        }
        private void Anterior_Click(object sender, EventArgs e)
        {
            Posicao = Posicao - 1;
            CarregarImagem();
        }

        private void Proximo_Click(object sender, EventArgs e)
        {
            Posicao = Posicao + 1;
            CarregarImagem();
        }

        private void CarregarImagem()
        {
            string idAlfabeto = Alfabeto.Rows[Posicao]["idAlfabeto"].ToString();
            string imagem = Alfabeto.Rows[Posicao]["imagem"].ToString();
            string libras = Alfabeto.Rows[Posicao]["libras"].ToString();
            imgImagem.ImageLocation = imagem;
            imgLetra.ImageLocation = libras;
            lblLetra.Text = idAlfabeto;

            BotoesDeNavegacao();
        }

        private void BotoesDeNavegacao()
        {
            btnAnterior.Enabled = true;
            btnProxima.Enabled = true;

            if (Posicao == 0)
            {
                btnAnterior.Enabled = false;
            }

            if (Alfabeto.Rows.Count == Posicao + 1)
            {
                btnProxima.Enabled = false;
            }
        }

        private void BotoesDeNavegacao1()
        {
            btnImagBack.Enabled = true;
            btnImagnext.Enabled = true;

            if (Posicao1 == 0)
            {
                btnImagBack.Enabled = false;
            }

            if (Alfabeto1.Rows.Count == Posicao1 + 1)
            {
                btnImagnext.Enabled = false;
            }
        }

        private void BotoesDeNavegacao2()
        {
            BtnLetraback.Enabled = true;
            BtnLetraNext.Enabled = true;

            if (Posicao2 == 0)
            {
                BtnLetraback.Enabled = false;
            }

            if (Alfabeto2.Rows.Count == Posicao2 + 1)
            {
                BtnLetraNext.Enabled = false;
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnImagnext_Click(object sender, EventArgs e)
        {
            Posicao1 = Posicao1 + 1;
            CarregarImagem1();
        }

        private void CarregarImagem1()
        {
            string idAlfabeto = Alfabeto1.Rows[Posicao1]["idAlfabeto"].ToString();
            string imagem = Alfabeto1.Rows[Posicao1]["imagem"].ToString();
            string libras = Alfabeto1.Rows[Posicao1]["libras"].ToString();
            pictureBox1.ImageLocation = imagem;
            lblSelecao1.Text = idAlfabeto;

            BotoesDeNavegacao1();
        }

        private void btnImagBack_Click(object sender, EventArgs e)
        {
            Posicao1 = Posicao1 - 1;
            CarregarImagem1();
        }

        private void BtnLetraNext_Click(object sender, EventArgs e)
        {
            Posicao2 = Posicao2 + 1;
            CarregarImagem2();
        }

        private void CarregarImagem2()
        {
            string idAlfabeto = Alfabeto2.Rows[Posicao2]["idAlfabeto"].ToString();
            string libras = Alfabeto2.Rows[Posicao2]["libras"].ToString();
            pictureBox2.ImageLocation = libras;
            lblSelecao2.Text = idAlfabeto;
            BotoesDeNavegacao2();
        }

        private void BtnLetraback_Click(object sender, EventArgs e)
        {
            Posicao2 = Posicao2 - 1;
            CarregarImagem2();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lblSelecao1.Text == lblSelecao2.Text)
            {
                MessageBox.Show("Sucesso!!!");
            }
            else
            {
                MessageBox.Show("Errou!!!");
            }

        }
       
    }
}
