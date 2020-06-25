using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Proyecto_programacion_3
{
    static class Program
    {

      
        public static void Main(string[] args)
        {


            //Usuario u = new Usuario("nacho", "alpedo");
            
            Usuario administrador = new Usuario("Admin", "passadmin");

            UsuariosRepo.ListaUsuarios.Add(administrador);


            //Stream flujo 





            //var xas = new UsuariosRepo();
            //xas.agregar(u);
            //xas.agregar(administrador);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());


            //MicrosRepo.agregarMicros("I3-4700", 5000, "Micro de baja gama", 4);
            //MicrosRepo.agregarMicros("I5-4700", 5000, "Micro de baja gama", 4);
            //MicrosRepo.agregarMicros("I7-4700", 5000, "Micro de baja gama", 4);
            //MicrosRepo.agregarMicros("I9-4700", 5000, "Micro de baja gama", 4);


                                
        }
        //public static void SerializarAlSalir(object sender, EventArgs e)
        //{
        //    Stream flujo2 = File.Create("datos.bin");
        //    BinaryFormatter serializer = new BinaryFormatter();
        //    serializer.Serialize(flujo2, s);  //notar que lo que se serializa es Sistema, y con ello recursivamente todo lo demás
        //    flujo2.Close();
        //    MessageBox.Show("objeto serializado ok. terminando programa.");
        //}


    }


}
