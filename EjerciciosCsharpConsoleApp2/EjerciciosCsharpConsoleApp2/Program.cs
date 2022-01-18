using System;
using System.Linq;
using EjerciciosCsharp.Models;

namespace EjerciciosCsharp.ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("".PadRight(60, '*'));
            Console.WriteLine("* Ejercicos de Csharp".PadRight(59) + '*');
            Console.WriteLine("*".PadRight(59, '*') + "*");
            Console.WriteLine("*".PadRight(59, ' ') + "*");
            Console.WriteLine("* 1. Calculo letra DNI".PadRight(59) + '*');
            Console.WriteLine("*".PadRight(59, ' ') + "*");
            Console.WriteLine("*".PadRight(59, '*') + "*");
            
            Console.WriteLine(Environment.NewLine);
            Console.Write("     Opcion: ");

            Console.ForegroundColor= ConsoleColor.Cyan;
            string opcion = Console.ReadLine();

            switch (opcion.ToLower())
            {
                case "1":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine($"La opcion {opcion} no es valida.");
                    break;
            }

            Console.ReadKey();
        }

        static void CalcularletraDNI()
        {
            string[] letras = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
        }
    }
}

namespace EjerciciosCsharp.Models
{
    //Nombre, Apellidos, Edad, DNI
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; };
        public int Edad { get; set; };
        public int DNI { get; set; };
        Console.WriteLine("Es la hora del queso");
    }
}