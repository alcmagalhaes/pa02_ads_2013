using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox[] pictureBox;
        string palavra;
        bool start;
        byte erro = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox = new PictureBox[textBox1.Text.Length];
            palavra = textBox1.Text.ToLower();

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                pictureBox[i] = new PictureBox();
                pictureBox[i].Width = 50;
                pictureBox[i].Height = 50;

                pictureBox[i].Paint += new PaintEventHandler(Form1_Paint);

                flowLayoutPanel1.Controls.Add(pictureBox[i]);
            }

            button1.Enabled = false;
            textBox1.Enabled = false;
            start = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 3), 0, 45, 45, 45);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!start) { return false; }

            if (textBox1.Text.ToLower().Contains(keyData.ToString().ToLower()))
            { Acertou(keyData.ToString()); }
            else
            { Errou(); }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Reiniciar()
        {
            button1.Enabled = true;
            textBox1.Enabled = true;
            start = false;
            textBox1.Text = " ";
            pictureBox1.Image = null;
            erro = 0;
            flowLayoutPanel1.Controls.Clear();
        }

        private void Errou()
        {
            switch (erro)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.part1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.part2;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.part3;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.part4;
                    MessageBox.Show("YOU LOSEEER NOOB !!!! A palavra era: " + textBox1.Text);
                    Reiniciar();
                    break;
            }

            erro++;
        }

        private void Acertou(String key)
        {
            for (int i = 0; i < textBox1.Text.Length; i++ )
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
                MessageBox.Show("You Win ! Agora faz de novo ! :P");
                Reiniciar();
            }

        }
    }
}
