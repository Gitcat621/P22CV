using P22CV.Clases;
using P22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Funciones
{
    internal class CRUDPeliculas
    {
        public void Crear(string nom, int anio, string cla, string dir, string nac, string gen, string idi, string dur)
        {
            Console.WriteLine("INSERTAR USUARIO");



            using (var _context = new ApplicationDbContext())
            {
                Console.SetCursorPosition(0, 3);
                Peliculas peli = new Peliculas()
                {

                    Nombre = nom,
                    Año = anio,
                    Clasificacion = cla,
                    Director = dir,
                    Nacionalidad = nac,
                    Genero = gen,
                    Idioma = idi,
                    Duracion = dur,

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
                peli.Año = int.Parse(Console.ReadLine());
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
                peli.Duracion = Console.ReadLine();

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
                    Console.WriteLine($">> Año: {item.Año}");
                    Console.WriteLine($">> Clasificacion: {item.Clasificacion}");
                    Console.WriteLine($">> Director: {item.Director}");
                    Console.WriteLine($">> Nacionalidad: {item.Nacionalidad}");
                    Console.WriteLine($">> Genero: {item.Genero}");
                    Console.WriteLine($">> Idioma: {item.Idioma}");
                    Console.WriteLine($">> Duracion: {item.Duracion}");
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
