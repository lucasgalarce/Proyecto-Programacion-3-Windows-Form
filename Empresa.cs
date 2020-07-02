using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_programacion_3
{


    [Serializable]
    class Usuario
    {

        public string nombre;
        public string contrasena;
        
        public Usuario(string nombre, string contrasena)
        {

            this.nombre = nombre;
            this.contrasena = contrasena;
            

        }

        public bool existeEnLista(Usuario u)
        {

            return ((this.nombre == u.nombre) && (this.contrasena == u.contrasena));

        }


    }

    [Serializable]
    class Micro
    {
        public string nombre;
        public string descripcion;
        public double precio;
        public int stock;
        public Micro(string nombre, double precio, string descripcion, int stock)
        {

            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
            this.stock = stock;

        }
    }

    [Serializable]
    class Mother
    {
        public string nombre;
        public string descripcion;
        public double precio;
        public int stock;
        public Mother(string nombre, double precio, string descripcion, int stock)
        {

            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
            this.stock = stock;

        }
    }


    [Serializable]
    class Disco
    {
        public string nombre;
        public string descripcion;
        public double precio;
        public int stock;
        public Disco(string nombre, double precio, string descripcion, int stock)
        {

            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
            this.stock = stock;

        }
    }


    [Serializable]
    class Memoria
    {
        public string nombre;
        public string descripcion;
        public double precio;
        public int stock;
        public Memoria(string nombre, double precio, string descripcion, int stock)
        {

            this.nombre = nombre;
            this.precio = precio;
            this.descripcion = descripcion;
            this.stock = stock;

        }
    }





    class Empresa
    {

        public List<Usuario> usuariosRepo;
        public List<Micro> microsRepo;
        public List<Mother> mothersRepo;
        public List<Disco> discosRepo;
        public List<Memoria> memosRepo;

        public Empresa()
        {   
            usuariosRepo = new List<Usuario>();
            microsRepo = new List<Micro>();
            mothersRepo = new List<Mother>();
            discosRepo = new List<Disco>();
            memosRepo = new List<Memoria>();

        }


        public bool agregarUsuario(Usuario u)
        {

            usuariosRepo.Add(u);
            return true;

        }

        public bool buscarUsuario(Usuario u)
        {

            foreach (Usuario user in this.usuariosRepo)
            {

                if (u.existeEnLista(user))
                {

                    return true;

                }

            }

            return false;
        }
















    }
}
