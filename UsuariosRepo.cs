using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_programacion_3
{
    class UsuariosRepo
    {
        static List<Usuario> ListaUsuarios = new List<Usuario>();

        public static void agregarUsuario(string nombre, string contrasena)
        {

            Usuario nuevoUsuario = new Usuario(nombre, contrasena);

            ListaUsuarios.Add(nuevoUsuario);
         

        }


    }
}


