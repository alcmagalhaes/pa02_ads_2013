using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace paLibras
{
    public partial class Adivinhacao : Form
    {
        Random rdm = new Random();
        int Posicao1 = 0;
        int Posicao2 = 0;
        List<System.Drawing.Bitmap> imagens1;
        List<System.Drawing.Bitmap> imagens2;

        public Adivinhacao()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Posicao1 = rdm.Next(0, 25);
            Posicao2 = rdm.Next(0, 25);
            BuscarDoBanco1();
            CarregarImagem1();
            BuscarDoBanco2();
            CarregarImagem2();
        }

        private void BuscarDoBanco1()
        {
            imagens1 = new List<Bitmap>();

            imagens1.Add(paLibras.Properties.Resources.a_img);
            imagens1.Add(paLibras.Properties.Resources.b_img);
            imagens1.Add(paLibras.Properties.Resources.c_img);
            imagens1.Add(paLibras.Properties.Resources.d_img);
            imagens1.Add(paLibras.Properties.Resources.e_img);
            imagens1.Add(paLibras.Properties.Resources.f_img);
            imagens1.Add(paLibras.Properties.Resources.g_img);
            imagens1.Add(paLibras.Properties.Resources.h_img);
            imagens1.Add(paLibras.Properties.Resources.i_img);
            imagens1.Add(paLibras.Properties.Resources.j_img);
            imagens1.Add(paLibras.Properties.Resources.k_img);
            imagens1.Add(paLibras.Properties.Resources.l_img);
            imagens1.Add(paLibras.Properties.Resources.m_img);
            imagens1.Add(paLibras.Properties.Resources.n_img);
            imagens1.Add(paLibras.Properties.Resources.o_img);
            imagens1.Add(paLibras.Properties.Resources.p_img);
            imagens1.Add(paLibras.Properties.Resources.q_img);
            imagens1.Add(paLibras.Properties.Resources.r_img);
            imagens1.Add(paLibras.Properties.Resources.s_img);
            imagens1.Add(paLibras.Properties.Resources.t_img);
            imagens1.Add(paLibras.Properties.Resources.u_img);
            imagens1.Add(paLibras.Properties.Resources.v_img);
            imagens1.Add(paLibras.Properties.Resources.w_img);
            imagens1.Add(paLibras.Properties.Resources.x_img);
            imagens1.Add(paLibras.Properties.Resources.y_img);
            imagens1.Add(paLibras.Properties.Resources.z_img);

        }

        private void BuscarDoBanco2()
        {
            imagens2 = new List<Bitmap>();

            imagens2.Add(paLibras.Properties.Resources.a);
            imagens2.Add(paLibras.Properties.Resources.b);
            imagens2.Add(paLibras.Properties.Resources.c);
            imagens2.Add(paLibras.Properties.Resources.d);
            imagens2.Add(paLibras.Properties.Resources.e);
            imagens2.Add(paLibras.Properties.Resources.f);
            imagens2.Add(paLibras.Properties.Resources.g);
            imagens2.Add(paLibras.Properties.Resources.h);
            imagens2.Add(paLibras.Properties.Resources.i);
            imagens2.Add(paLibras.Properties.Resources.j);
            imagens2.Add(paLibras.Properties.Resources.k);
            imagens2.Add(paLibras.Properties.Resources.l);
            imagens2.Add(paLibras.Properties.Resources.m);
            imagens2.Add(paLibras.Properties.Resources.n);
            imagens2.Add(paLibras.Properties.Resources.o);
            imagens2.Add(paLibras.Properties.Resources.p);
            imagens2.Add(paLibras.Properties.Resources.q);
            imagens2.Add(paLibras.Properties.Resources.r);
            imagens2.Add(paLibras.Properties.Resources.s);
            imagens2.Add(paLibras.Properties.Resources.t);
            imagens2.Add(paLibras.Properties.Resources.u);
            imagens2.Add(paLibras.Properties.Resources.v);
            imagens2.Add(paLibras.Properties.Resources.w);
            imagens2.Add(paLibras.Properties.Resources.x);
            imagens2.Add(paLibras.Properties.Resources.y);
            imagens2.Add(paLibras.Properties.Resources.z);

        }

        private void BotoesDeNavegacao1()
        {
            btnImagBack.Enabled = true;
            btnImagnext.Enabled = true;

            if (Posicao1 == 0)
            {
                btnImagBack.Enabled = false;
            }

            if (Posicao1 == 25)
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

            if (Posicao2 == 25)
            {
                BtnLetraNext.Enabled = false;
            }
        }

        private void CarregarImagem1()
        {
            pictureBox1.Image = imagens1.ElementAt(Posicao1);
            BotoesDeNavegacao1();
        }

        private void CarregarImagem2()
        {
            pictureBox2.Image = imagens2.ElementAt(Posicao2);
            BotoesDeNavegacao2();
        }

        private void btnImagBack_Click(object sender, EventArgs e)
        {
            Posicao1 = Posicao1 - 1;
            CarregarImagem1();
        }

        private void btnImagnext_Click(object sender, EventArgs e)
        {
            Posicao1 = Posicao1 + 1;
            CarregarImagem1();
        }

        private void BtnLetraback_Click(object sender, EventArgs e)
        {
            Posicao2 = Posicao2 - 1;
            CarregarImagem2();
        }

        private void BtnLetraNext_Click(object sender, EventArgs e)
        {
            Posicao2 = Posicao2 + 1;
            CarregarImagem2();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Posicao1 == Posicao2)
            {
                MessageBox.Show("Sucesso!!!");
                Form2_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Errou!!!");
            }
        }
    }
}
