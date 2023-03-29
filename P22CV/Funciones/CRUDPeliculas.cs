using P22CV.Clases;
using P22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Funciones
{
    internal class CrudPeliculas
    {
        public void Crear()
        {
            Console.WriteLine("INSERTAR PELICULA");

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
            int duracion = int.Parse(Console.ReadLine());

            using (var _context = new ApplicationDbContext())
            {
                Console.SetCursorPosition(0, 3);
                Peliculas peli = new Peliculas()
                {

                    Nombre = nombre,
                    Anio = anio,
                    Clasificacion = clasificacion,
                    Director = director,
                    Nacionalidad = nacionalidad,
                    Genero = genero,
                    Idioma = idioma,
                    Duracion = duracion,

                };

                _context.Peliculas.Add(peli);
                _context.SaveChanges();
                Console.Clear();

            }

        }

        public void Editar(int id)
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Peliculas peli = _context.Peliculas.Find(id);

                Console.WriteLine("Ingrese el nombre");
                peli.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el anio");
                peli.Anio = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la clasificacion");
                peli.Clasificacion = Console.ReadLine();
                Console.WriteLine("Ingrese el director");
                peli.Director = Console.ReadLine();
                Console.WriteLine("Ingrese la nacionalidad");
                peli.Nacionalidad = Console.ReadLine();
                Console.WriteLine("Ingrese el genero");
                peli.Genero = Console.ReadLine();
                Console.WriteLine("Ingrese el idioma");
                peli.Idioma = Console.ReadLine();
                Console.WriteLine("Ingrese la duracion");
                peli.Duracion = int.Parse(Console.ReadLine());

                _context.Peliculas.Update(peli);
                _context.SaveChanges();
                Console.Clear();

            }
        }

        public void Leer()
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {

                var curso = _context.Peliculas.ToList();

                Console.WriteLine("--Lista de Cursos--");
                foreach (var item in curso)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($">> Id: {item.Id}");
                    Console.WriteLine($">> Nombre: {item.Nombre}");
                    Console.WriteLine($">> Año: {item.Anio}");
                    Console.WriteLine($">> Clasificacion: {item.Clasificacion}");
                    Console.WriteLine($">> Director: {item.Director}");
                    Console.WriteLine($">> Nacionalidad: {item.Nacionalidad}");
                    Console.WriteLine($">> Genero: {item.Genero}");
                    Console.WriteLine($">> Idioma: {item.Idioma}");
                    Console.WriteLine($">> Duracion: {item.Duracion} Hrs");
                    Console.WriteLine("_________________________________");


                }

            }
        }

        public void Eliminar(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                var request = _context.Peliculas.Find(id);

                _context.Remove(request);

                _context.SaveChanges();
                Console.WriteLine("Se ha borrado el registro");
            }
        }
    }
}
