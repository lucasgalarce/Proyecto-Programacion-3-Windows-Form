using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_programacion_3
{
    public partial class frmLogin : Form
    {
        private frmInicio inicio;
        private frmRegistro registro;
        public frmLogin()
        {
            InitializeComponent();
            inicio = new frmInicio();
            registro = new frmRegistro();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registro.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
