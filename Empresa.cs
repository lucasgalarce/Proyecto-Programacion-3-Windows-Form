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
        public Micro(string nombre, double precio, int stock) : base(nombre, precio, stock) { }

        public Micro existeEnLista(Micro m)
        {
            return m;
        }
    }

    [Serializable]
    class Mother : componente
    {
        public Mother(string nombre, double precio, int stock) : base(nombre, precio, stock) { }

        public Mother existeEnLista(Mother m)
        {
            return m;
        }
    }

    [Serializable]
    class Disco : componente
    {
        public Disco(string nombre, double precio,  int stock) : base(nombre, precio, stock) { }

        public Disco existeEnLista(Disco d)
        {
            return d;
        }
    }

    [Serializable]
    class Memoria : componente
    {
        public Memoria(string nombre, double precio, int stock) : base(nombre, precio,  stock) { }
        public Memoria existeEnLista(Memoria m)
        {
            return m;
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
        public List<componente> listacompras;

        public Empresa()
        {   
            usuariosRepo = new List<Usuario>();
            microsRepo = new List<Micro>();
            mothersRepo = new List<Mother>();
            discosRepo = new List<Disco>();
            memosRepo = new List<Memoria>();
            listacompras = new List<componente>();

            Usuario administrador = new Usuario("admin", "admin");
            usuariosRepo.Add(administrador);

            Usuario usuario = new Usuario("user", "user");
            usuariosRepo.Add(usuario);

            Micro micro1 = new Micro("i3 7800k", 14000, 20);
            microsRepo.Add(micro1);

            Micro micro2 = new Micro("i5 7600k", 30000, 15);
            microsRepo.Add(micro2);

            Micro micro3 = new Micro("i7 8800k", 50000, 10);
            microsRepo.Add(micro3);

            Micro micro4 = new Micro("i9 9900k", 60000, 10);
            microsRepo.Add(micro4);

            Mother mother1 = new Mother("ASUS PRO", 5000, 20);
            mothersRepo.Add(mother1);

            Mother mother2 = new Mother("Gigabyte 320", 10000, 15);
            mothersRepo.Add(mother2);

            Mother mother3 = new Mother("MSI PRO 2", 15000, 15);
            mothersRepo.Add(mother3);

            Mother mother4 = new Mother("Asrock 1150", 20000, 10);
            mothersRepo.Add(mother4);

            Memoria memoria1 = new Memoria("DDR3 4GB 1333ghz", 3200, 20);
            memosRepo.Add(memoria1);

            Memoria memoria2 = new Memoria("DDR3 8GB 1333ghz", 5000, 15);
            memosRepo.Add(memoria2);

            Memoria memoria3 = new Memoria("DDR4 4GB 2400ghz", 4000, 10);
            memosRepo.Add(memoria3);

            Memoria memoria4 = new Memoria("DDR4 8GB 2400ghz", 6000, 10);
            memosRepo.Add(memoria4);

            Disco disco1 = new Disco("HDD 250GB Western", 3500, 20);
            discosRepo.Add(disco1);

            Disco disco2 = new Disco("HDD 500GB Western", 4500, 15);
            discosRepo.Add(disco2);

            Disco disco3 = new Disco("HDD 1TB Western", 5500, 10);
            discosRepo.Add(disco3);

            Disco disco4 = new Disco("SSD 250GB Western", 3500, 15);
            discosRepo.Add(disco4);
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

        public Mother buscarMother(string n)
        {
            foreach (Mother mother in mothersRepo)
            {
                if (mother.nombre == n)
                {
                    return mother;
                }
            }

            return null;
        }

        public Memoria buscarMemoria(string n)
        {
            foreach (Memoria memoria in memosRepo)
            {
                if (memoria.nombre == n)
                {
                    return memoria;
                }
            }

            return null;
        }

        public Disco buscarDisco(string n)
        {
            foreach (Disco disco in discosRepo)
            {
                if (disco.nombre == n)
                {
                    return disco;
                }
            }

            return null;
        }
    }
}