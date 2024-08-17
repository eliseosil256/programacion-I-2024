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
            string[] unidades = { "Litros", "Mililitros", "Galones estadounidenses", "Pintas estadounidenses", "Tazas", "Onzas líquidas estadounidenses", "Metros cúbicos", "Centímetros cúbicos", "Barriles de petróleo", "Pies cúbicos" };

            double[,] factoresConversion = {
            { 1,          1000,       0.264172,       2.11338,       4.22675,       33.814,       0.001,       1000,       0.00628981,       0.0353147 }, // Litro
            { 0.001,      1,          0.000264172,    0.00211338,    0.00422675,    0.033814,     1e-6,        1,          6.2898e-6,        3.5315e-5 }, // Mililitro
            { 3.78541,    3785.41,    1,              8,             16,            128,          0.00378541,  3785.41,    0.0238095,        0.133681 },  // Galon
            { 0.473176,   473.176,    0.125,          1,             2,             16,           0.000473176, 473.176,    0.00297619,       0.0167101 }, // Pinta estadounidense
            { 0.236588,   236.588,    0.0625,         0.5,           1,             8,            0.000236588, 236.588,    0.0014881,        0.00835503 },// Taza
            { 0.0295735,  29.5735,    0.0078125,      0.0625,        0.125,         1,            2.9574e-5,   29.5735,    9.3206e-5,        0.00104438 },// Onza líquida estadounidense
            { 1000,       1e6,        264.172,        2113.38,       4226.75,       33814,        1,           1e6,        6.28981,          35.3147 },   // Metro cúbico
            { 0.001,      1,          2.64172e-4,     0.00211338,    0.00422675,    0.033814,     1e-6,        1,          6.2898e-6,        3.5315e-5 }, // Centímetro cúbico
            { 159,        159000,     42,             336,           672,           5376,         0.159,       159000,     1,                5.61458 },   // Barril de petróleo
            { 28.3168,    28316.8,    7.48052,        59.8442,       119.688,       957.506,      0.0283168,   28316.8,    0.178108,         1 }          // Pie cúbico
        };
            Console.WriteLine("Seleccione la unidad de volumen de entrada:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {unidades[i]}");
            }
            int unidadEntrada = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Seleccione la unidad de volumen de salida:");
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
    

