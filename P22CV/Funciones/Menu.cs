using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Funciones
{
    internal class Menu
    {
        public void Login()
        {
            INICIO:
            Console.WriteLine("Bienvenido ¿Que desea hacer?");
            Console.WriteLine("1. Iniciar Sesion");
            Console.WriteLine("2. Regsistrarse");
            CrudUsuarios login = new CrudUsuarios();
            int opc = int.Parse(Console.ReadLine());
            switch(opc)
            {
                case 1:
                    login.singin();
                    break;
                case 2:
                    login.Crear();
                 goto INICIO;
            }
        }
        public void Inicio()
        {
        ERROR1:
            try
            {
                Console.WriteLine("Selecciona una opcion");
                Console.WriteLine("1. Peliculas");
                Console.WriteLine("2. Actores");
                Console.WriteLine("3. Directores");
                Console.WriteLine("4. Estudios");
                Console.WriteLine("5. Usuarios");
                Console.WriteLine("6. Salir");

                int opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        opcionesPelicula();
                        goto ERROR1;
                    case 2:
                        Console.Clear();
                        opcionesActor();
                        goto ERROR1;
                    case 3:
                        Console.Clear();
                        opcionesDirector();
                        goto ERROR1;
                    case 4:
                        Console.Clear();
                        opcionesEstudio();
                        goto ERROR1;
                    case 5:
                        Console.Clear();
                        opcionesUsuario();
                        goto ERROR1;
                    case 6:
                        Console.WriteLine("ADIOS");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Escoja una opcion valida");
                        goto ERROR1;
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Ingresa una opcion correcta");
                goto ERROR1;
            }

        }
        public void opcionesPelicula()
        {
        ERROR:
            Console.WriteLine("¿Que desea hacer?\n");
            Console.WriteLine("1. Leer");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            int opc = int.Parse(Console.ReadLine());
            CrudPeliculas peli = new CrudPeliculas();
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    peli.Leer();
                    goto ERROR;
                case 2:
                    Console.Clear();
                    peli.Crear();
                    goto ERROR;
                case 3:
                    Console.Clear();

                    Console.WriteLine("Ingrese el id del registro a editar");
                    int id = int.Parse(Console.ReadLine());
                    peli.Editar(id);

                    goto ERROR;
                case 4:
                    Console.Clear();

                    Console.WriteLine("Ingrese el id del registro a eliminar");
                    int id2 = int.Parse(Console.ReadLine());
                    peli.Eliminar(id2);

                    goto ERROR;
                default:
                    Console.WriteLine("Escoja una opcion valida");
                    goto ERROR;
            }
        }
        public void opcionesActor()
        {
        ERROR:
            Console.WriteLine("¿Que desea hacer?\n");
            Console.WriteLine("1. Leer");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");

            CrudActores act = new CrudActores();
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    //instancie crud Actores
                    Console.Clear();
                    act.Leer();
                    goto ERROR;
                case 2:
                    Console.Clear();
                    act.Crear();
                    goto ERROR;
                case 3:
                    Console.Clear();

                    Console.WriteLine("Ingrese el id del registro a editar");
                    int id = int.Parse(Console.ReadLine());
                    act.Editar(id);

                    goto ERROR;
                case 4:
                    Console.Clear();

                    Console.WriteLine("Ingrese el id del registro a editar");
                    int id2 = int.Parse(Console.ReadLine());
                    act.Eliminar(id2);

                    goto ERROR;
                default:
                    Console.WriteLine("Escoja una opcion valida");
                    goto ERROR;
            }
        }
        public void opcionesDirector()
        {
        ERROR:
            Console.WriteLine("¿Que desea hacer?\n");
            Console.WriteLine("1. Leer");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            CrudDirectores dir = new CrudDirectores();
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    dir.Leer();
                    goto ERROR;
                case 2:
                    Console.Clear();
                    dir.Crear();
                    goto ERROR;
                case 3:
                    Console.Clear();

                    Console.WriteLine("Ingrese el id del registro a editar");
                    int id = int.Parse(Console.ReadLine());
                    dir.Editar(id);

                    goto ERROR;
                case 4:
                    Console.Clear();

                    Console.WriteLine("Ingrese el id del registro a eliminar");
                    int id2 = int.Parse(Console.ReadLine());
                    dir.Eliminar(id2);

                    goto ERROR;
                default:
                    Console.WriteLine("Escoja una opcion valida");
                    goto ERROR;
            }
        }
        public void opcionesEstudio()
        {
        ERROR:
            Console.WriteLine("¿Que desea hacer?\n");
            Console.WriteLine("1. Leer");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            CrudEstudios stu = new CrudEstudios();
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    stu.Leer();
                    goto ERROR;
                case 2:
                    Console.Clear();
                    stu.Crear();
                    goto ERROR;
                case 3:
                    Console.Clear();

                    Console.WriteLine("Ingrese el id del registro a editar");
                    int id = int.Parse(Console.ReadLine());
                    stu.Editar(id);

                    goto ERROR;
                case 4:
                    Console.Clear();

                    Console.WriteLine("Ingrese el id del registro a eliminar");
                    int id2 = int.Parse(Console.ReadLine());
                    stu.Eliminar(id2);

                    goto ERROR;
                default:
                    Console.WriteLine("Escoja una opcion valida");
                    goto ERROR;
            }
        }
        public void opcionesUsuario()
        {
        ERROR:
            Console.WriteLine("¿Que desea hacer?\n");
            Console.WriteLine("1. Leer");
            Console.WriteLine("2. Agregar");
            Console.WriteLine("3. Editar");
            Console.WriteLine("4. Eliminar");
            CrudUsuarios user = new CrudUsuarios();
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    user.Leer();
                    goto ERROR;
                case 2:
                    Console.Clear();
                    user.Crear();
                    goto ERROR;
                case 3:
                    Console.Clear();

                    Console.WriteLine("Ingrese el id del registro a editar");
                    int id = int.Parse(Console.ReadLine());
                    user.Editar(id);

                    goto ERROR;
                case 4:
                    Console.Clear();

                    Console.WriteLine("Ingrese el id del registro a eliminar");
                    int id2 = int.Parse(Console.ReadLine());
                    user.Eliminar(id2);

                    goto ERROR;
                default:
                    Console.WriteLine("Escoja una opcion valida");
                    goto ERROR;
            }
        }

    }
}
