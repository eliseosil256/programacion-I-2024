using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] unidades = { "Metros", "Kilómetros", "Centímetros", "Milímetros", "Micrómetros", "Nanómetros", "Millas", "Yardas", "Pies", "Pulgadas" };

            double[,] factoresConversion = {
            //PieCuadrado      //VaraCuadrada    //YardaCuadrada    //MetroCuadrado  //Tareas           //Manzanas          //Hectarea  
            { 1,               0.1111,           0.111111,          0.092903,        0.00014774656489,  0.000013188960818,  0.000621371, },   // Pie cuadrado
            { 0.1111,          1,                0.8357,            0.698896,        0.0011173378658,   10000,              0.00006987,  },   // vara cuadrada
            { 9,               1.197,            1,                 0.836127,        0.001329719084,    0.00011870064736,   8.36127e-5,  },   // YardaCuadrada
            { 0.001,           1e-6,             0.1,               1,               1000,              1e6,                6.2137e-7,   },   // MetroCuadrado
            { 1e-6,            1e-9,             1e-4,              0.001,           1,                 1000,               6.2137e-10,  },   // Tareas
            { 1e-9,            1e-12,            1e-7,              1e-6,            0.001,             1,                  6.2137e-13,  },   // Manzanas
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
