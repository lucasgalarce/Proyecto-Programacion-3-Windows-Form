using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

      

        private void mother_Click(object sender, EventArgs e)
        {
            groupMicros1.Visible = false;
            groupMother1.Visible = true;
            groupDisco1.Visible = false;
            groupMemoria1.Visible = false;

           
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

            
            groupMicros1.Location = new Point(73, 189);
            groupMother1.Location = new Point(73, 189);
            groupMemoria1.Location = new Point(73, 189);
            groupDisco1.Location = new Point(73, 189);

            
        }

        private void Micro1_Click(object sender, EventArgs e)
        {
            groupMicros1.Visible = true;          
            groupMother1.Visible = false;
            groupDisco1.Visible = false;
            groupMemoria1.Visible = false;

        }

        private void ram_Click(object sender, EventArgs e)
        {
            groupMicros1.Visible = false;
            groupMother1.Visible = false;
            groupDisco1.Visible = false;
            groupMemoria1.Visible = true;
        }

        private void disk_Click(object sender, EventArgs e)
        {
            groupMicros1.Visible = false;
            groupMother1.Visible = false;
            groupDisco1.Visible = true;
            groupMemoria1.Visible = false;
        }
    }
}