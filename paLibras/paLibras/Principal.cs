using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace paLibras
{
    public partial class Principal : Form
    {
        int Posicao = 0;
        List<System.Drawing.Bitmap> imagens;
        List<System.Drawing.Bitmap> libras;

        public Principal()
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
            imagens = new List<Bitmap>();
            imagens.Add(paLibras.Properties.Resources.a_br);
            imagens.Add(paLibras.Properties.Resources.b_br);
            imagens.Add(paLibras.Properties.Resources.c_br);
            imagens.Add(paLibras.Properties.Resources.d_br);
            imagens.Add(paLibras.Properties.Resources.e_br);
            imagens.Add(paLibras.Properties.Resources.f_br);
            imagens.Add(paLibras.Properties.Resources.g_br);
            imagens.Add(paLibras.Properties.Resources.h_br);
            imagens.Add(paLibras.Properties.Resources.i_br);
            imagens.Add(paLibras.Properties.Resources.j_br);
            imagens.Add(paLibras.Properties.Resources.k_br);
            imagens.Add(paLibras.Properties.Resources.l_br);
            imagens.Add(paLibras.Properties.Resources.m_br);
            imagens.Add(paLibras.Properties.Resources.n_br);
            imagens.Add(paLibras.Properties.Resources.o_br);
            imagens.Add(paLibras.Properties.Resources.p_br);
            imagens.Add(paLibras.Properties.Resources.q_br);
            imagens.Add(paLibras.Properties.Resources.r_br);
            imagens.Add(paLibras.Properties.Resources.s_br);
            imagens.Add(paLibras.Properties.Resources.t_br);
            imagens.Add(paLibras.Properties.Resources.u_br);
            imagens.Add(paLibras.Properties.Resources.v_br);
            imagens.Add(paLibras.Properties.Resources.w_br);
            imagens.Add(paLibras.Properties.Resources.x_br);;
            imagens.Add(paLibras.Properties.Resources.y_br);
            imagens.Add(paLibras.Properties.Resources.z_br);

            libras = new List<Bitmap>();
            libras.Add(paLibras.Properties.Resources.a_big);
            libras.Add(paLibras.Properties.Resources.b_big);
            libras.Add(paLibras.Properties.Resources.c_big);
            libras.Add(paLibras.Properties.Resources.d_big);
            libras.Add(paLibras.Properties.Resources.e_big);
            libras.Add(paLibras.Properties.Resources.f_big);
            libras.Add(paLibras.Properties.Resources.g_big);
            libras.Add(paLibras.Properties.Resources.h_big);
            libras.Add(paLibras.Properties.Resources.i_big);
            libras.Add(paLibras.Properties.Resources.j_big);
            libras.Add(paLibras.Properties.Resources.k_big);
            libras.Add(paLibras.Properties.Resources.l_big);
            libras.Add(paLibras.Properties.Resources.m_big);
            libras.Add(paLibras.Properties.Resources.n_big);
            libras.Add(paLibras.Properties.Resources.o_big);
            libras.Add(paLibras.Properties.Resources.p_big);
            libras.Add(paLibras.Properties.Resources.q_big);
            libras.Add(paLibras.Properties.Resources.r_big);
            libras.Add(paLibras.Properties.Resources.s_big);
            libras.Add(paLibras.Properties.Resources.t_big);
            libras.Add(paLibras.Properties.Resources.u_big);
            libras.Add(paLibras.Properties.Resources.v_big);
            libras.Add(paLibras.Properties.Resources.w_big);
            libras.Add(paLibras.Properties.Resources.x_big);
            libras.Add(paLibras.Properties.Resources.y_big);
            libras.Add(paLibras.Properties.Resources.z_big);

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
            imgImagem.Image = imagens.ElementAt(Posicao);
            imgLetra.Image = libras.ElementAt(Posicao);
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

            if (Posicao == 25)
            {
                btnProxima.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnJogoMemoria_Click(object sender, EventArgs e)
        {
            paLibras.Memoria memoria = new paLibras.Memoria();
            memoria.Show();
        }

        private void btnJogoForca_Click(object sender, EventArgs e)
        {
            paLibras.Forca forca = new paLibras.Forca();
            forca.Show();
        }

        private void btnJogoAdivinha_Click(object sender, EventArgs e)
        {
            paLibras.Adivinhacao advinha = new paLibras.Adivinhacao();
            advinha.Show();
        }

    }
}
