using P22CV.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Funciones
{
    internal class Login
    {
        public void singin(string nombre, string password)
        {
            using (ApplicationDbContext _context = new ApplicationDbContext())
            {
                var request = _context.Usuarios.Where(x => x.Nombre == nombre && x.Password == password).FirstOrDefault();

                if (request != null)
                {
                    Console.Clear();
                    Menu menu = new Menu();
                    menu.Opciones();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error");
                }
            }
               
        }
    }
}
