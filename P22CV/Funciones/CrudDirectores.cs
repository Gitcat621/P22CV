using P22CV.Clases;
using P22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Funciones
{
    internal class CrudDirectores
    {
        public void Crear()
        {
            Console.WriteLine("INSERTAR DIRECTOR");

            Console.WriteLine("Nombre");
            string Nombre = Console.ReadLine();

            Console.WriteLine("Nacionalidad");
            string Nacionalidad = Console.ReadLine();

            Console.WriteLine("pelicula Famosa");
            string Pel = Console.ReadLine();

            Console.WriteLine("fecha de nacimiento");
            string Fecha = Console.ReadLine();

            using (var _context = new ApplicationDbContext())
            {
                Console.SetCursorPosition(0, 3);
                Directores dir = new Directores()
                {

                    Nombre = Nombre,
                    Nacionalidad = Nacionalidad,
                    PeliculaFamosa = Pel,
                    FechaNac = Fecha,

                };

                _context.Directores.Add(dir);
                _context.SaveChanges();
                Console.Clear();

            }

        }

        public void Editar(int id)
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Directores dir = _context.Directores.Find(id);

                Console.WriteLine("Ingrese el nombre");
                dir.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la nacionalidad");
                dir.Nacionalidad = (Console.ReadLine());
                Console.WriteLine("Ingrese la PeliculaFamosa");
                dir.PeliculaFamosa = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha de nacimiento");
                dir.FechaNac = Console.ReadLine();

                _context.Directores.Update(dir);
                _context.SaveChanges();
                Console.Clear();

            }
        }

        public void Leer()
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {

                var curso = _context.Directores.ToList();

                Console.WriteLine("--Lista de Cursos--");
                foreach (var item in curso)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($">> Id: {item.Id}");
                    Console.WriteLine($">> Nombre: {item.Nombre}");
                    Console.WriteLine($">> Nacionalidad: {item.Nacionalidad}");
                    Console.WriteLine($">> Pelicula Famosa: {item.PeliculaFamosa}");
                    Console.WriteLine($">> Fecha de Nacimiento: {item.FechaNac}");
                    Console.WriteLine("_________________________________");


                }

            }
        }

        public void Eliminar(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                var request = _context.Directores.Find(id);

                _context.Remove(request);

                _context.SaveChanges();
                Console.WriteLine("Se ha borrado el registro");
            }
        }
    }
}
