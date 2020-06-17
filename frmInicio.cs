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
    public partial class frmInicio : Form
    {
        private frmContacto contacto;
        private frmPago pago;
        public frmInicio()
        {
            InitializeComponent();
            contacto = new frmContacto();
            pago = new frmPago();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupMicros1.Visible = true;

            //groupMother.Visible = false;
            //groupDisco.Visible = false;
            //groupMemoria.Visible = false;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contacto.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pago.Show();
            Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupMicro2_Enter(object sender, EventArgs e)
        {

        }

        private void mother_Click(object sender, EventArgs e)
        {
            groupMicros1.Visible = false;

            //groupMother.Visible = true;

            //groupDisco.Visible = false;
            //groupMemoria.Visible = false;
        }
    }
}