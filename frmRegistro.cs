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
    public partial class frmRegistro : Form
    {
        private frmLogin login;
        public frmRegistro()
        {
            InitializeComponent();
            //login = new frmLogin();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //login.Show();
        }
    }
}
