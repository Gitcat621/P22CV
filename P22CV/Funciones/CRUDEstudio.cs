using P22CV.Clases;
using P22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Funciones
{
    internal class CRUDEstudio
    {
        public void Crear(string nombre, string direccion,string anio,string fundador,string franq)
        {
            Console.WriteLine("INSERTAR ACTOR");



            using (var _context = new ApplicationDbContext())
            {
                Console.SetCursorPosition(0, 3);
                Estudios stu = new Estudios()
                {

                    Nombre = nombre,
                    Direccion = direccion,
                    AñoFundacion = anio,
                    Fundador = fundador,
                    MejorFranquicia = franq

                };

                _context.Estudios.Add(stu);
                _context.SaveChanges();
                Console.Clear();

            }

        }

        public void Editar(int id)
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Estudios stu = _context.Estudios.Find(id);

                Console.WriteLine("Ingrese el nombre");
                stu.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la direccion");
                stu.Direccion = Console.ReadLine();
                Console.WriteLine("Ingrese el anio de fundacion");
                stu.AñoFundacion = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre del fundador");
                stu.Fundador = Console.ReadLine();
                Console.WriteLine("Ingrese la mejor franquicia que posee");
                stu.MejorFranquicia = Console.ReadLine();

                _context.Estudios.Update(stu);
                _context.SaveChanges();
                Console.Clear();

            }
        }

        public void Leer()
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {

                var curso = _context.Estudios.ToList();

                Console.WriteLine("--Lista de Cursos--");
                foreach (var item in curso)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($">> Id: {item.id}");
                    Console.WriteLine($">> Nombre: {item.Nombre}");
                    Console.WriteLine($">> Año: {item.Direccion}");
                    Console.WriteLine($">> Año: {item.AñoFundacion}");
                    Console.WriteLine($">> Año: {item.Fundador}");
                    Console.WriteLine($">> Año: {item.MejorFranquicia}");
                    Console.WriteLine("_________________________________");


                }

            }
        }

        public void Eliminar(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                var request = _context.Estudios.Find(id);

                _context.Remove(request);

                _context.SaveChanges();
                Console.WriteLine("Se ha borrado el registro");
            }
        }
    }
}
