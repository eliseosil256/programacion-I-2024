using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversores
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] unidades = { "Bit", "Byte", "Kilobit", "Kilobyte", "Megabit", "Megabyte", "Gigabit", "Gigabyte", "Terabit", "Terabyte" };

            double[,] factoresConversion = {
            // Bit    //Byte      //Kilobit   //Kilobyte     //Megabit  //Megabyte    //Gigabit  //Gigabyte     //Terabite  //Terabyte
            { 1,      0.125,      0.001,      0.000125,      1e-6,      1.25e-7,      1e-9,      1.25e-10,      1e-12,      1.25e-13 }, // Bit
            { 8,      1,          0.008,      0.001,         8e-6,      1e-6,         8e-9,      1e-9,          8e-12,      1e-12 },    // Byte
            { 1000,   125,        1,          0.125,         0.001,     0.000125,     1e-6,      1.25e-7,       1e-9,       1.25e-10 }, // Kilobit
            { 8000,   1000,       8,          1,             0.008,     0.001,        8e-6,      1e-6,          8e-9,       1e-9 },     // Kilobyte
            { 1e6,    125000,     1000,       125,           1,         0.125,        0.001,     0.000125,      1e-6,       1.25e-7 },  // Megabit
            { 8e6,    1e6,        8000,       1000,          8,         1,            0.008,     0.001,         8e-6,       1e-6 },     // Megabyte
            { 1e9,    1.25e8,     1e6,        125000,        1000,      125,          1,         0.125,         0.001,      0.000125 }, // Gigabit
            { 8e9,    1e9,        8e6,        1e6,           8000,      1000,         8,         1,             0.008,      0.001 },    // Gigabyte
            { 1e12,   1.25e11,    1e9,        1.25e8,        1e6,       1.25e5,       1000,      125,           1,          0.125 },    // Terabit
            { 8e12,   1e12,       8e9,        1e9,           8e6,       1e6,          8e3,       1000,          8,          1 }         // Terabyte
        };
            Console.WriteLine("Seleccione la unidad de almacenamiento de entrada:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {unidades[i]}");
            }
            int unidadEntrada = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Seleccione la unidad de almacenamiento de salida:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {unidades[i]}");
            }
            int unidadSalida = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Ingrese la cantidad a convertir:");
            double cantidad = double.Parse(Console.ReadLine());
            double resultado = cantidad * factoresConversion[unidadEntrada, unidadSalida];
            Console.WriteLine($"{cantidad} {unidades[unidadEntrada]} es igual a {resultado} {unidades[unidadSalida]}.");
            Console.ReadLine();
        }
    }
}
    

