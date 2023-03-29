using P22CV.Clases;
using P22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Funciones
{
    internal class CrudEstudios
    {
        public void Crear()
        {
            Console.WriteLine("INSERTAR ESTUDIO");

            Console.WriteLine("Nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("direccion");
            string direccion = Console.ReadLine();

            Console.WriteLine("anio de fundacion");
            int anio = int.Parse(Console.ReadLine());

            Console.WriteLine("fundador");
            string fundador = Console.ReadLine();

            Console.WriteLine("Franquicia mas famosa que posee");
            string franquicia = Console.ReadLine();


            using (var _context = new ApplicationDbContext())
            {
                Console.SetCursorPosition(0, 3);
                Estudios stu = new Estudios()
                {

                    Nombre = nombre,
                    Direccion = direccion,
                    AnioFundacion = anio,
                    Fundador = fundador,
                    MejorFranquicia = franquicia

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
                stu.AnioFundacion = int.Parse(Console.ReadLine());
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
                    Console.WriteLine($">> Id: {item.Id}");
                    Console.WriteLine($">> Nombre: {item.Nombre}");
                    Console.WriteLine($">> Direccion: {item.Direccion}");
                    Console.WriteLine($">> Fundado en: {item.AnioFundacion}");
                    Console.WriteLine($">> Fundador: {item.Fundador}");
                    Console.WriteLine($">> Franquicia mas exitosa: {item.MejorFranquicia}");
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
