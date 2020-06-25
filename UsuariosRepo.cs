using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_programacion_3
{
    class UsuariosRepo
    {
        public static List<Usuario> ListaUsuarios = new List<Usuario>();
        public static List<Usuario> pruebauser;

        public static void agregarUsuario(string nombre, string contrasena)
        {

            Usuario nuevoUsuario = new Usuario(nombre, contrasena);

            ListaUsuarios.Add(nuevoUsuario);
         

        }
        //cambios para probar
        //public UsuariosRepo()
        //{
        //    pruebauser = new List<Usuario>();
        //}
        // OJO ACA
        //public void agregar(Usuario u)
        //{

        //    pruebauser.Add(u);
        //}

        public static bool buscarUsuario(string nombre, string contrasena)
        {


            foreach (Usuario _usuario in ListaUsuarios)
            {

                if(_usuario.nombre == nombre && _usuario.contrasena == contrasena)
                {

                    return true;

                    
                }



            }
            return false;
        }
    }
}


