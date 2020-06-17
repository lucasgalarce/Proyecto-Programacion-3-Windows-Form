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
        
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            if ((txtUsuario.Text == "Admin") && (txtContrasena.Text == "passadmin")) {

                MessageBox.Show("Bienvenido a WEST BYTE / Admin Mode", "Welcome",MessageBoxButtons.OK);

                frmInicio inicio = new frmInicio();
                inicio.Show();

                this.Hide();


                //frmAdmin administrador = new frmAdmin();
                //administrador.show();
                //this.hide();
            }
        //    if((txtUsuario.Text != "") && (txtContrasena.Text != ""))
        //    {
        //        if ()
        //        {

                    
        //            MessageBox.Show("Se Ingreso Satisfactoriamente", "Ingreso con Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //           
        //        }
        //        else
        //        {
        //            MessageBox.Show("El Usuario o la Contraseña es Incorrecta", "Error 604", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }



           // }
            else
            {
               MessageBox.Show("Complete todos los campos", "Error 500", MessageBoxButtons.OK, MessageBoxIcon.Error);

           }


            


        }



        private void link_Registrarse_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();

            this.Hide();
        }
    }
}
