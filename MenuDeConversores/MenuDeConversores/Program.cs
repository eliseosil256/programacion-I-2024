using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDeConversores
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Seleccione el tipo de conversión que desea realizar:");
                Console.WriteLine("1. ***********Conversión de Monedas***********");
                Console.WriteLine("2. ***********Conversión de Masa*************");
                Console.WriteLine("3. ***********Conversión de Volumen***********");
                Console.WriteLine("4. ***********Conversión de Longitud**********");
                Console.WriteLine("5. ***********Conversión de Almacenamiento******");
                Console.WriteLine("6. ***********Conversión de Tiempo************");
                Console.WriteLine("0. Salir");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ConvertirMonedas();
                        break;
                    case 2:
                        ConvertirMasa();
                        break;
                    case 3:
                        ConvertirVolumen();
                        break;
                    case 4:
                        ConvertirLongitud();
                        break;
                    case 5:
                        ConvertirAlmacenamiento();
                        break;
                    case 6:
                        ConvertirTiempo();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void ConvertirMonedas()
        {
            Console.WriteLine("Ejecutando conversión de Monedas...");
            double[,] tasasDeCambio = {
                // USD    EUR       GBP     JPY     CHF     CAD     AUD    CNY   RUB     MXN
                { 1.0,    0.91,     0.77,   147.66, 0.87,   1.37,   1.50,  7.16, 89.38,  18.64 }, // USD
                { 1.10,   1.0,      0.85,   162.95, 0.96,   1.51,   1.65,  7.89, 98.60,  20.56 }, // EUR
                { 1.29,   1.17,     1.0,    191.12, 1.12,   1.77,   1.94,  9.27, 115.69, 24.13 }, // GBP
                { 0.0068, 0.0061,   0.0052, 1.0,    0.0059, 0.0093, 0.010, 0.05, 0.61,    0.13 }, // JPY
                { 1.15,   1.05,     0.89,   170.49, 1.0,    1.58,   1.73,  8.27, 103.20, 21.52 }, // CHF
                { 0.73,   0.66,     0.56,   107.86, 0.63,   1.0,    1.10,  5.23, 65.29,  13.62 }, // CAD
                { 0.67,   0.60,     0.52,   98.57,  0.58,   0.91,   1.0,   4.77, 59.61,  12.43 }, // AUD
                { 0.14,   0.13,     0.11,   21,     0.12,   0.19,   0.21,  1.0,  12.52,  2.60  }, // CNY
                { 0.011,  0.010,    0.0086, 1.65,   0.0097, 0.015,  0.017, 0.08, 1.0,    0.21  }, // RUB
                { 0.054,  0.049,    0.041,  7.92,   0.046,  0.073,  0.080, 0.38, 4.79,   1.0   }, // MXM
            };

            Console.Write("Introduce la cantidad de dinero: ");
            double cantidad = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduce la moneda de origen (USD, EUR, GBP, JPY, CHF, CAD, AUD, CNY, RUB o MXN): ");
            string monedaOrigen = Console.ReadLine().ToUpper();

            int indiceOrigen = -1;
            switch (monedaOrigen)
            {
                case "USD": indiceOrigen = 0; break;
                case "EUR": indiceOrigen = 1; break;
                case "GBP": indiceOrigen = 2; break;
                case "JPY": indiceOrigen = 3; break;
                case "CHF": indiceOrigen = 4; break;
                case "CAD": indiceOrigen = 5; break;
                case "AUD": indiceOrigen = 6; break;
                case "CNY": indiceOrigen = 7; break;
                case "RUB": indiceOrigen = 8; break;
                case "MXM": indiceOrigen = 9; break;

                default:
                    Console.WriteLine("Moneda no válida.");
                    return;
            }

            Console.Write("Introduce la moneda de destino (USD, EUR, GBP, JPY, CHF, CAD, AUD, CNY, RUB o MXN): ");
            string monedaDestino = Console.ReadLine().ToUpper();

            int indiceDestino = -1;
            switch (monedaDestino)
            {
                case "USD": indiceDestino = 0; break;
                case "EUR": indiceDestino = 1; break;
                case "GBP": indiceDestino = 2; break;
                case "JPY": indiceDestino = 3; break;
                case "CHF": indiceDestino = 4; break;
                case "CAD": indiceDestino = 5; break;
                case "AUD": indiceDestino = 6; break;
                case "CNY": indiceDestino = 7; break;
                case "RUB": indiceDestino = 8; break;
                case "MXM": indiceDestino = 9; break;

                default:
                    Console.WriteLine("Moneda no válida.");
                    return;
            }

            double cantidadConvertida = cantidad * tasasDeCambio[indiceOrigen, indiceDestino];

            Console.WriteLine($"{cantidad} {monedaOrigen} equivale a {cantidadConvertida} {monedaDestino}.");
            Console.ReadLine();
        }

        static void ConvertirMasa()
        {
            Console.WriteLine("Ejecutando conversión de Masa...");
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

        static void ConvertirVolumen()
        {
            Console.WriteLine("Ejecutando conversión de Volumen...");
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

        static void ConvertirLongitud()
        {
            Console.WriteLine("Ejecutando conversión de Longitud...");
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

        static void ConvertirAlmacenamiento()
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

        static void ConvertirTiempo()
        {
            string[] unidades = { "Segundos", "Minutos", "Horas", "Días", "Semanas", "Meses (30 días)", "Años (365 días)", "Milisegundos", "Microsegundos", "Nanosegundos" };

            double[,] factoresConversion = {
            //Segundos   //Minutos       //Horas           //Dias             //Semanas           //Meses              //Años               //Milisegundos //MicroSegun  //Nanosegun
            { 1,         1.0/60,         1.0/3600,         1.0/86400,         1.0/604800,         1.0/2.592e6,         1.0/3.154e7,         1000,          1e6,          1e9 },       // Segundos 
            { 60,        1,              1.0/60,           1.0/1440,          1.0/10080,          1.0/43200,           1.0/525600,          60000,         6e7,          6e10 },      // Minutos 
            { 3600,      60,             1,                1.0/24,            1.0/168,            1.0/720,             1.0/8760,            3.6e6,         3.6e9,        3.6e12 },    // Horas  
            { 86400,     1440,           24,               1,                 1.0/7,              1.0/30,              1.0/365,             8.64e7,        8.64e10,      8.64e13 },   // Días  
            { 604800,    10080,          168,              7,                 1,                  1.0/4.348,           1.0/52.143,          6.048e8,       6.048e11,     6.048e14 },  // Semanas 
            { 2.592e6,   43200,          720,              30,                4.348,              1,                   1.0/12,              2.592e9,       2.592e12,     2.592e15 },  // Meses  
            { 3.154e7,   525600,         8760,             365,               52.143,             12,                  1,                   3.154e10,      3.154e13,     3.154e16 },  // Años  
            { 0.001,     1.6667e-5,      2.7778e-7,        1.1574e-8,         1.6534e-9,          3.858e-10,           3.1689e-11,          1,             1000,         1e6 },       // Milisegundos  
            { 1e-6,      1.6667e-8,      2.7778e-10,       1.1574e-11,        1.6534e-12,         3.858e-13,           3.1689e-14,          0.001,         1,            1000 },      // Microsegundos 
            { 1e-9,      1.6667e-11,     2.7778e-13,       1.1574e-14,        1.6534e-15,         3.858e-16,           3.1689e-17,          1e-6,          0.001,        1 }          // Nanosegundos 
        };
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
            Console.WriteLine("Ingrese la cantidad a convertir:");
            double cantidad = double.Parse(Console.ReadLine());
            double resultado = cantidad * factoresConversion[unidadEntrada, unidadSalida];
            Console.WriteLine($"{cantidad} {unidades[unidadEntrada]} es igual a {resultado} {unidades[unidadSalida]}.");
            Console.ReadLine();
        }
    }
}
