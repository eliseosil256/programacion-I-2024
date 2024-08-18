using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDeConversores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nombres de las unidades de tiempo
            string[] unidades = { "Segundos", "Minutos", "Horas", "Días", "Semanas", "Meses (30 días)", "Años (365 días)", "Milisegundos", "Microsegundos", "Nanosegundos" };

            // Matriz de factores de conversión entre las 10 unidades de tiempo
            double[,] factoresConversion = {
            { 1, 1.0/60, 1.0/3600, 1.0/86400, 1.0/604800, 1.0/2.592e6, 1.0/3.154e7, 1000, 1e6, 1e9 },          // Segundos a otras unidades
            { 60, 1, 1.0/60, 1.0/1440, 1.0/10080, 1.0/43200, 1.0/525600, 60000, 6e7, 6e10 },                   // Minutos a otras unidades
            { 3600, 60, 1, 1.0/24, 1.0/168, 1.0/720, 1.0/8760, 3.6e6, 3.6e9, 3.6e12 },                        // Horas a otras unidades
            { 86400, 1440, 24, 1, 1.0/7, 1.0/30, 1.0/365, 8.64e7, 8.64e10, 8.64e13 },                         // Días a otras unidades
            { 604800, 10080, 168, 7, 1, 1.0/4.348, 1.0/52.143, 6.048e8, 6.048e11, 6.048e14 },                 // Semanas a otras unidades
            { 2.592e6, 43200, 720, 30, 4.348, 1, 1.0/12, 2.592e9, 2.592e12, 2.592e15 },                       // Meses a otras unidades
            { 3.154e7, 525600, 8760, 365, 52.143, 12, 1, 3.154e10, 3.154e13, 3.154e16 },                      // Años a otras unidades
            { 0.001, 1.6667e-5, 2.7778e-7, 1.1574e-8, 1.6534e-9, 3.858e-10, 3.1689e-11, 1, 1000, 1e6 },       // Milisegundos a otras unidades
            { 1e-6, 1.6667e-8, 2.7778e-10, 1.1574e-11, 1.6534e-12, 3.858e-13, 3.1689e-14, 0.001, 1, 1000 },   // Microsegundos a otras unidades
            { 1e-9, 1.6667e-11, 2.7778e-13, 1.1574e-14, 1.6534e-15, 3.858e-16, 3.1689e-17, 1e-6, 0.001, 1 }   // Nanosegundos a otras unidades
        };

            // Solicitar al usuario la unidad de entrada y la unidad de salida
            Console.WriteLine("Seleccione la unidad de tiempo de entrada:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {unidades[i]}");
            }
            int unidadEntrada = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Seleccione la unidad de tiempo de salida:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {unidades[i]}");
            }
            int unidadSalida = int.Parse(Console.ReadLine()) - 1;

            // Solicitar al usuario la cantidad a convertir
            Console.WriteLine("Ingrese la cantidad a convertir:");
            double cantidad = double.Parse(Console.ReadLine());

            // Realizar la conversión
            double resultado = cantidad * factoresConversion[unidadEntrada, unidadSalida];

            // Mostrar el resultado
            Console.WriteLine($"{cantidad} {unidades[unidadEntrada]} es igual a {resultado} {unidades[unidadSalida]}.");
        }
    }
}
