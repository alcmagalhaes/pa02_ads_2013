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
    public partial class Forca : Form
    {
        public Forca()
        {
            InitializeComponent();
        }

        PictureBox[] pictureBox;
        PictureBox[] pictureBoxErro;
        string palavra;
        bool start = false;
        byte erro = 1;

        private void tecladoVirtual(object sender, EventArgs e)
        {
            if (start)
            {
                ButtonBase key = (ButtonBase)sender;
                ProcessTecladoVirtual(key.Tag.ToString());
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            textBox1.Text = (Connection.BuscaPalavra(rdm.Next(1, 68))).ToUpper();
            pictureBox1.Image = Properties.Resources.F00;
            pictureBox = new PictureBox[textBox1.Text.Length];
            pictureBoxErro = new PictureBox[26];
            palavra = textBox1.Text.ToLower();

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                pictureBox[i] = new PictureBox();
                pictureBox[i].Width = 50;
                pictureBox[i].Height = 50;

                pictureBox[i].Paint += new PaintEventHandler(Form1_Paint);

                flowLayoutPanel1.Controls.Add(pictureBox[i]);
            }

            for (int i = 0; i < 26; i++ )
            {
                pictureBoxErro[i] = new PictureBox();
                pictureBoxErro[i].Width = 50;
                pictureBoxErro[i].Height = 50;

                pictureBoxErro[i].Paint += new PaintEventHandler(Form1_Paint);

                flowLayoutPanel2.Controls.Add(pictureBoxErro[i]);
            }

            button1.Enabled = false;
            textBox1.Enabled = false;
            start = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 0, 45, 45, 45);
        }

        private void ProcessTecladoVirtual(String keyData)
        {
            if (!start) { return; }

            if (textBox1.Text.ToLower().Contains(keyData.ToString().ToLower()))
            { Acertou(keyData.ToString()); }
            else
            { Errou(keyData.ToString()); }
        }

        private void Reiniciar()
        {
            button1.Enabled = true;
            start = false;
            textBox1.Text = " ";
            pictureBox1.Image = null;
            erro = 0;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
        }

        private void Acertou(String key)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i].ToString().ToLower() == key.ToLower())
                {
                    Graphics gra = pictureBox[i].CreateGraphics();
                    gra.DrawString(key, new Font("Tahoma", 25), new SolidBrush(Color.CornflowerBlue), 0, 0);

                    palavra = palavra.Replace(key.ToLower(), "");
                }
            }

            if (palavra.Trim() == "")
            {
                MessageBox.Show("Parabéns :D !!!");
                Reiniciar();
            }

        }

        private void Pintar(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 0, 45, 45, 45);
        }

        private void Errou(string key)
        {
            for (int i = 0; i < 26; i++)
            {
                if ("".Equals(pictureBoxErro[i].Tag) || pictureBoxErro[i].Tag == null)
                {
                    Graphics gra = pictureBoxErro[i].CreateGraphics();
                    gra.DrawString(key, new Font("Tahoma", 25), new SolidBrush(Color.Red), 0, 0);
                    pictureBoxErro[i].Tag = key;
                    break;
                }
            }
         
            switch (erro)
            { 
                case 1:
                    pictureBox1.Image = Properties.Resources.F01;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.F02;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.F03;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.F04;
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources.F05;
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources.F06;
                    MessageBox.Show("Você Perdeu :(");
                    Reiniciar();
                    break;                
            }

            erro++;
            
        }
        
    }
}
