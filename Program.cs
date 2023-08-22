using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculoCilindros
{
    class Program
    {
        static double CalcularArea(double radio, double altura)
        {
            return 2 * Math.PI * radio * (altura + radio);
        }

        static double CalcularBase(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        static double CalcularVolumen(double baseCilindro, double altura)
        {
            return baseCilindro * altura;
        }

        static void Main(string[] args)
        {
            int cantidadCilindros = 0;

            Console.WriteLine("Ingrese los valores de radio y altura del cilindro (ingrese 0 en ambos para salir).");

            do
            {
                double radio, altura;

                while (true)
                {
                    Console.Write("Radio: ");
                    if (double.TryParse(Console.ReadLine(), out radio) && radio >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Ingrese un número positivo.");
                    }
                }

                while (true)
                {
                    Console.Write("Altura: ");
                    if (double.TryParse(Console.ReadLine(), out altura) && altura >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido. Ingrese un número positivo.");
                    }
                }

                if (radio != 0 && altura != 0)
                {
                    double baseCilindro = CalcularBase(radio);
                    double areaCilindro = CalcularArea(radio, altura);
                    double volumenCilindro = CalcularVolumen(baseCilindro, altura);

                    Console.WriteLine($"Área del cilindro: {areaCilindro}");
                    Console.WriteLine($"Volumen del cilindro: {volumenCilindro}");

                    cantidadCilindros++;
                }

            } while (true);

            Console.WriteLine($"Proceso finalizado. Cantidad de cilindros ingresados: {cantidadCilindros}");
        }
    }
}
