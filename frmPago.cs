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
    public partial class frmPago : Form
    {
        private frmInicio inicio;
        public frmPago()
        {
            InitializeComponent();
            //inicio = new frmInicio();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inicio = new frmInicio();
            inicio.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
