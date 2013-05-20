using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoDaMemoria2
{
    public partial class Form1 : Form
    {
        System.Drawing.Bitmap bitmap0 = JogoDaMemoria2.Properties.Resources.fundo;

        //Libras
        System.Drawing.Bitmap bitmap1 = JogoDaMemoria2.Properties.Resources.a;
        System.Drawing.Bitmap bitmap3 = JogoDaMemoria2.Properties.Resources.b;
        System.Drawing.Bitmap bitmap5 = JogoDaMemoria2.Properties.Resources.c;
        System.Drawing.Bitmap bitmap7 = JogoDaMemoria2.Properties.Resources.d;
        System.Drawing.Bitmap bitmap9 = JogoDaMemoria2.Properties.Resources.e;
        System.Drawing.Bitmap bitmap11 = JogoDaMemoria2.Properties.Resources.f;
        System.Drawing.Bitmap bitmap13 = JogoDaMemoria2.Properties.Resources.g;
        System.Drawing.Bitmap bitmap15 = JogoDaMemoria2.Properties.Resources.h;
        System.Drawing.Bitmap bitmap17 = JogoDaMemoria2.Properties.Resources.i;
        System.Drawing.Bitmap bitmap19 = JogoDaMemoria2.Properties.Resources.j;
        System.Drawing.Bitmap bitmap21 = JogoDaMemoria2.Properties.Resources.k;
        System.Drawing.Bitmap bitmap23 = JogoDaMemoria2.Properties.Resources.l;
        System.Drawing.Bitmap bitmap25 = JogoDaMemoria2.Properties.Resources.m;
        System.Drawing.Bitmap bitmap27 = JogoDaMemoria2.Properties.Resources.n;
        System.Drawing.Bitmap bitmap29 = JogoDaMemoria2.Properties.Resources.o;
        System.Drawing.Bitmap bitmap31 = JogoDaMemoria2.Properties.Resources.p;
        System.Drawing.Bitmap bitmap33 = JogoDaMemoria2.Properties.Resources.q;
        System.Drawing.Bitmap bitmap35 = JogoDaMemoria2.Properties.Resources.r;
        System.Drawing.Bitmap bitmap37 = JogoDaMemoria2.Properties.Resources.s;
        System.Drawing.Bitmap bitmap39 = JogoDaMemoria2.Properties.Resources.t;
        System.Drawing.Bitmap bitmap41 = JogoDaMemoria2.Properties.Resources.u;
        System.Drawing.Bitmap bitmap43 = JogoDaMemoria2.Properties.Resources.v;
        System.Drawing.Bitmap bitmap45 = JogoDaMemoria2.Properties.Resources.w;
        System.Drawing.Bitmap bitmap47 = JogoDaMemoria2.Properties.Resources.x;
        System.Drawing.Bitmap bitmap49 = JogoDaMemoria2.Properties.Resources.y;
        System.Drawing.Bitmap bitmap51 = JogoDaMemoria2.Properties.Resources.z;
        //Portugues
        System.Drawing.Bitmap bitmap2 = JogoDaMemoria2.Properties.Resources.a_br;
        System.Drawing.Bitmap bitmap4 = JogoDaMemoria2.Properties.Resources.b_br;
        System.Drawing.Bitmap bitmap6 = JogoDaMemoria2.Properties.Resources.c_br;
        System.Drawing.Bitmap bitmap8 = JogoDaMemoria2.Properties.Resources.d_br;
        System.Drawing.Bitmap bitmap10 = JogoDaMemoria2.Properties.Resources.e_br;
        System.Drawing.Bitmap bitmap12 = JogoDaMemoria2.Properties.Resources.f_br;
        System.Drawing.Bitmap bitmap14 = JogoDaMemoria2.Properties.Resources.g_br;
        System.Drawing.Bitmap bitmap16 = JogoDaMemoria2.Properties.Resources.h_br;
        System.Drawing.Bitmap bitmap18 = JogoDaMemoria2.Properties.Resources.i_br;
        System.Drawing.Bitmap bitmap20 = JogoDaMemoria2.Properties.Resources.j_br;
        System.Drawing.Bitmap bitmap22 = JogoDaMemoria2.Properties.Resources.k_br;
        System.Drawing.Bitmap bitmap24 = JogoDaMemoria2.Properties.Resources.l_br;
        System.Drawing.Bitmap bitmap26 = JogoDaMemoria2.Properties.Resources.m_br;
        System.Drawing.Bitmap bitmap28 = JogoDaMemoria2.Properties.Resources.n_br;
        System.Drawing.Bitmap bitmap30 = JogoDaMemoria2.Properties.Resources.o_br;
        System.Drawing.Bitmap bitmap32 = JogoDaMemoria2.Properties.Resources.p_br;
        System.Drawing.Bitmap bitmap34 = JogoDaMemoria2.Properties.Resources.q_br;
        System.Drawing.Bitmap bitmap36 = JogoDaMemoria2.Properties.Resources.r_br;
        System.Drawing.Bitmap bitmap38 = JogoDaMemoria2.Properties.Resources.s_br;
        System.Drawing.Bitmap bitmap40 = JogoDaMemoria2.Properties.Resources.t_br;
        System.Drawing.Bitmap bitmap42 = JogoDaMemoria2.Properties.Resources.u_br;
        System.Drawing.Bitmap bitmap44 = JogoDaMemoria2.Properties.Resources.v_br;
        System.Drawing.Bitmap bitmap46 = JogoDaMemoria2.Properties.Resources.w_br;
        System.Drawing.Bitmap bitmap48 = JogoDaMemoria2.Properties.Resources.x_br;
        System.Drawing.Bitmap bitmap50 = JogoDaMemoria2.Properties.Resources.y_br;
        System.Drawing.Bitmap bitmap52 = JogoDaMemoria2.Properties.Resources.z_br;
        
        Object[] imageObjects;
        //Object[] imageLibras;
        //Object[] imagePortugues;
        int[] buttonList = new int[16];
        int[] tempList = new int[16];

        StringBuilder sb = new StringBuilder();
        int[] hide = new int[2];

        bool gameStart = false;
        bool[] flag = new bool[16];

        int[] buttonId = new int[3] { -1, -2, -3 };
        string[] matchingItems = new string[2];

        int timeCount = 0;
        int counter = 0;
        int counter2 = 0;
        int hold;

        public bool GameOver()
        {
            bool signal = true;
            for (int i = 0; i < 16; i++)
            {
                if (flag[i] != true)
                {
                    signal = false;
                    return signal;
                }
            }
            return signal;
        }

        public Form1()
        {
            InitializeComponent();
            this.Reset();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Reiniciando o jogo.";

            counter = 0;
            counter2 = 0;

            /*Inicializando o cronometro*/
            gameStart = false;
            timer2.Stop();
            label2.Text = "0";
            timeCount = 0;
            button17.Enabled = true;

            buttonId[0] = -1;
            buttonId[1] = -2;

            for (int i = 0; i < 16; i++)
            {
                button1.BackgroundImage = button2.BackgroundImage = button3.BackgroundImage = button4.BackgroundImage = button5.BackgroundImage = button6.BackgroundImage = button7.BackgroundImage = button8.BackgroundImage = button9.BackgroundImage = button10.BackgroundImage = button11.BackgroundImage = button12.BackgroundImage = button13.BackgroundImage = button14.BackgroundImage = button15.BackgroundImage = button16.BackgroundImage = bitmap0; 
            }

            this.Reset();
        }

/*
        public string[] Selecao()
        { 

            imageLibras = new Object[26] 
                      {bitmap1, bitmap3, bitmap5, bitmap7, bitmap9, 
                       bitmap11, bitmap13, bitmap15, bitmap17, bitmap19, 
                       bitmap21, bitmap23, bitmap25, bitmap27, bitmap29, 
                       bitmap31, bitmap33, bitmap35, bitmap38, bitmap39, 
                       bitmap41, bitmap43, bitmap45, bitmap47, bitmap49, bitmap51
                      };

            imagePortugues = new Object[26] 
                      {bitmap2, bitmap4, bitmap6, bitmap8, bitmap10, 
                       bitmap12, bitmap14, bitmap16, bitmap18, bitmap20, 
                       bitmap22, bitmap24, bitmap26, bitmap28, bitmap30, 
                       bitmap32, bitmap34, bitmap36, bitmap38, bitmap40, 
                       bitmap42, bitmap44, bitmap46, bitmap48, bitmap50, bitmap51
                      };

            string[] selecao = new string[16];
            //TODO: Selecionar os 8 pares de imagens dentre as 52
            return selecao;
        }
*/
        public void Reset()
        {
            int temp;
   
            //PROBLEMA AQUI
            //imageObjects = new Object[52] { bitmap1, bitmap2, bitmap3, bitmap4, bitmap5, bitmap6, bitmap7, bitmap8, bitmap9, bitmap10, bitmap11, bitmap12, bitmap13, bitmap14, bitmap15, bitmap16, bitmap17, bitmap18, bitmap19, bitmap20, bitmap21, bitmap22, bitmap23, bitmap24, bitmap25, bitmap26, bitmap27, bitmap28, bitmap29, bitmap30, bitmap31, bitmap32, bitmap33, bitmap34, bitmap35, bitmap36, bitmap38, bitmap38, bitmap39, bitmap40, bitmap41, bitmap42, bitmap43, bitmap44, bitmap45, bitmap46, bitmap47, bitmap48, bitmap49, bitmap50, bitmap51, bitmap52 };

            imageObjects = new Object[16] { bitmap1, bitmap2, bitmap3, bitmap4, bitmap5, bitmap6, bitmap7, bitmap8, bitmap9, bitmap10, bitmap11, bitmap12, bitmap13, bitmap14, bitmap15, bitmap16 };
            
            Random gerador = new Random();

            for (int i = 0; i < 16; i++)
            {
                flag[i] = false;
            }

            for (int i = 0; i < 16; i++)
            {
                tempList[i] = -1;
            }

            for (int i = 0; i < 16; i++)
            {
                temp = gerador.Next(16);


                while (IsUsed(temp))
                {
                    temp = gerador.Next(16);

                }

                buttonList[i] = temp;
                tempList[i] = temp;

            }

        }

        private bool IsUsed(int temp)
        {
            bool flags = false;

            for (int i = 0; i < 16; i++)
            {
                if (tempList[i] == temp)
                {
                    flags = true;
                }
            }
            return flags;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            gameStart = true;
            timer2.Enabled = true;
            button18.Enabled = false;
            timeCount = 0;
            textBox1.Text = "O jogo começou!";
            label2.Text = timeCount.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = (++timeCount).ToString();
        }

        public void HideImage(int num)
        {
            switch (num)
            {
                case 0: button1.BackgroundImage = bitmap0;
                    break;
                case 1: button2.BackgroundImage = bitmap0;
                    break;
                case 2: button3.BackgroundImage = bitmap0;
                    break;
                case 3: button4.BackgroundImage = bitmap0;
                    break;
                case 4: button5.BackgroundImage = bitmap0;
                    break;
                case 5: button6.BackgroundImage = bitmap0;
                    break;
                case 6: button7.BackgroundImage = bitmap0;
                    break;
                case 7: button8.BackgroundImage = bitmap0;
                    break;
                case 8: button9.BackgroundImage = bitmap0;
                    break;
                case 9: button10.BackgroundImage = bitmap0;
                    break;
                case 10: button11.BackgroundImage = bitmap0;
                    break;
                case 11: button12.BackgroundImage = bitmap0;
                    break;
                case 12: button13.BackgroundImage = bitmap0;
                    break;
                case 13: button14.BackgroundImage = bitmap0;
                    break;
                case 14: button15.BackgroundImage = bitmap0;
                    break;
                case 15: button16.BackgroundImage = bitmap0;
                    break;
            }
        }

        public string isMatching(int num)
        {
            string result="";

            switch(num)
            {
                case 0: result= "um";
                    break;
                case 1: result= "um";
                    break;
                case 2: result = "dois";
                    break;
                case 3: result = "dois";
                    break;
                case 4: result = "tres";
                    break;
                case 5: result = "tres";
                    break;
                case 6: result = "quatro";
                    break;
                case 7: result = "quatro";
                    break;
                case 8: result = "cinco";
                    break;
                case 9: result = "cinco";
                    break;
                case 10: result = "seis";
                    break;
                case 11: result = "seis";
                    break;
                case 12: result = "sete";
                    break;
                case 13: result = "sete";
                    break;
                case 14: result = "oito";
                    break;
                case 15: result = "oito";
                    break;      
            }
            return result;
        }

        //Botoes
        private void button1_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            { 
                textBox1.Text="Primeiro inicie o jogo!";
                return;
            }

            if (flag[0])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 1;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            
            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            { 
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[0];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 0;

            button1.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(),"Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[1])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 2;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[1];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 1;

            button2.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[2])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 3;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[2];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 2;

            button3.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[3])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 4;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[3];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 3;

            button4.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[4])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 5;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[4];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 4;

            button5.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[5])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 6;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[5];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 5;

            button6.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[6])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 7;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[6];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 6;

            button7.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[7])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 8;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[7];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 7;

            button8.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[8])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 9;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[8];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 8;

            button9.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[9])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 10;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[9];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 9;

            button10.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[10])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 11;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[10];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 10;

            button11.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[11])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 12;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[11];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 11;

            button12.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[12])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 13;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[12];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 12;

            button13.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[13])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 14;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[13];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 13;

            button14.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[14])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 15;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[14];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 14;

            button15.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Primeiro inicie o jogo!";
                return;
            }

            if (flag[15])
            {
                return;
            }

            if (counter2 > 1)
            {
                counter2 = 0;
            }

            buttonId[counter2] = 16;

            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você clicou no mesmo botão!";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }

            counter2++;
            textBox1.Text = "";

            if ((counter > 1) && matchingItems[0] != matchingItems[1])
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                counter = 0;
            }
            else if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }

            if (counter > 1)
            {
                counter = 0;
            }

            hold = buttonList[15];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 15;

            button16.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];

            if ((counter == 1) && matchingItems[0] != matchingItems[1])
            {
                textBox1.Text = "Imagens diferentes!";
            }
            else if ((counter == 1) && matchingItems[0] == matchingItems[1])
            {
                textBox1.Text = "Imagens iguais, muito bem.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                sb.AppendLine("Fim do jogo.");
                sb.AppendLine("Você terminou o jogo em ");
                sb.AppendLine(label2.Text);
                sb.AppendLine(" segundos.");
                MessageBox.Show(sb.ToString(), "Fim de jogo.");
            }

            if ((counter > 1) && matchingItems[0] == matchingItems[1])
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
            }
        }

                

    }
}
