using P22CV.Clases;
using P22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Funciones
{
    internal class CRUDDirector
    {
        public void Crear(string nom, string nac, string pel, int anio, string mes, string dia)
        {
            Console.WriteLine("INSERTAR ACTOR");



            using (var _context = new ApplicationDbContext())
            {
                Console.SetCursorPosition(0, 3);
                Directores dir = new Directores()
                {

                    Nombre = nom,
                    Nacionalidad = nac,
                    PeliculaFamosa = pel,
                    AñoNacimiento = anio,
                    MesNacimiento = mes,
                    DiaNacimiento = dia,

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
                Console.WriteLine("Ingrese el anio de nacimiento");
                dir.AñoNacimiento = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el mes de nacimiento");
                dir.MesNacimiento = Console.ReadLine();
                Console.WriteLine("Ingrese el dia de nacimiento");
                dir.DiaNacimiento = Console.ReadLine();

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
                    Console.WriteLine($">> Fecha de Nacimiento: {item.DiaNacimiento}/{item.MesNacimiento}/{item.AñoNacimiento}");
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
