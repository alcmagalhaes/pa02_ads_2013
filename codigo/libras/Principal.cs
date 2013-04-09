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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void nível1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.TopLevel = false;
            frmCadastro.Left = this.panel1.Width / 2 - frmCadastro.Width / 2;
            frmCadastro.Top = this.panel1.Height / 2 - frmCadastro.Height / 2;
            this.panel1.Controls.Add(frmCadastro);
            frmCadastro.Show();
        }

        private void nível2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.TopLevel = false;
            frmLogin.Left = this.panel1.Width / 2 - frmLogin.Width / 2;
            frmLogin.Top = this.panel1.Height / 2 - frmLogin.Height / 2;
            this.panel1.Controls.Add(frmLogin);
            frmLogin.Show();
        }

        private void examesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemas frmSistemas = new frmSistemas();
            frmSistemas.TopLevel = false;
            frmSistemas.Left = this.panel1.Width / 2 - frmSistemas.Width / 2;
            frmSistemas.Top = this.panel1.Height / 2 - frmSistemas.Height / 2;
            this.panel1.Controls.Add(frmSistemas);
            frmSistemas.Show();
        }

       
    }
}
