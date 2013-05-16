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

        System.Drawing.Bitmap bitmap1 = JogoDaMemoria2.Properties.Resources.a;
        System.Drawing.Bitmap bitmap2 = JogoDaMemoria2.Properties.Resources.a_br;
        System.Drawing.Bitmap bitmap3 = JogoDaMemoria2.Properties.Resources.b;
        System.Drawing.Bitmap bitmap4 = JogoDaMemoria2.Properties.Resources.b_br;
        System.Drawing.Bitmap bitmap5 = JogoDaMemoria2.Properties.Resources.c;
        System.Drawing.Bitmap bitmap6 = JogoDaMemoria2.Properties.Resources.c_br;
        System.Drawing.Bitmap bitmap7 = JogoDaMemoria2.Properties.Resources.d;
        System.Drawing.Bitmap bitmap8 = JogoDaMemoria2.Properties.Resources.d_br;
        System.Drawing.Bitmap bitmap9 = JogoDaMemoria2.Properties.Resources.e;
        System.Drawing.Bitmap bitmap10 = JogoDaMemoria2.Properties.Resources.e_br;
        System.Drawing.Bitmap bitmap11 = JogoDaMemoria2.Properties.Resources.f;
        System.Drawing.Bitmap bitmap12 = JogoDaMemoria2.Properties.Resources.f_br;
        System.Drawing.Bitmap bitmap13 = JogoDaMemoria2.Properties.Resources.g;
        System.Drawing.Bitmap bitmap14 = JogoDaMemoria2.Properties.Resources.g_br;
        System.Drawing.Bitmap bitmap15 = JogoDaMemoria2.Properties.Resources.h;
        System.Drawing.Bitmap bitmap16 = JogoDaMemoria2.Properties.Resources.h_br;
        System.Drawing.Bitmap bitmap17 = JogoDaMemoria2.Properties.Resources.i;
        System.Drawing.Bitmap bitmap18 = JogoDaMemoria2.Properties.Resources.i_br;
        System.Drawing.Bitmap bitmap19 = JogoDaMemoria2.Properties.Resources.j;
        System.Drawing.Bitmap bitmap20 = JogoDaMemoria2.Properties.Resources.j_br;
        System.Drawing.Bitmap bitmap21 = JogoDaMemoria2.Properties.Resources.k;
        System.Drawing.Bitmap bitmap22 = JogoDaMemoria2.Properties.Resources.k_br;
        System.Drawing.Bitmap bitmap23 = JogoDaMemoria2.Properties.Resources.l;
        System.Drawing.Bitmap bitmap24 = JogoDaMemoria2.Properties.Resources.l_br;
        System.Drawing.Bitmap bitmap25 = JogoDaMemoria2.Properties.Resources.m;
        System.Drawing.Bitmap bitmap26 = JogoDaMemoria2.Properties.Resources.m_br;
        System.Drawing.Bitmap bitmap27 = JogoDaMemoria2.Properties.Resources.n;
        System.Drawing.Bitmap bitmap28 = JogoDaMemoria2.Properties.Resources.n_br;
        System.Drawing.Bitmap bitmap29 = JogoDaMemoria2.Properties.Resources.o;
        System.Drawing.Bitmap bitmap30 = JogoDaMemoria2.Properties.Resources.o_br;
        System.Drawing.Bitmap bitmap31 = JogoDaMemoria2.Properties.Resources.p;
        System.Drawing.Bitmap bitmap32 = JogoDaMemoria2.Properties.Resources.p_br;
        System.Drawing.Bitmap bitmap33 = JogoDaMemoria2.Properties.Resources.q;
        System.Drawing.Bitmap bitmap34 = JogoDaMemoria2.Properties.Resources.q_br;
        System.Drawing.Bitmap bitmap35 = JogoDaMemoria2.Properties.Resources.r;
        System.Drawing.Bitmap bitmap36 = JogoDaMemoria2.Properties.Resources.r_br;
        System.Drawing.Bitmap bitmap37 = JogoDaMemoria2.Properties.Resources.s;
        System.Drawing.Bitmap bitmap38 = JogoDaMemoria2.Properties.Resources.s_br;
        System.Drawing.Bitmap bitmap39 = JogoDaMemoria2.Properties.Resources.t;
        System.Drawing.Bitmap bitmap40 = JogoDaMemoria2.Properties.Resources.t_br;
        System.Drawing.Bitmap bitmap41 = JogoDaMemoria2.Properties.Resources.u;
        System.Drawing.Bitmap bitmap42 = JogoDaMemoria2.Properties.Resources.u_br;
        System.Drawing.Bitmap bitmap43 = JogoDaMemoria2.Properties.Resources.v;
        System.Drawing.Bitmap bitmap44 = JogoDaMemoria2.Properties.Resources.v_br;
        System.Drawing.Bitmap bitmap45 = JogoDaMemoria2.Properties.Resources.w;
        System.Drawing.Bitmap bitmap46 = JogoDaMemoria2.Properties.Resources.w_br;
        System.Drawing.Bitmap bitmap47 = JogoDaMemoria2.Properties.Resources.x;
        System.Drawing.Bitmap bitmap48 = JogoDaMemoria2.Properties.Resources.x_br;
        System.Drawing.Bitmap bitmap49 = JogoDaMemoria2.Properties.Resources.y;
        System.Drawing.Bitmap bitmap50 = JogoDaMemoria2.Properties.Resources.y_br;
        System.Drawing.Bitmap bitmap51 = JogoDaMemoria2.Properties.Resources.z;
        System.Drawing.Bitmap bitmap52 = JogoDaMemoria2.Properties.Resources.z_br;
        
        Object[] imageObjects;
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
                    return signal = false;
                }
            }
            return signal;
        }

        public Form1()
        {
            InitializeComponent();
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

        public string[] Selecao()
        { 
            string[] selecao = new string[16];
            
            /*TODO: Selecionar os 8 pares de imagens dentre as 52*/
            
            return selecao;
        }

        public void Reset()
        {
            int temp;
            imageObjects = new Object[52] { bitmap1, bitmap2, bitmap3, bitmap4, bitmap5, bitmap6, bitmap7, bitmap8, bitmap9, bitmap10, bitmap11, bitmap12, bitmap13, bitmap14, bitmap15, bitmap16, bitmap17, bitmap18, bitmap19, bitmap20, bitmap21, bitmap22, bitmap23, bitmap24, bitmap25, bitmap26, bitmap27, bitmap28, bitmap29, bitmap30, bitmap31, bitmap32, bitmap33, bitmap34, bitmap35, bitmap36, bitmap37, bitmap38, bitmap39, bitmap40, bitmap41, bitmap42, bitmap43, bitmap44, bitmap45, bitmap46, bitmap47, bitmap48, bitmap49, bitmap50, bitmap51, bitmap52 };

            Random gerador = new Random();



        }

    }
}
