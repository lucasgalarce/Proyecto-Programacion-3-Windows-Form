using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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
        //(txtUsuario.Text == "Admin") && (txtContrasena.Text == "passadmin")
        private void btn_Login_Click(object sender, EventArgs e)
        {
            Usuario UsuarioBuscado = new Usuario(txtUsuario.Text,txtContrasena.Text);
            
            if ((txtUsuario.Text == "Admin") && (txtContrasena.Text == "passadmin"))
            {

                MessageBox.Show("Bienvenido a WEST BYTE / Admin Mode", "Welcome", MessageBoxButtons.OK);


                frmAdmin administrador = new frmAdmin();
                administrador.Show();
                this.Hide();

            }

            if ((txtUsuario.Text != "") && (txtContrasena.Text != ""))
            {
                

                if (UsuariosRepo.buscarUsuario(txtUsuario.Text,txtContrasena.Text))
                {

                    MessageBox.Show("Se Ingreso Satisfactoriamente", "Ingreso con Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmInicio inicio = new frmInicio();
                    inicio.Show();

                    this.Hide();

                }
                else
                {

                    MessageBox.Show("El Usuario o la Contraseña es Incorrecta", "Error 604", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
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
