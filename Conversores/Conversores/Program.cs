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
            string[] unidades = { "Gramos", "Kilogramos", "Miligramos", "Toneladas métricas", "Libras", "Onzas", "Stones", "Granos", "Microgramos", "Quintales métricos" };

            double[,] factoresConversion = {
            //Gramo         //Kilogramo //MiliGr //Tonelada    //Libra           //Onza              //Stone        //Grano      //MicroGr //Quintal
            { 1,            0.001,      1000,    1e-6,         0.00220462,       0.03527396,         0.00015747,    15.4324,     1e6,      1e-5        }, // Gramo
            { 1000,         1,          1e6,     0.001,        2.20462,          35.27396,           0.15747,       15432.4,     1e9,      0.01        }, // Kilogramo
            { 0.001,        1e-6,       1,       1e-9,         2.2046e-6,        3.5274e-5,          1.5747e-7,     0.015432,    1000,     1e-8        }, // Miligramo
            { 1e6,          1000,       1e9,     1,            2204.62,          35273.96,           157.47,        15432400,    1e12,     10          }, // Tonelada
            { 453.592,      0.453592,   453592,  0.000453592,  1,                16,                 0.0714286,     7000,        4.536e8,  0.00453592  }, // Libra
            { 28.3495,      0.0283495,  28349.5, 2.835e-5,     0.0625,           1,                  0.00446429,    437.5,       2.835e7,  0.000283495 }, // Onza
            { 6350.29,      6.35029,    6.35e6,  0.00635029,   14,               224,                1,             98000,       6.35e9,   0.0635029   }, // Stone
            { 0.0647989,    6.47989e-5, 64.7989, 6.4799e-8,    0.000142857,      0.00228571,         1.02041e-5,    1,           64798.9,  6.47989e-7  }, // Grano
            { 1e-6,         1e-9,       0.001,   1e-12,        2.2046e-9,        3.5274e-8,          1.5747e-10,    1.5432e-5,   1,        1e-11       }, // Microgramo
            { 100000,       100,        1e8,     0.1,          220.462,          3527.4,             15.747,        1543240,     1e11,     1           }  // Quintal
        };

            Console.WriteLine("Seleccione la unidad de masa de entrada:");
            for (int i = 0; i < unidades.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {unidades[i]}");
            }
            int unidadEntrada = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Seleccione la unidad de masa de salida:");
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
    

