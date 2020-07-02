using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace Proyecto_programacion_3
{
    static class Program
    {
        public static Empresa emp;

        public static Empresa getEmpresa()
        {
            return emp;
        }

        public static void cargarDatosEmp()
        {
            try
            {
                Stream flujoArchivo = File.OpenRead("westByte.bin");
                BinaryFormatter deserialializador = new BinaryFormatter();
                emp = (Empresa)deserialializador.Deserialize(flujoArchivo);
                flujoArchivo.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine("cargamos la Informacion: " + ex.Message);
                emp = new Empresa();

            }
        }

        public static void guardarDatos(object sender, EventArgs e)
        {
            Stream flujoArchivo = File.Create("westByte.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujoArchivo, emp);
            flujoArchivo.Close();
        }

        static void Main()
        {
            cargarDatosEmp();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new System.EventHandler(guardarDatos);
            Application.Run(new frmLogin());               
        }
    }
}