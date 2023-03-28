using P22CV.Clases;
using P22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Funciones
{
    internal class CRUDUsuarios
    {
        public void Crear(string nombre, string password)
        {
            Console.WriteLine("INSERTAR ACTOR");



            using (var _context = new ApplicationDbContext())
            {
                Console.SetCursorPosition(0, 3);
                Usuarios user = new Usuarios()
                {

                    Nombre = nombre,
                    Password = password

                };

                _context.Usuarios.Add(user);
                _context.SaveChanges();
                Console.Clear();

            }

        }

        public void Editar(int id)
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                Usuarios user = _context.Usuarios.Find(id);

                Console.WriteLine("Ingrese el nombre");
                user.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la password");
                user.Password = Console.ReadLine();

                _context.Usuarios.Update(user);
                _context.SaveChanges();
                Console.Clear();

            }
        }

        public void Leer()
        {

            using (ApplicationDbContext _context = new ApplicationDbContext())
            {

                var curso = _context.Usuarios.ToList();

                Console.WriteLine("--Lista de Cursos--");
                foreach (var item in curso)
                {

                    Console.WriteLine("---------------------------------");
                    Console.WriteLine($">> Id: {item.Id}");
                    Console.WriteLine($">> Nombre: {item.Nombre}");
                    Console.WriteLine($">> Año: {item.Password}");
                    Console.WriteLine("_________________________________");


                }

            }
        }

        public void Eliminar(int id)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                var request = _context.Usuarios.Find(id);

                _context.Remove(request);

                _context.SaveChanges();
                Console.WriteLine("Se ha borrado el registro");
            }
        }
    }
}
