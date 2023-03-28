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
        login:

            Console.WriteLine("INICIE SESION");

            Console.WriteLine("Ingrese su usuario");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su password");
            string password = Console.ReadLine();

            Login log = new Login();
            log.singin(nombre, password);

            goto login;
        }
        public void Opciones()
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
            CRUDPeliculas peli = new CRUDPeliculas();
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    peli.Leer();
                    goto ERROR;
                case 2:
                    Console.Clear();

                    Console.WriteLine("Nombre");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Anio");
                    int anio = int.Parse(Console.ReadLine());

                    Console.WriteLine("Clasificacion");
                    string clasificacion = Console.ReadLine();

                    Console.WriteLine("Director");
                    string director = Console.ReadLine();

                    Console.WriteLine("Nacionalidad");
                    string nacionalidad = Console.ReadLine();

                    Console.WriteLine("Genero");
                    string genero = Console.ReadLine();

                    Console.WriteLine("Idioma"); ;
                    string idioma = Console.ReadLine();

                    Console.WriteLine("Duracion");
                    string duracion = Console.ReadLine();

                    peli.Crear(nombre, anio, clasificacion, director, nacionalidad, genero, idioma, duracion);
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

            CRUDActores act = new CRUDActores();
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

                    Console.WriteLine("Nombre");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Nacionalidad");
                    string nacionalidad = Console.ReadLine();

                    Console.WriteLine("Personaje Famoso");
                    string PF = Console.ReadLine();

                    Console.WriteLine("pelicula Famosa");
                    string PeF = Console.ReadLine();

                    Console.WriteLine("Anio de nacimiento");
                    int anio = int.Parse(Console.ReadLine());

                    Console.WriteLine("Mes de nacimiento");
                    string mes = Console.ReadLine();

                    Console.WriteLine("Dia de nacimiento"); ;
                    string dia = Console.ReadLine();

                    act.Crear(nombre, nacionalidad, PF, PeF, anio, mes, dia);
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
            CRUDDirector dir = new CRUDDirector();
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    dir.Leer();
                    goto ERROR;
                case 2:
                    Console.Clear();

                    Console.WriteLine("Nombre");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Nacionalidad");
                    string nacionalidad = Console.ReadLine();

                    Console.WriteLine("pelicula Famosa");
                    string PeF = Console.ReadLine();

                    Console.WriteLine("Anio de nacimiento");
                    int anio = int.Parse(Console.ReadLine());

                    Console.WriteLine("Mes de nacimiento");
                    string mes = Console.ReadLine();

                    Console.WriteLine("Dia de nacimiento"); ;
                    string dia = Console.ReadLine();

                    dir.Crear(nombre, nacionalidad, PeF, anio, mes, dia);
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
            CRUDEstudio stu = new CRUDEstudio();
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    stu.Leer();
                    goto ERROR;
                case 2:
                    Console.Clear();

                    Console.WriteLine("Nombre");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("direccion");
                    string direccion = Console.ReadLine();

                    Console.WriteLine("anio de fundacion");
                    string anio = Console.ReadLine();

                    Console.WriteLine("fundador");
                    string fundador = Console.ReadLine();

                    Console.WriteLine("Franquicia mas famosa que posee");
                    string Franquicia = Console.ReadLine();

                    stu.Crear(nombre, direccion,anio, fundador, Franquicia);
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
            CRUDUsuarios user = new CRUDUsuarios();
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Console.Clear();
                    user.Leer();
                    goto ERROR;
                case 2:
                    Console.Clear();

                    Console.WriteLine("Nombre");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("Password");
                    string password = Console.ReadLine();

                    user.Crear(nombre, password);
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
