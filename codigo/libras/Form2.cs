using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace libras
{
    public partial class Form2 : Form
    {
        int Posicao1 = 0;
        int Posicao2 = 0;
        DataTable Alfabeto1;
        DataTable Alfabeto2;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BuscarDoBanco1();
            CarregarImagem1();
            BuscarDoBanco2();
            CarregarImagem2();
        }

        private void BuscarDoBanco1()
        {
            Alfabeto1 = new DataTable();
            Alfabeto1.Columns.Add("idAlfabeto");
            Alfabeto1.Columns.Add("imagem");
            //Alfabeto1.Columns.Add("libras");

            Alfabeto1.Rows.Add("A", @"C:\UNA\Imagens\a_img.jpg");
            Alfabeto1.Rows.Add("B", @"C:\UNA\Imagens\b_img.jpg");
            Alfabeto1.Rows.Add("C", @"C:\UNA\Imagens\c_img.jpg");
            Alfabeto1.Rows.Add("D", @"C:\UNA\Imagens\d_img.jpg");
            Alfabeto1.Rows.Add("E", @"C:\UNA\Imagens\e_img.jpg");
            Alfabeto1.Rows.Add("F", @"C:\UNA\Imagens\f_img.jpg");
            Alfabeto1.Rows.Add("G", @"C:\UNA\Imagens\g_img.jpg");
            Alfabeto1.Rows.Add("H", @"C:\UNA\Imagens\h_img.jpg");
            Alfabeto1.Rows.Add("I", @"C:\UNA\Imagens\i_img.jpg");
            Alfabeto1.Rows.Add("J", @"C:\UNA\Imagens\j_img.jpg");
            Alfabeto1.Rows.Add("K", @"C:\UNA\Imagens\k_img.jpg");
            Alfabeto1.Rows.Add("L", @"C:\UNA\Imagens\l_img.jpg");
            Alfabeto1.Rows.Add("M", @"C:\UNA\Imagens\m_img.jpg");
            Alfabeto1.Rows.Add("N", @"C:\UNA\Imagens\n_img.jpg");
            Alfabeto1.Rows.Add("O", @"C:\UNA\Imagens\o_img.jpg");
            Alfabeto1.Rows.Add("P", @"C:\UNA\Imagens\p_img.jpg");
            Alfabeto1.Rows.Add("Q", @"C:\UNA\Imagens\q_img.jpg");
            Alfabeto1.Rows.Add("R", @"C:\UNA\Imagens\r_img.jpg");
            Alfabeto1.Rows.Add("S", @"C:\UNA\Imagens\s_img.jpg");
            Alfabeto1.Rows.Add("T", @"C:\UNA\Imagens\t_img.jpg");
            Alfabeto1.Rows.Add("U", @"C:\UNA\Imagens\u_img.jpg");
            Alfabeto1.Rows.Add("V", @"C:\UNA\Imagens\v_img.jpg");
            Alfabeto1.Rows.Add("W", @"C:\UNA\Imagens\x_img.jpg");
            Alfabeto1.Rows.Add("X", @"C:\UNA\Imagens\w_img.jpg");
            Alfabeto1.Rows.Add("Y", @"C:\UNA\Imagens\y_img.jpg");
            Alfabeto1.Rows.Add("Z", @"C:\UNA\Imagens\z_img.jpg");

        }

        private void BuscarDoBanco2()
        {
            Alfabeto2 = new DataTable();
            Alfabeto2.Columns.Add("idAlfabeto");
            Alfabeto2.Columns.Add("libras");

            Alfabeto2.Rows.Add("A", @"C:\UNA\Imagens\a.jpg");
            Alfabeto2.Rows.Add("B", @"C:\UNA\Imagens\b.jpg");
            Alfabeto2.Rows.Add("C", @"C:\UNA\Imagens\c.jpg");
            Alfabeto2.Rows.Add("D", @"C:\UNA\Imagens\d.jpg");
            Alfabeto2.Rows.Add("E", @"C:\UNA\Imagens\e.jpg");
            Alfabeto2.Rows.Add("F", @"C:\UNA\Imagens\f.jpg");
            Alfabeto2.Rows.Add("G", @"C:\UNA\Imagens\g.jpg");
            Alfabeto2.Rows.Add("H", @"C:\UNA\Imagens\h.jpg");
            Alfabeto2.Rows.Add("I", @"C:\UNA\Imagens\i.jpg");
            Alfabeto2.Rows.Add("J", @"C:\UNA\Imagens\j.jpg");
            Alfabeto2.Rows.Add("K", @"C:\UNA\Imagens\k.jpg");
            Alfabeto2.Rows.Add("L", @"C:\UNA\Imagens\l.jpg");
            Alfabeto2.Rows.Add("M", @"C:\UNA\Imagens\m.jpg");
            Alfabeto2.Rows.Add("N", @"C:\UNA\Imagens\n.jpg");
            Alfabeto2.Rows.Add("O", @"C:\UNA\Imagens\o.jpg");
            Alfabeto2.Rows.Add("P", @"C:\UNA\Imagens\p.jpg");
            Alfabeto2.Rows.Add("Q", @"C:\UNA\Imagens\q.jpg");
            Alfabeto2.Rows.Add("R", @"C:\UNA\Imagens\r.jpg");
            Alfabeto2.Rows.Add("S", @"C:\UNA\Imagens\s.jpg");
            Alfabeto2.Rows.Add("T", @"C:\UNA\Imagens\t.jpg");
            Alfabeto2.Rows.Add("U", @"C:\UNA\Imagens\u.jpg");
            Alfabeto2.Rows.Add("V", @"C:\UNA\Imagens\v.jpg");
            Alfabeto2.Rows.Add("W", @"C:\UNA\Imagens\x.jpg");
            Alfabeto2.Rows.Add("X", @"C:\UNA\Imagens\w.jpg");
            Alfabeto2.Rows.Add("Y", @"C:\UNA\Imagens\y.jpg");
            Alfabeto2.Rows.Add("Z", @"C:\UNA\Imagens\z.jpg");

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

        private void CarregarImagem1()
        {
            string idAlfabeto = Alfabeto1.Rows[Posicao1]["idAlfabeto"].ToString();
            string imagem = Alfabeto1.Rows[Posicao1]["imagem"].ToString();
            //string libras = Alfabeto1.Rows[Posicao1]["libras"].ToString();
            pictureBox1.ImageLocation = imagem;
            lblSelecao1.Text = idAlfabeto;

            BotoesDeNavegacao1();
        }

        private void CarregarImagem2()
        {
            string idAlfabeto = Alfabeto2.Rows[Posicao2]["idAlfabeto"].ToString();
            string libras = Alfabeto2.Rows[Posicao2]["libras"].ToString();
            pictureBox2.ImageLocation = libras;
            lblSelecao2.Text = idAlfabeto;
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
