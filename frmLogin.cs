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
      
        private void btn_Login_Click(object sender, EventArgs e)
        {

            Usuario findUser = new Usuario(txtUsuario.Text, txtContrasena.Text);
           

            if (Program.getEmpresa().buscarAdministrador(findUser))
            {
                MessageBox.Show("Bienvenido a WEST BYTE / Admin Mode", "Welcome", MessageBoxButtons.OK);
                frmAdmin frmAdministrador = new frmAdmin();

                frmAdministrador.Show();
                this.Hide();

            }
            else if ((txtUsuario.Text != "") && (txtContrasena.Text != ""))
            {
                if (Program.getEmpresa().buscarUsuario(findUser))
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


        // revisar cerrar
        //private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Desea salir de la aplicacion?", "CoronaManagement 2020",
        //        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //    else
        //    {
        //        Application.ExitThread();
        //    }
        //}
    }
}