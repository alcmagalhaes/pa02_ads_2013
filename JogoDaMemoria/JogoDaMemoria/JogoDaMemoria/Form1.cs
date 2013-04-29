/*Programmed by Galen Goforth 06-15-08
 * Memory Game
*/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;

namespace Memory
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class frmMain : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem mnuNewGame;
        private System.Windows.Forms.MenuItem mnuResetScore;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn17;
        private System.Windows.Forms.Button btn18;
        private System.Windows.Forms.Button btn19;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn24;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn26;
        private System.Windows.Forms.Button btn27;
        private System.Windows.Forms.Button btn28;
        private System.Windows.Forms.Button btn29;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Button btn34;
        private System.Windows.Forms.Button btn35;
        private System.Windows.Forms.Button btn36;
        private System.Windows.Forms.Button btn37;
        private System.Windows.Forms.Button btn38;
        private System.Windows.Forms.Button btn39;
        private System.Windows.Forms.Button btn40;
        private System.Windows.Forms.Button btn41;
        private System.Windows.Forms.Button[] _buttonArray;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblHighScore2;
        private System.Windows.Forms.Label lblHighScore3;
        private IContainer components;

        public frmMain()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuNewGame = new System.Windows.Forms.MenuItem();
            this.mnuResetScore = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn17 = new System.Windows.Forms.Button();
            this.btn18 = new System.Windows.Forms.Button();
            this.btn19 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn24 = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn26 = new System.Windows.Forms.Button();
            this.btn27 = new System.Windows.Forms.Button();
            this.btn28 = new System.Windows.Forms.Button();
            this.btn29 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.btn34 = new System.Windows.Forms.Button();
            this.btn35 = new System.Windows.Forms.Button();
            this.btn36 = new System.Windows.Forms.Button();
            this.btn37 = new System.Windows.Forms.Button();
            this.btn38 = new System.Windows.Forms.Button();
            this.btn39 = new System.Windows.Forms.Button();
            this.btn40 = new System.Windows.Forms.Button();
            this.btn41 = new System.Windows.Forms.Button();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblHighScore2 = new System.Windows.Forms.Label();
            this.lblHighScore3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuNewGame,
            this.mnuResetScore,
            this.mnuExit});
            this.menuItem1.Text = "&File";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Index = 0;
            this.mnuNewGame.Text = "New &Game";
            this.mnuNewGame.Click += new System.EventHandler(this.mnuNewGame_Click_1);
            // 
            // mnuResetScore
            // 
            this.mnuResetScore.Index = 1;
            this.mnuResetScore.Text = "Reset Scores";
            this.mnuResetScore.Click += new System.EventHandler(this.mnuResetScore_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 2;
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click_1);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAbout});
            this.menuItem2.Text = "&Help";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 0;
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(8, 8);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(64, 48);
            this.btn0.TabIndex = 42;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(80, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 48);
            this.btn1.TabIndex = 43;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(152, 8);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(64, 48);
            this.btn2.TabIndex = 44;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(224, 8);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(64, 48);
            this.btn3.TabIndex = 45;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(296, 8);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 48);
            this.btn4.TabIndex = 46;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(368, 8);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 48);
            this.btn5.TabIndex = 47;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(440, 8);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(64, 48);
            this.btn6.TabIndex = 48;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(8, 64);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 48);
            this.btn7.TabIndex = 49;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(80, 64);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 48);
            this.btn8.TabIndex = 50;
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(152, 64);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(64, 48);
            this.btn9.TabIndex = 51;
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(224, 64);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(64, 48);
            this.btn10.TabIndex = 52;
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(296, 64);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(64, 48);
            this.btn11.TabIndex = 53;
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(368, 64);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(64, 48);
            this.btn12.TabIndex = 54;
            // 
            // btn13
            // 
            this.btn13.Location = new System.Drawing.Point(440, 64);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(64, 48);
            this.btn13.TabIndex = 55;
            // 
            // btn14
            // 
            this.btn14.Location = new System.Drawing.Point(8, 120);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(64, 48);
            this.btn14.TabIndex = 56;
            // 
            // btn15
            // 
            this.btn15.Location = new System.Drawing.Point(80, 120);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(64, 48);
            this.btn15.TabIndex = 57;
            // 
            // btn16
            // 
            this.btn16.Location = new System.Drawing.Point(152, 120);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(64, 48);
            this.btn16.TabIndex = 58;
            // 
            // btn17
            // 
            this.btn17.Location = new System.Drawing.Point(224, 120);
            this.btn17.Name = "btn17";
            this.btn17.Size = new System.Drawing.Size(64, 48);
            this.btn17.TabIndex = 59;
            // 
            // btn18
            // 
            this.btn18.Location = new System.Drawing.Point(296, 120);
            this.btn18.Name = "btn18";
            this.btn18.Size = new System.Drawing.Size(64, 48);
            this.btn18.TabIndex = 60;
            // 
            // btn19
            // 
            this.btn19.Location = new System.Drawing.Point(368, 120);
            this.btn19.Name = "btn19";
            this.btn19.Size = new System.Drawing.Size(64, 48);
            this.btn19.TabIndex = 61;
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(440, 120);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(64, 48);
            this.btn20.TabIndex = 62;
            // 
            // btn21
            // 
            this.btn21.Location = new System.Drawing.Point(8, 176);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(64, 48);
            this.btn21.TabIndex = 63;
            // 
            // btn22
            // 
            this.btn22.Location = new System.Drawing.Point(80, 176);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(64, 48);
            this.btn22.TabIndex = 64;
            // 
            // btn23
            // 
            this.btn23.Location = new System.Drawing.Point(152, 176);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(64, 48);
            this.btn23.TabIndex = 65;
            // 
            // btn24
            // 
            this.btn24.Location = new System.Drawing.Point(224, 176);
            this.btn24.Name = "btn24";
            this.btn24.Size = new System.Drawing.Size(64, 48);
            this.btn24.TabIndex = 66;
            // 
            // btn25
            // 
            this.btn25.Location = new System.Drawing.Point(296, 176);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(64, 48);
            this.btn25.TabIndex = 67;
            // 
            // btn26
            // 
            this.btn26.Location = new System.Drawing.Point(368, 176);
            this.btn26.Name = "btn26";
            this.btn26.Size = new System.Drawing.Size(64, 48);
            this.btn26.TabIndex = 68;
            // 
            // btn27
            // 
            this.btn27.Location = new System.Drawing.Point(440, 176);
            this.btn27.Name = "btn27";
            this.btn27.Size = new System.Drawing.Size(64, 48);
            this.btn27.TabIndex = 69;
            // 
            // btn28
            // 
            this.btn28.Location = new System.Drawing.Point(8, 232);
            this.btn28.Name = "btn28";
            this.btn28.Size = new System.Drawing.Size(64, 48);
            this.btn28.TabIndex = 70;
            // 
            // btn29
            // 
            this.btn29.Location = new System.Drawing.Point(80, 232);
            this.btn29.Name = "btn29";
            this.btn29.Size = new System.Drawing.Size(64, 48);
            this.btn29.TabIndex = 71;
            // 
            // btn30
            // 
            this.btn30.Location = new System.Drawing.Point(152, 232);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(64, 48);
            this.btn30.TabIndex = 72;
            // 
            // btn31
            // 
            this.btn31.Location = new System.Drawing.Point(224, 232);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(64, 48);
            this.btn31.TabIndex = 73;
            // 
            // btn32
            // 
            this.btn32.Location = new System.Drawing.Point(296, 232);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(64, 48);
            this.btn32.TabIndex = 74;
            // 
            // btn33
            // 
            this.btn33.Location = new System.Drawing.Point(368, 232);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(64, 48);
            this.btn33.TabIndex = 75;
            // 
            // btn34
            // 
            this.btn34.Location = new System.Drawing.Point(440, 232);
            this.btn34.Name = "btn34";
            this.btn34.Size = new System.Drawing.Size(64, 48);
            this.btn34.TabIndex = 76;
            // 
            // btn35
            // 
            this.btn35.Location = new System.Drawing.Point(8, 288);
            this.btn35.Name = "btn35";
            this.btn35.Size = new System.Drawing.Size(64, 48);
            this.btn35.TabIndex = 77;
            // 
            // btn36
            // 
            this.btn36.Location = new System.Drawing.Point(80, 288);
            this.btn36.Name = "btn36";
            this.btn36.Size = new System.Drawing.Size(64, 48);
            this.btn36.TabIndex = 78;
            // 
            // btn37
            // 
            this.btn37.Location = new System.Drawing.Point(152, 288);
            this.btn37.Name = "btn37";
            this.btn37.Size = new System.Drawing.Size(64, 48);
            this.btn37.TabIndex = 79;
            // 
            // btn38
            // 
            this.btn38.Location = new System.Drawing.Point(224, 288);
            this.btn38.Name = "btn38";
            this.btn38.Size = new System.Drawing.Size(64, 48);
            this.btn38.TabIndex = 80;
            // 
            // btn39
            // 
            this.btn39.Location = new System.Drawing.Point(296, 288);
            this.btn39.Name = "btn39";
            this.btn39.Size = new System.Drawing.Size(64, 48);
            this.btn39.TabIndex = 81;
            // 
            // btn40
            // 
            this.btn40.Location = new System.Drawing.Point(368, 288);
            this.btn40.Name = "btn40";
            this.btn40.Size = new System.Drawing.Size(64, 48);
            this.btn40.TabIndex = 82;
            // 
            // btn41
            // 
            this.btn41.Location = new System.Drawing.Point(440, 288);
            this.btn41.Name = "btn41";
            this.btn41.Size = new System.Drawing.Size(64, 48);
            this.btn41.TabIndex = 83;
            // 
            // lblGuess
            // 
            this.lblGuess.Location = new System.Drawing.Point(12, 339);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(100, 24);
            this.lblGuess.TabIndex = 84;
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(115, 339);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(100, 23);
            this.lblScore.TabIndex = 85;
            // 
            // lblHighScore
            // 
            this.lblHighScore.Location = new System.Drawing.Point(192, 339);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(168, 16);
            this.lblHighScore.TabIndex = 86;
            // 
            // lblHighScore2
            // 
            this.lblHighScore2.Location = new System.Drawing.Point(356, 339);
            this.lblHighScore2.Name = "lblHighScore2";
            this.lblHighScore2.Size = new System.Drawing.Size(76, 16);
            this.lblHighScore2.TabIndex = 87;
            // 
            // lblHighScore3
            // 
            this.lblHighScore3.Location = new System.Drawing.Point(440, 339);
            this.lblHighScore3.Name = "lblHighScore3";
            this.lblHighScore3.Size = new System.Drawing.Size(79, 16);
            this.lblHighScore3.TabIndex = 88;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(520, 377);
            this.Controls.Add(this.lblHighScore3);
            this.Controls.Add(this.lblHighScore2);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.btn41);
            this.Controls.Add(this.btn40);
            this.Controls.Add(this.btn39);
            this.Controls.Add(this.btn38);
            this.Controls.Add(this.btn37);
            this.Controls.Add(this.btn36);
            this.Controls.Add(this.btn35);
            this.Controls.Add(this.btn34);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn29);
            this.Controls.Add(this.btn28);
            this.Controls.Add(this.btn27);
            this.Controls.Add(this.btn26);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.btn24);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn19);
            this.Controls.Add(this.btn18);
            this.Controls.Add(this.btn17);
            this.Controls.Add(this.btn16);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn14);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.Run(new frmMain());
        }

        //declare class level variables
        bool bln_isFirst = true, bln_isMatch = false;

        //create array to hold random numbers to randomize pics
        private int[] intBoard = new int[43];

        //create array to hold random numbers to fill board array
        private int[] intStorage = new int[250];

        //create arrays from files to hold high scores.
        int[] intHighScores = new int[3];
        string[] strUser = new string[3];

        //create int and file name variables to keep track of buttons, pictures, guesses, and score
        private int intCount2, intCount3, intCount4, intCount5, intGuess, intScore;
        private string strFileName;
        private string ImgLocation;

        //declare random number object
        Random generateRandom;

        private void ClickHandler(object sender, System.EventArgs e)
        {
            //button handler...temporarily set button to false visibility and not enabled
            Button tempButton = (Button)sender;
            intCount4 = (tempButton.TabIndex - 42);

            //store last int Count2 for checking match and button use.
            intCount3 = intCount2;

            //set random number for passing to find file name
            intCount2 = intBoard[intCount4];
            ImgLocation = checkNumbers(intCount2);
            tempButton.Image = Image.FromFile(ImgLocation);
            tempButton.Enabled = false;
            buttonEvents(tempButton, intCount2, intCount3, intCount4);

            //set pause for second turn so player can see pictures
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(100);
            }
        }
        private void buttonEvents(Button tempButton, int intCount2, int intCount3, int intCount4)
        {
            if (bln_isFirst == true)
            {
                bln_isFirst = false;
                intCount5 = intCount4;
            }
            else
            {
                bln_isFirst = true;
                bln_isMatch = checkMatch(intCount2, intCount3);
                // if not a match refresh buttons
                if (bln_isMatch == false)
                {
                    tempButton.Enabled = true;
                    tempButton.Image = null;
                    _buttonArray[intCount5].Enabled = true;
                    _buttonArray[intCount5].Image = null;
                    intGuess -= 1;
                }
                else
                {
                    intScore += 10;
                }
            }
            if (intGuess <= 0)
            {
                MessageBox.Show("game over");
                for (int r = 0; r < 42; r++)
                {
                    _buttonArray[r].Enabled = false;
                }
                if (intScore > intHighScores[0])
                {
                    //move old high scores down one spot
                    intHighScores[2] = intHighScores[1];
                    intHighScores[1] = intHighScores[0];
                    intHighScores[0] = intScore;
                    //show the User Input Form
                    strUser[0] = Interaction.InputBox("Congratulations", "New High Score", "Please enter your name:", 10, 10);

                }
                else if (intScore > intHighScores[1] && intScore <= intHighScores[0])
                {
                    //move middle high score down one spot
                    intHighScores[2] = intHighScores[1];
                    intHighScores[1] = intScore;
                    //show the User Input Form
                    strUser[1] = Interaction.InputBox("Congratulations", "New High Score", "Please enter your name:", 10, 10);
                }
                else if (intScore > intHighScores[2] && intScore <= intHighScores[1])
                {
                    intHighScores[2] = intScore;
                    //show the User Input Form
                    strUser[2] = Interaction.InputBox("Congratulations", "New High Score", "Please enter your name:", 10, 10);
                }
                //write new high scores strings to the highscores file
                StreamWriter HighScoreStreamWriter = new StreamWriter(Directory.GetCurrentDirectory() + @"\Pictures\HighScores.txt", false);
                for (int g = 0; g < 3; g++)
                {
                    HighScoreStreamWriter.WriteLine(intHighScores[g]);
                }
                HighScoreStreamWriter.Close();
                //write new names strings to the user file
                StreamWriter NamesStreamWriter = new StreamWriter(Directory.GetCurrentDirectory() + @"\Pictures\User.txt", false);
                for (int b = 0; b < 3; b++)
                {
                    NamesStreamWriter.WriteLine(strUser[b]);
                }
                NamesStreamWriter.Close();
            }
            else
            {
                //display the score and guesses left
                lblGuess.Text = "Trys Left: " + intGuess.ToString();
                lblScore.Text = "Score: " + intScore.ToString();
            }
        }

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            newGame();
        }

        private void newGame()
        {
            intScore = 0;
            bln_isFirst = true;
            bln_isMatch = false;
            //create bln variable to check if random #'s exist in board array already
            bool bln_isSame = false;

            //display the score and guesses left
            lblGuess.Text = "Trys Left: " + intGuess.ToString();
            lblScore.Text = "Score: " + intScore.ToString();


            //set high scores arrays from files and display on label
            try
            {
                StreamReader highScoresStreamReader = new StreamReader(Directory.GetCurrentDirectory() + @"\Pictures\HighScores.txt");
                while (highScoresStreamReader.Peek() != -1)
                {
                    for (int a = 0; a < 3; a++)
                        intHighScores[a] = int.Parse(highScoresStreamReader.ReadLine());
                }
                highScoresStreamReader.Close();
            }
            catch
            {
                MessageBox.Show("File Reading Error1");
            }

            //set user array from files and display on label
            try
            {
                StreamReader userStreamReader = new StreamReader(Directory.GetCurrentDirectory() + @"\Pictures\User.txt");
                while (userStreamReader.Peek() != -1)
                {
                    for (int a = 0; a < 3; a++)
                        strUser[a] = userStreamReader.ReadLine();
                }
                userStreamReader.Close();
            }
            catch
            {
                MessageBox.Show("File Reading Error1");
            }
            lblHighScore.Text = "HighScores:    " + strUser[0] + "..." + intHighScores[0];
            lblHighScore2.Text = strUser[1] + "..." + intHighScores[1];
            lblHighScore3.Text = strUser[2] + "..." + intHighScores[2];

            //set number of guesses
            intGuess = 13;
            //seed the random number function
            DateTime dtmCurrent = DateTime.Now;
            generateRandom = new Random(dtmCurrent.Millisecond);
            _buttonArray = new Button[42] {
											  btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9,btn10, 
											  btn11, btn12, btn13, btn14, btn15, btn16, btn17, btn18, btn19,
											  btn20, btn21, btn22, btn23, btn24, btn25, btn26, btn27, btn28,
											  btn29,btn30, btn31, btn32, btn33, btn34, btn35, btn36, btn37,
											  btn38, btn39, btn40, btn41};
            for (int i = 0; i < 42; i++)
            {
                //ensure that the event only called once
                this._buttonArray[i].Click -= this.ClickHandler;

                //set new click handler
                this._buttonArray[i].Click += new System.EventHandler(this.ClickHandler);

                //enable all buttons and set images to null
                _buttonArray[i].Enabled = true;
                _buttonArray[i].Image = null;
            }
            //fill array with random #'s from 1 to 42
            int intAdd = 0, intCount1;
            for (int r = 0; r < 200; r++)
            {
                intStorage[r] = generateRandom.Next(1, 43);
            }
            for (intCount1 = 0; intCount1 < 250; intCount1++)
            {
                bln_isSame = false;
                if (intAdd < 43)
                {
                    //check to see if array already contains generated #
                    foreach (int intBoard1 in intBoard)
                    {
                        if (intStorage[intCount1] == intBoard1)
                        {
                            bln_isSame = true;
                        }
                    }
                    //fill board array with random non matching #'s
                    if (bln_isSame == false && intStorage[intCount1] != 0)
                    {
                        intBoard[intAdd] = intStorage[intCount1];
                        intAdd++;
                    }
                }
            }
        }
        private string checkNumbers(int intCount2)
        {
            //get file name for button image
            if (intCount2 == 1 || intCount2 == 2 || intCount2 == 3 || intCount2 == 4 || intCount2 == 5 || intCount2 == 6)
            {
                strFileName = Directory.GetCurrentDirectory() + @"\Pictures\pic1.bmp";
            }
            else if (intCount2 == 7 || intCount2 == 8 || intCount2 == 9 || intCount2 == 10 || intCount2 == 11 || intCount2 == 12)
            {
                strFileName = Directory.GetCurrentDirectory() + @"\Pictures\pic2.bmp";
            }
            else if (intCount2 == 13 || intCount2 == 14 || intCount2 == 15 || intCount2 == 16 || intCount2 == 17 || intCount2 == 18)
            {
                strFileName = Directory.GetCurrentDirectory() + @"\Pictures\pic3.bmp";
            }
            else if (intCount2 == 19 || intCount2 == 20 || intCount2 == 21 || intCount2 == 22 || intCount2 == 23 || intCount2 == 24)
            {
                strFileName = Directory.GetCurrentDirectory() + @"\Pictures\pic4.bmp";
            }
            else if (intCount2 == 25 || intCount2 == 26 || intCount2 == 27 || intCount2 == 28 || intCount2 == 29 || intCount2 == 30)
            {
                strFileName = Directory.GetCurrentDirectory() + @"\Pictures\pic5.bmp";
            }
            else if (intCount2 == 31 || intCount2 == 32 || intCount2 == 33 || intCount2 == 34 || intCount2 == 35 || intCount2 == 36)
            {
                strFileName = Directory.GetCurrentDirectory() + @"\Pictures\pic6.bmp";
            }
            else if (intCount2 == 37 || intCount2 == 38 || intCount2 == 39 || intCount2 == 40 || intCount2 == 41 || intCount2 == 42 || intCount2 == 43)
            {
                strFileName = Directory.GetCurrentDirectory() + @"\Pictures\pic7.bmp";
            }
            return strFileName;
        }

        private bool checkMatch(int intCount3, int intCount2)
        {
            //check to see if the images match and return true/false value
            bool blnMatch = false;
            if (intCount2 >= 1 && intCount2 <= 6)
            {

                if (intCount3 >= 1 && intCount3 <= 6)
                {
                    blnMatch = true;
                }

                else
                {
                    blnMatch = false;
                }
            }

            else if (intCount2 >= 7 && intCount2 <= 12)
            {
                if (intCount3 >= 7 && intCount3 <= 12)
                {
                    blnMatch = true;
                }
                else
                {
                    blnMatch = false;
                }
            }

            else if (intCount2 >= 13 && intCount2 <= 18)
            {
                if (intCount3 >= 13 && intCount3 <= 18)
                {
                    blnMatch = true;
                }
                else
                {
                    blnMatch = false;
                }
            }

            else if (intCount2 >= 19 && intCount2 <= 24)
            {
                if (intCount3 >= 19 && intCount3 <= 24)
                {
                    blnMatch = true;
                }
                else
                {
                    blnMatch = false;
                }
            }

            else if (intCount2 >= 25 && intCount2 <= 30)
            {
                if (intCount3 >= 25 && intCount3 <= 30)
                {
                    blnMatch = true;
                }
                else
                {
                    blnMatch = false;
                }
            }

            else if (intCount2 >= 31 && intCount2 <= 36)
            {
                if (intCount3 >= 31 && intCount3 <= 36)
                {
                    blnMatch = true;
                }
                else
                {
                    blnMatch = false;
                }
            }

            else if (intCount2 >= 37 && intCount2 <= 42)
            {
                if (intCount3 >= 37 && intCount3 <= 42)
                {
                    blnMatch = true;
                }
                else
                {
                    blnMatch = false;
                }
            }
            return blnMatch;
        }

        private void mnuNewGame_Click_1(object sender, System.EventArgs e)
        {
            //call newGame method
            newGame();
        }

        private void mnuResetScore_Click(object sender, System.EventArgs e)
        {
            //write name string to the user file
            StreamWriter NameStreamWriter = new StreamWriter(Directory.GetCurrentDirectory() + @"\Pictures\User.txt", false);
            for (int p = 0; p < 3; p++)
            {
                NameStreamWriter.WriteLine("NAME");
            }
            NameStreamWriter.Close();

            //write 0 strings to the highscores file
            StreamWriter hScoreStreamWriter = new StreamWriter(Directory.GetCurrentDirectory() + @"\Pictures\HighScores.txt", false);
            for (int p = 0; p < 3; p++)
            {
                hScoreStreamWriter.WriteLine("0");
            }
            hScoreStreamWriter.Close();
        }

        private void mnuExit_Click_1(object sender, System.EventArgs e)
        {
            //close this application
            this.Close();
        }

        private void mnuAbout_Click(object sender, System.EventArgs e)
        {
            //display 'programmed by' message
            MessageBox.Show("Programmed by: Galen Goforth");
        }
    }
}
