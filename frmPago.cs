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
        private frmLogin login;
        public frmPago()
        {
            InitializeComponent();
            login = new frmLogin();
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
            if(efectivo.Checked)
            {
                MessageBox.Show("Usted va a pagar $" + totalPago.Text + " en efectivo", "West Byte",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            }
            else if (tarjCredito.Checked)
            {
                MessageBox.Show("Usted va a pagar $" + totalPago.Text + " con tarjeta de credito", "West Byte",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            else if (tarjDebito.Checked)
            {
                MessageBox.Show("Usted va a pagar $" + totalPago.Text + " con tarjeta de debito", "West Byte",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            
            foreach(componente producto in Program.getEmpresa().listacompras)
            {
                if (producto is Mother)
                {
                    Program.getEmpresa().buscarMother(producto.nombre).stock -= 1;
                }
                else if (producto is Micro)
                {
                    Program.getEmpresa().buscarMicro(producto.nombre).stock -= 1;
                }
                else if (producto is Memoria)
                {
                    Program.getEmpresa().buscarMemoria(producto.nombre).stock -= 1;
                } 
                else if (producto is Disco)
                {
                    Program.getEmpresa().buscarDisco(producto.nombre).stock -= 1;
                }
            }
            inicio = new frmInicio();
            this.Hide();
            inicio.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir de la aplicacion?", "West Byte",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            var listaCompras = Program.getEmpresa().listacompras;
            double total = 0;
            foreach(componente producto in listaCompras)
            {
                total += producto.precio;
            }
            totalPago.Text = total.ToString();
        }
    }
}
