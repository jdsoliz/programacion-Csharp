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
            var persona = new Persona("12345678", "Borja", "Cabeza");
            Console.WriteLine($"DNI: {persona.DNI}");
            //string[] letras = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
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
        private int DNI;
        public string DNI
        {
            //Calculamos el modulo(resto de la division), al dividir el dni entre 23
            //el modulo indica la posicion del array, donde esta la letra del DNI.
            string DNI Convert.ToInt16();

            get { return DNI; }
            set { DNI = value; }
        }

        public Persona()
        {
            this.DNI = null;
            Nombre =  "";
            Apellidos = "";
            Edad =  0;
        }
    }
}