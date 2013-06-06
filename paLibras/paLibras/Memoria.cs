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
    public partial class Memoria : Form
    {

/*Images...*/

        System.Drawing.Bitmap defaultImage = paLibras.Properties.Resources.MLIBRAS;
        System.Drawing.Bitmap bitmap11 = paLibras.Properties.Resources.Ma;
        System.Drawing.Bitmap bitmap12 = paLibras.Properties.Resources.Ma_br;
        System.Drawing.Bitmap bitmap21 = paLibras.Properties.Resources.Mb;
        System.Drawing.Bitmap bitmap22 = paLibras.Properties.Resources.Mb_br;
        System.Drawing.Bitmap bitmap31 = paLibras.Properties.Resources.Mc;
        System.Drawing.Bitmap bitmap32 = paLibras.Properties.Resources.Mc_br;
        System.Drawing.Bitmap bitmap41 = paLibras.Properties.Resources.Md;
        System.Drawing.Bitmap bitmap42 = paLibras.Properties.Resources.Md_br;
        System.Drawing.Bitmap bitmap51 = paLibras.Properties.Resources.Me;
        System.Drawing.Bitmap bitmap52 = paLibras.Properties.Resources.Me_br;
        System.Drawing.Bitmap bitmap61 = paLibras.Properties.Resources.Mf;
        System.Drawing.Bitmap bitmap62 = paLibras.Properties.Resources.Mf_br;
        System.Drawing.Bitmap bitmap71 = paLibras.Properties.Resources.Mg;
        System.Drawing.Bitmap bitmap72 = paLibras.Properties.Resources.Mg_br;
        System.Drawing.Bitmap bitmap81 = paLibras.Properties.Resources.Mh;
        System.Drawing.Bitmap bitmap82 = paLibras.Properties.Resources.Mh_br;

        Object[] imageObjects;
        int[] buttonList=new int[16];
        int[] tempList = new int[16];

        StringBuilder stringBuilder = new StringBuilder();
        int[] hide = new int[2];

        bool gameStart = false;
        bool[] flag=new bool[16];

        int[] buttonId = new int[3]{-1,-2,-3};
        string[] matchingItems = new string [2];

        int timeCount = 0;
        int counter = 0;
        int counter2 = 0;
        int hold;

        /*Game over...*/

        public bool GameOver()
        {
            bool signal = true;

            for (int i = 0; i < 16; i++)
            {
                if(flag[i] != true)
                {
                    signal = false;
                    return signal;
                }
            }
            return signal;
        }

        /*Restarting...*/

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Jogo reiniciado.";
            
            counter = 0;
            counter2 = 0;

            /*Timer initialization*/
            gameStart = false;
            timer2.Stop();
            label2.Text = "0";
            timeCount = 0;
            button18.Enabled = true;

            buttonId[0] = -1;
            buttonId[1] = -2;
            for (int i = 0; i < 16; i++)
            {
                button1.BackgroundImage = button2.BackgroundImage = button3.BackgroundImage = button3.BackgroundImage = button4.BackgroundImage = button5.BackgroundImage = button6.BackgroundImage = button7.BackgroundImage =  button8.BackgroundImage= button9.BackgroundImage= button10.BackgroundImage= button11.BackgroundImage= button12.BackgroundImage= button13.BackgroundImage= button14.BackgroundImage= button15.BackgroundImage= button16.BackgroundImage=defaultImage; 
            }
            this.Reset();
        }

        /*Default Constructor*/
        
        public Memoria()
        {
            InitializeComponent();
            this.Reset();
        }
      
        /*Initializations...*/

        public void Reset()
        {
            int temp;
            imageObjects = new Object[16] { bitmap11, bitmap12, bitmap21, bitmap22, bitmap31, bitmap32, bitmap41, bitmap42, bitmap51, bitmap52, bitmap61, bitmap62, bitmap71, bitmap72, bitmap81, bitmap82 };

            
            Random randomizer = new Random();

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
                temp = randomizer.Next(16);


                while (IsUsed(temp))
                {
                    temp = randomizer.Next(16);

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

        /*Timer...*/

        private void button18_Click(object sender, EventArgs e)
        {
            gameStart = true;

            button1.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];
            button2.BackgroundImage = (Bitmap)imageObjects[buttonList[1]];
            button3.BackgroundImage = (Bitmap)imageObjects[buttonList[2]];
            button4.BackgroundImage = (Bitmap)imageObjects[buttonList[3]];
            button5.BackgroundImage = (Bitmap)imageObjects[buttonList[4]];
            button6.BackgroundImage = (Bitmap)imageObjects[buttonList[5]];
            button7.BackgroundImage = (Bitmap)imageObjects[buttonList[6]];
            button8.BackgroundImage = (Bitmap)imageObjects[buttonList[7]];
            button9.BackgroundImage = (Bitmap)imageObjects[buttonList[8]];
            button10.BackgroundImage = (Bitmap)imageObjects[buttonList[9]];
            button11.BackgroundImage = (Bitmap)imageObjects[buttonList[10]];
            button12.BackgroundImage = (Bitmap)imageObjects[buttonList[11]];
            button13.BackgroundImage = (Bitmap)imageObjects[buttonList[12]];
            button14.BackgroundImage = (Bitmap)imageObjects[buttonList[13]];
            button15.BackgroundImage = (Bitmap)imageObjects[buttonList[14]];
            button16.BackgroundImage = (Bitmap)imageObjects[buttonList[15]];

            timer2.Interval = 5000;
            timer2.Enabled = true;
            timer2.Tick += new System.EventHandler(inicioJogo);

            timeCount = 0;
            button18.Enabled = false;
            textBox1.Text = "Bom jogo.";
            label2.Text = timeCount.ToString();
        }

        private void inicioJogo(object source, EventArgs e)
        {
            for (int i = 0; i < 16; i++)
            {
                HideImage(i);
            }

            timer2.Interval = 1000;
            timer2.Tick -= new System.EventHandler(inicioJogo);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = (++timeCount).ToString();
        }

        /*Matching pairs...*/
        
        public void HideImage(int num)
        {
            switch (num)
            {
                case 0: button1.BackgroundImage = defaultImage;
                    break;
                case 1: button2.BackgroundImage = defaultImage;
                    break;
                case 2: button3.BackgroundImage = defaultImage;
                    break;
                case 3: button4.BackgroundImage = defaultImage;
                    break;
                case 4: button5.BackgroundImage = defaultImage;
                    break;
                case 5: button6.BackgroundImage = defaultImage;
                    break;
                case 6: button7.BackgroundImage = defaultImage;
                    break;
                case 7: button8.BackgroundImage = defaultImage;
                    break;
                case 8: button9.BackgroundImage = defaultImage;
                    break;
                case 9: button10.BackgroundImage = defaultImage;
                    break;
                case 10: button11.BackgroundImage = defaultImage;
                    break;
                case 11: button12.BackgroundImage = defaultImage;
                    break;
                case 12: button13.BackgroundImage = defaultImage;
                    break;
                case 13: button14.BackgroundImage = defaultImage;
                    break;
                case 14: button15.BackgroundImage = defaultImage;
                    break;
                case 15: button16.BackgroundImage = defaultImage;
                    break;

            }
 
        }
        public string isMatching(int num)
        {
            string result = "";

            switch(num)
            {
                case 0: result = "finder";
                    break;
                case 1: result = "finder";
                    break;
                case 2: result = "folder";
                    break;
                case 3: result = "folder";
                    break;
                case 4: result = "folderstar";
                    break;
                case 5: result = "folderstar";
                    break;
                case 6: result = "hard";
                    break;
                case 7: result = "hard";
                    break;
                case 8: result = "hat";
                    break;
                case 9: result = "hat";
                    break;
                case 10: result = "rocket";
                    break;
                case 11: result = "rocket";
                    break;
                case 12: result = "starblue";
                    break;
                case 13: result = "starblue";
                    break;
                case 14: result = "starred";
                    break;
                case 15: result = "starred";
                    break;
                
            }

            return result;

         }

        /* Buttons...*/

        private void button1_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }   
            
            if (flag[0])
            {
                return;
            }

            //////////////////////////////////////////
            
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 1;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;

            ///////////////////////////////////////////

            textBox1.Text = "";

            if ( (counter>1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
               
                counter = 0;
            }
            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;
 
            }

            if (counter > 1)
            { counter = 0; }

                                  
            hold=buttonList[0];
            matchingItems[counter] = isMatching(hold);
            

            hide[counter] = 0;
           
            button1.BackgroundImage = (Bitmap)imageObjects[buttonList[0]];


            if ((matchingItems[0] != matchingItems[1]) && counter==1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }

            counter++;

            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }


            ////////////////////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            ///////////////////////////
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }
            
            if (flag[1])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 2;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////

            textBox1.Text = "";

            if ( (counter>1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                
                counter = 0;
            }
            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }
                                                
            hold=buttonList[1];
            matchingItems[counter] = isMatching(hold);


            hide[counter] = 1;
            
            button2.BackgroundImage = (Bitmap)imageObjects[buttonList[1]];

            if ((matchingItems[0] != matchingItems[1]) && counter==1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }
            counter++;

            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////

            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }
            
            if (flag[2])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 3;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter>1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                
                counter = 0;
            }
            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }

            
            hold = buttonList[2];
            matchingItems[counter] = isMatching(hold);


            hide[counter] = 2;
            button3.BackgroundImage = (Bitmap)imageObjects[buttonList[2]];
            if ((matchingItems[0] != matchingItems[1]) && counter==1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }
            counter++;

            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////

            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }  
            if (flag[3])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 4;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);
                
                counter = 0;
            }
            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[3];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 3;

            button4.BackgroundImage = (Bitmap)imageObjects[buttonList[3]];

            if ((matchingItems[0] != matchingItems[1]) && counter==1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }
            counter++;

            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////

            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                return;
            }  
            if (flag[4])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 5;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);

                counter = 0;
            }
            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[4];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 4;

            button5.BackgroundImage = (Bitmap)imageObjects[buttonList[4]];
            if ((matchingItems[0] != matchingItems[1]) && counter==1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }
            counter++;
            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////
            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }  
            if (flag[5])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 6;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);

                counter = 0;
            }

            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[5];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 5;

            button6.BackgroundImage = (Bitmap)imageObjects[buttonList[5]];
            if ((matchingItems[0] != matchingItems[1]) && counter==1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }
            counter++;
            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////
            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }  
            if (flag[6])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 7;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);

                counter = 0;
            }

            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[6];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 6;

            button7.BackgroundImage = (Bitmap)imageObjects[buttonList[6]];
            if ((matchingItems[0] != matchingItems[1]) && counter==1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }
            counter++;
            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////
            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }  
            if (flag[7])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 8;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);

                counter = 0;
            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[7];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 7;

            button8.BackgroundImage = (Bitmap)imageObjects[buttonList[7]];

            if ((matchingItems[0] != matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }
            counter++;
            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////
            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }  
            if (flag[8])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 9;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);

                counter = 0;
            }

            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[8];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 8;
            button9.BackgroundImage = (Bitmap)imageObjects[buttonList[8]];

            if ((matchingItems[0] != matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }

            counter++;
            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////
            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }  
            if (flag[9])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 10;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);

                counter = 0;
            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[9];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 9;

            button10.BackgroundImage = (Bitmap)imageObjects[buttonList[9]];
            if ((matchingItems[0] != matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }

            counter++;
            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////
            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }  
            if (flag[10])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 11;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);

                counter = 0;
            }

            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[10];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 10;

            button11.BackgroundImage = (Bitmap)imageObjects[buttonList[10]];
            if ((matchingItems[0] != matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }

            counter++;
            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////
            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }  
            if (flag[11])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 12;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);

                counter = 0;
            }

            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[11];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 11;

            button12.BackgroundImage = (Bitmap)imageObjects[buttonList[11]];
            if ((matchingItems[0] != matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }

            counter++;
            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////
            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }  
            if (flag[12])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 13;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);

                counter = 0;
            }

            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[12];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 12;

            button13.BackgroundImage = (Bitmap)imageObjects[buttonList[12]];

            if ((matchingItems[0] != matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }

            counter++;
            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////
            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }  
            if (flag[13])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 14;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);

                counter = 0;
            }

            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[13];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 13;

            button14.BackgroundImage = (Bitmap)imageObjects[buttonList[13]];
            if ((matchingItems[0] != matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            counter++;
            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////
            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }  
            if (flag[14])
            {
                return;
            }
            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 15;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);

                counter = 0;
            }

            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[14];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 14;

            button15.BackgroundImage = (Bitmap)imageObjects[buttonList[14]];

            if ((matchingItems[0] != matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }

            counter++;
            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////
            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                textBox1.Text = "Por favor, inicie o jogo.";
                return;
            }  
            if (flag[15])
            {
                return;
            }

            //////////////////////////////////////////
            if (counter2 > 1)
            {
                counter2 = 0;
            }
            buttonId[counter2] = 16;
            if (buttonId[0] == buttonId[1])
            {
                textBox1.Text = "Você apertou o mesmo botão.";
                buttonId[counter2] = -10;
                return;
            }
            else if ((counter == 1) && buttonId[0] != buttonId[1])
            {
                buttonId[0] = -1;
                buttonId[1] = -2;
            }
            counter2++;
            ///////////////////////////////////////////
            textBox1.Text = "";

            if ((counter > 1) && (matchingItems[0] != matchingItems[1]))
            {
                HideImage(hide[0]);
                HideImage(hide[1]);

                counter = 0;
            }

            else if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }

            if (counter > 1)
            { counter = 0; }

            hold = buttonList[15];
            matchingItems[counter] = isMatching(hold);

            hide[counter] = 15;

            button16.BackgroundImage = (Bitmap)imageObjects[buttonList[15]];

            if ((matchingItems[0] != matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Imagens diferentes.";

            }
            else if ((matchingItems[0] == matchingItems[1]) && counter == 1)
            {
                textBox1.Text = "Bom trabalho.";
            }

            counter++;
            //////////////
            if ((counter > 1) && (matchingItems[0] == matchingItems[1]))
            {
                flag[hide[0]] = true;
                flag[hide[1]] = true;

            }
            //////////////
            if (GameOver())
            {
                timer2.Stop();
                stringBuilder.AppendLine("Bom trabalho.");
                stringBuilder.AppendLine("Continue estudando.");
                stringBuilder.Append(label2.Text);
                stringBuilder.Append(" segundos");
                MessageBox.Show(stringBuilder.ToString(), "Fim de Jogo.");
            }
        }             
    }
}
