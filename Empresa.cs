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
    class componente
    {
        public string nombre;
        public double precio;
        public int stock;
        public componente(string nombre, double precio, int stock)
        {

            this.nombre = nombre;
            this.precio = precio;            
            this.stock = stock;

        }
            


}

    [Serializable]
    class Micro : componente
    {
        
        public Micro(string nombre, double precio, int stock) : base(nombre, precio, stock)
        {

        }
        public Micro existeEnLista(Micro m)
        {
            return m;
        }

    }

    [Serializable]
    class Mother : componente
    {
        
        public Mother(string nombre, double precio, int stock) : base(nombre, precio, stock)
        {
          
        }
    }

    [Serializable]
    class Disco : componente
    {
      
        public Disco(string nombre, double precio,  int stock) : base(nombre, precio, stock)
        {
            
        }
    }

    [Serializable]
    class Memoria : componente
    {
        
        public Memoria(string nombre, double precio, int stock) : base(nombre, precio,  stock)
        {

        }
       
    }

    [Serializable]
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

            Usuario administrador = new Usuario("admin", "admin");
            usuariosRepo.Add(administrador);

            Micro micro1 = new Micro("i3 7800k", 10000, 5);
            microsRepo.Add(micro1);

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
        public bool buscarAdministrador(Usuario u)
        {
            foreach (Usuario user in this.usuariosRepo)
            {
                if (u.existeEnLista(user) && user.nombre == "admin" && user.contrasena == "admin")
                {
                    return true;
                }
            }
            return false;
        }

        public Micro buscarMicro(string n)
        {
            foreach (Micro micro in microsRepo)
            {
                if (micro.nombre == n)
                {
                    return micro;
                }
            }

            return null;
        }
    }
}