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
        public frmLogin()
        {
            InitializeComponent();
            inicio = new frmInicio();
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
            this.Hide();
        }
    }
}
