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

            var listaMothers = new List<Mother>();
            listaMothers = Program.getEmpresa().mothersRepo;
            var listaMicros = new List<Micro>();
            listaMicros = Program.getEmpresa().microsRepo;
            var listaMemorias = new List<Memoria>();
            listaMemorias = Program.getEmpresa().memosRepo;
            var listaDiscos = new List<Disco>();
            listaDiscos = Program.getEmpresa().discosRepo;

            int contador = 1;
            foreach (Mother mother in listaMothers)
            {
                if (contador == 1)
                {
                    precioMother1.Text = mother.precio.ToString();
                    stockMother1.Text = mother.stock.ToString();

                } else if (contador == 2)
                {
                    precioMother2.Text = mother.precio.ToString();
                    stockMother2.Text = mother.stock.ToString();

                } else if (contador == 3)
                {
                    precioMother3.Text = mother.precio.ToString();
                    stockMother3.Text = mother.stock.ToString();

                } else if (contador == 4)
                {
                    precioMother4.Text = mother.precio.ToString();
                    stockMother4.Text = mother.stock.ToString();
                }
                contador++;
            }

            contador = 1;
            foreach (Micro micro in listaMicros)
            {

                if (contador == 1)
                {
                    precioMicro1.Text = micro.precio.ToString();
                    stockMicro1.Text = micro.stock.ToString();

                }
                else if (contador == 2)
                {
                    precioMicro2.Text = micro.precio.ToString();
                    stockMicro2.Text = micro.stock.ToString();

                }
                else if (contador == 3)
                {
                    precioMicro3.Text = micro.precio.ToString();
                    stockMicro3.Text = micro.stock.ToString();
                }
                else if (contador == 4)
                {
                    precioMicro4.Text = micro.precio.ToString();
                    stockMicro4.Text = micro.stock.ToString();
                }
                contador++;
            } 

            contador = 1;
            foreach (Memoria memoria in listaMemorias)
            {

                if (contador == 1)
                {
                    precioMemo1.Text = memoria.precio.ToString();
                    stockMemo1.Text = memoria.stock.ToString();

                }
                else if (contador == 2)
                {
                    precioMemo2.Text = memoria.precio.ToString();
                    stockMemo2.Text = memoria.stock.ToString();

                }
                else if (contador == 3)
                {
                    precioMemo3.Text = memoria.precio.ToString();
                    stockMemo3.Text = memoria.stock.ToString();
                }
                else if (contador == 4)
                {
                    precioMemo4.Text = memoria.precio.ToString();
                    stockMemo4.Text = memoria.stock.ToString();
                }
                contador++;
            }

            contador = 1;
            foreach (Disco disco in listaDiscos)
            {

                if (contador == 1)
                {
                    precioDisco1.Text = disco.precio.ToString();
                    stockDisco1.Text = disco.stock.ToString();

                }
                else if (contador == 2)
                {
                    precioDisco2.Text = disco.precio.ToString();
                    stockDisco2.Text = disco.stock.ToString();

                }
                else if (contador == 3)
                {
                    precioDisco3.Text = disco.precio.ToString();
                    stockDisco3.Text = disco.stock.ToString();
                }
                else if (contador == 4)
                {
                    precioDisco4.Text = disco.precio.ToString();
                    stockDisco4.Text = disco.stock.ToString();
                }
                contador++;
            }

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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMother2.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioMother2.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxMother2.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioMother2.Text)).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMicro1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMicro1.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioMicro1.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }else if (!checkBoxMicro1.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioMicro1.Text)).ToString();
            }
            

        }

        private void checkBoxMicro2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMicro2.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioMicro2.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxMicro2.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioMicro2.Text)).ToString();
            }
        }

        private void checkBoxMicro3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMicro3.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioMicro3.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxMicro3.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioMicro3.Text)).ToString();
            }
        }

        private void checkBoxMicro4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMicro4.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioMicro1.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxMicro4.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioMicro1.Text)).ToString();
            }
        }

        private void checkBoxMemoria1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMemoria1.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioMemo1.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxMemoria1.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioMemo1.Text)).ToString();
            }

        }

        private void checkBoxMother1_CheckedChanged(object sender, EventArgs e)
        {

            if(checkBoxMother1.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioMother1.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxMother1.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioMother1.Text)).ToString();
            }

        }

        private void checkBoxMother3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMother3.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioMother3.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxMother3.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioMother3.Text)).ToString();
            }
        }

        private void checkBoxMother4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMother4.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioMother4.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxMother4.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioMother4.Text)).ToString();
            }
        }

        private void checkBoxMemoria2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxMemoria2.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioMemo2.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxMemoria2.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioMemo2.Text)).ToString();
            }
        }

        private void checkBoxMemoria3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMemoria3.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioMemo3.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxMemoria3.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioMemo3.Text)).ToString();
            }
        }

        private void checkBoxMemoria4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMemoria4.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioMemo4.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxMemoria4.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioMemo4.Text)).ToString();
            }
        }

        private void checkBoxDisco1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDisco1.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioDisco1.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxDisco1.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioDisco1.Text)).ToString();
            }
        }

        private void checkBoxDisco2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDisco2.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioDisco2.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxDisco2.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioDisco2.Text)).ToString();
            }
        }

        private void checkBoxDisco3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDisco3.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioDisco3.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxDisco3.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioDisco3.Text)).ToString();
            }
        }

        private void checkBoxDisco4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDisco4.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioDisco4.Text) + Int32.Parse(precioTotal.Text)).ToString();

            }
            else if (!checkBoxDisco4.Checked)
            {
                precioTotal.Text = (Int32.Parse(precioTotal.Text) - Int32.Parse(precioDisco4.Text)).ToString();
            }
        }
    }
}