using P22CV.Clases;
using P22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Funciones
{
    internal class CRUDActores
    {
        public void Crear(string nom, string nac, string per, string pel, int anio, string mes, string dia)
        {
            Console.WriteLine("INSERTAR ACTOR");



            using (var _context = new ApplicationDbContext())
            {
                Console.SetCursorPosition(0, 3);
                Actores act = new Actores()
                {

                    Nombre = nom,
                    Nacionalidad = nac,
                    PersonajeFamoso = per,
                    PeliculaFamosa = pel,
                    Año = anio,
                    MesNacimiento = mes,
                    DiaNacimiento = dia,

                };

                _context.Actores.Add(act);
                _context.SaveChanges();
                Console.Clear();

            }

        }

        public void Editar(int id)
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Actores act = _context.Actores.Find(id);

                Console.WriteLine("Ingrese el nombre");
                act.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la nacionalidad");
                act.Nacionalidad = (Console.ReadLine());
                Console.WriteLine("Ingrese el PersonajeFamoso");
                act.PersonajeFamoso = Console.ReadLine();
                Console.WriteLine("Ingrese la PeliculaFamosa");
                act.PeliculaFamosa = Console.ReadLine();
                Console.WriteLine("Ingrese el anio de nacimiento");
                act.Año = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el mes de nacimiento");
                act.MesNacimiento = Console.ReadLine();
                Console.WriteLine("Ingrese el dia de nacimiento");
                act.DiaNacimiento = Console.ReadLine();

                _context.Actores.Update(act);
                _context.SaveChanges();
                Console.Clear();

            }
        }

        public void Leer()
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {

                var curso = _context.Actores.ToList();

                Console.WriteLine("--Lista de Cursos--");
                foreach (var item in curso)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($">> Id: {item.Id}");
                    Console.WriteLine($">> Nombre: {item.Nombre}");
                    Console.WriteLine($">> Nacionalidad: {item.Nacionalidad}");
                    Console.WriteLine($">> Personaje Famoso: {item.PersonajeFamoso}");
                    Console.WriteLine($">> Pelicula Famosa: {item.PeliculaFamosa}");
                    Console.WriteLine($">> Fecha de Nacimiento: {item.DiaNacimiento}/{item.MesNacimiento}/{item.Año}");
                    Console.WriteLine("_________________________________");


                }

            }
        }

        public void Eliminar(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                var request = _context.Actores.Find(id);

                _context.Remove(request);

                _context.SaveChanges();
                Console.WriteLine("Se ha borrado el registro");
            }
        }
    }
}
