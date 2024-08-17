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
    }
}
