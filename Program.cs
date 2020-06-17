using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_programacion_3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());


            MicrosRepo.agregarMicros("I3-4700", 5000, "Micro de baja gama", 4);
            MicrosRepo.agregarMicros("I5-4700", 5000, "Micro de baja gama", 4);
            MicrosRepo.agregarMicros("I7-4700", 5000, "Micro de baja gama", 4);
            MicrosRepo.agregarMicros("I9-4700", 5000, "Micro de baja gama", 4);

        }


       
    }


}
