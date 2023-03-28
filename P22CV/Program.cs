using P22CV.Funciones;
using System;

namespace P22CV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Acabas de clonar el repositorio!");
            Menu men = new Menu();
            men.Login();
        }
    }
}
