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
            string[] unidades = { "Metros", "Kilómetros", "Centímetros", "Milímetros", "Micrómetros", "Nanómetros", "Millas", "Yardas", "Pies", "Pulgadas" };

            double[,] factoresConversion = {
            //Metro      //Kilometro    //Centimetro //Milimetro   //MicroM    //NanoM      //Milla              //Yarda          //Pie             //Pulgada
            { 1,         0.001,         100,         1000,         1e6,        1e9,         0.000621371,         1.09361,         3.28084,          39.3701 },   // Metro
            { 1000,      1,             100000,      1e6,          1e9,        1e12,        0.621371,            1093.61,         3280.84,          39370.1 },   // Kilómetro
            { 0.01,      1e-5,          1,           10,           10000,      1e7,         6.2137e-6,           0.0109361,       0.0328084,        0.393701 },  // Centímetro
            { 0.001,     1e-6,          0.1,         1,            1000,       1e6,         6.2137e-7,           0.00109361,      0.00328084,       0.0393701 }, // Milímetro
            { 1e-6,      1e-9,          1e-4,        0.001,        1,          1000,        6.2137e-10,          1.0936e-6,       3.2808e-6,        3.937e-5 },  // Micrómetro
            { 1e-9,      1e-12,         1e-7,        1e-6,         0.001,      1,           6.2137e-13,          1.0936e-9,       3.2808e-9,        3.937e-8 },  // Nanómetro
            { 1609.34,   1.60934,       160934,      1.609e6,      1.609e9,    1.609e12,    1,                   1760,            5280,             63360 },     // Milla
            { 0.9144,    0.0009144,     91.44,       914.4,        914400,     9.144e8,     0.000568182,         1,               3,                36 },        // Yarda
            { 0.3048,    0.0003048,     30.48,       304.8,        304800,     3.048e8,     0.000189394,         0.333333,        1,                12 },        // Pie
            { 0.0254,    2.54e-5,       2.54,        25.4,         25400,      2.54e7,      1.5783e-5,           0.0277778,       0.0833333,        1 }          // Pulgada
        };
            Console.WriteLine("Seleccione la unidad de longitud de entrada:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {unidades[i]}");
            }
            int unidadEntrada = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Seleccione la unidad de longitud de salida:");
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
    

