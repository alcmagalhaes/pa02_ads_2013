using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace libras
{
    public partial class Form1 : Form
    {
        int Posicao = 0;
        DataTable Alfabeto;

        public Form1()
        {
            InitializeComponent();
        }

        protected void Form1_Load(object sender, EventArgs e)
        {
            BuscarDoBanco();
            CarregarImagem();
        }

        private void BuscarDoBanco()
        {
            Alfabeto = new DataTable();
            Alfabeto.Columns.Add("idAlfabeto");
            Alfabeto.Columns.Add("imagem");
            Alfabeto.Columns.Add("libras");

            Alfabeto.Rows.Add("A", @"C:\UNA\Imagens\a_br.jpg", @"C:\UNA\Imagens\a_big.jpg");
            Alfabeto.Rows.Add("B", @"C:\UNA\Imagens\b_br.jpg", @"C:\UNA\Imagens\b_big.jpg");
            Alfabeto.Rows.Add("C", @"C:\UNA\Imagens\c_br.jpg", @"C:\UNA\Imagens\c_big.jpg");
            Alfabeto.Rows.Add("D", @"C:\UNA\Imagens\d_br.jpg", @"C:\UNA\Imagens\d_big.jpg");
            Alfabeto.Rows.Add("E", @"C:\UNA\Imagens\e_br.jpg", @"C:\UNA\Imagens\e_big.jpg");
            Alfabeto.Rows.Add("F", @"C:\UNA\Imagens\f_br.jpg", @"C:\UNA\Imagens\f_big.jpg");
            Alfabeto.Rows.Add("G", @"C:\UNA\Imagens\g_br.jpg", @"C:\UNA\Imagens\g_big.jpg");
            Alfabeto.Rows.Add("H", @"C:\UNA\Imagens\h_br.jpg", @"C:\UNA\Imagens\h_big.jpg");
            Alfabeto.Rows.Add("I", @"C:\UNA\Imagens\i_br.jpg", @"C:\UNA\Imagens\i_big.jpg");
            Alfabeto.Rows.Add("J", @"C:\UNA\Imagens\j_br.jpg", @"C:\UNA\Imagens\j_big.jpg");
            Alfabeto.Rows.Add("K", @"C:\UNA\Imagens\k_br.jpg", @"C:\UNA\Imagens\k_big.jpg");
            Alfabeto.Rows.Add("L", @"C:\UNA\Imagens\l_br.jpg", @"C:\UNA\Imagens\l_big.jpg");
            Alfabeto.Rows.Add("M", @"C:\UNA\Imagens\m_br.jpg", @"C:\UNA\Imagens\m_big.jpg");
            Alfabeto.Rows.Add("N", @"C:\UNA\Imagens\n_br.jpg", @"C:\UNA\Imagens\n_big.jpg");
            Alfabeto.Rows.Add("O", @"C:\UNA\Imagens\o_br.jpg", @"C:\UNA\Imagens\o_big.jpg");
            Alfabeto.Rows.Add("P", @"C:\UNA\Imagens\p_br.jpg", @"C:\UNA\Imagens\p_big.jpg");
            Alfabeto.Rows.Add("Q", @"C:\UNA\Imagens\q_br.jpg", @"C:\UNA\Imagens\q_big.jpg");
            Alfabeto.Rows.Add("R", @"C:\UNA\Imagens\r_br.jpg", @"C:\UNA\Imagens\r_big.jpg");
            Alfabeto.Rows.Add("S", @"C:\UNA\Imagens\s_br.jpg", @"C:\UNA\Imagens\s_big.jpg");
            Alfabeto.Rows.Add("T", @"C:\UNA\Imagens\t_br.jpg", @"C:\UNA\Imagens\t_big.jpg");
            Alfabeto.Rows.Add("U", @"C:\UNA\Imagens\u_br.jpg", @"C:\UNA\Imagens\u_big.jpg");
            Alfabeto.Rows.Add("V", @"C:\UNA\Imagens\v_br.jpg", @"C:\UNA\Imagens\v_big.jpg");
            Alfabeto.Rows.Add("W", @"C:\UNA\Imagens\w_br.jpg", @"C:\UNA\Imagens\x_big.jpg");
            Alfabeto.Rows.Add("X", @"C:\UNA\Imagens\x_br.jpg", @"C:\UNA\Imagens\w_big.jpg");
            Alfabeto.Rows.Add("Y", @"C:\UNA\Imagens\y_br.jpg", @"C:\UNA\Imagens\y_big.jpg");
            Alfabeto.Rows.Add("Z", @"C:\UNA\Imagens\z_br.jpg", @"C:\UNA\Imagens\z_big.jpg");

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnJogoMemoria_Click(object sender, EventArgs e)
        {
            memoria.Form1 memoria = new memoria.Form1();
            memoria.Show();
        }

        private void btnJogoForca_Click(object sender, EventArgs e)
        {
            forca.Form1 forca = new forca.Form1();
            forca.Show();
        }

        private void btnJogoAdivinha_Click(object sender, EventArgs e)
        {
            libras.Form2 advinha = new libras.Form2();
            advinha.Show();
        }

    }
}
