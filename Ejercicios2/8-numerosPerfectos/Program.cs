using System;
using System.Runtime.InteropServices;

namespace numerosPerfectos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String usuario_;
            long validado;
            Console.WriteLine("Se dice que un número entero es PERFECTO si sus factores, incluyendo 1 (Pero no el mismo número entero), al sumarse dan como resultado ese número entero.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese a continuación un número entero y evaluaremos si es perfecto o no...");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                usuario_ = Console.ReadLine();
                Console.WriteLine("\n");
                if (long.TryParse(usuario_, out validado))
                {
                    Evaluar(validado);
                    break;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número entero... Inténtelo de nuevo");
                }
            }
            Console.WriteLine("Entre los números del 1 al 1000 sólo existen 3 números perfectos:");
            for (int i = 1; i < 6; i++)
            {
                int num, k = 1, num2 = 0;
                List<int> factores = new List<int>();
                num = Convert.ToInt32((Math.Pow(2, (i - 1))) * (Math.Pow(2, i) - 1));
                while (k < num)
                {
                    if (num % k == 0)
                    {
                        num2 += k;
                    }
                    k++;
                }
                if (num2 == num)
                {
                    Console.WriteLine(num2);
                }
            }
            Console.ReadKey();
        }

        static void Evaluar(long usuario)
        {
            String resultado = "[ ";
            int num2 = 0, k = 1, conteo;
            List<int> factores = new List<int>();
            while (k < usuario)
            {
                if (usuario % k == 0)
                {
                    num2 += k;
                    factores.Add(k);
                }
                k++;
            }
            if (num2 == usuario)
            {
                conteo = factores.Count;
                int index = 1;
                foreach (int i in factores)
                {
                    if (conteo == index)
                    {
                        resultado = resultado + $"{i} ";
                    }
                    else
                    {
                        resultado = resultado + $"{i} + ";
                    }
                    index++;
                }
                resultado = resultado + $"= {usuario} ]";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"El número {usuario} si es un número perfecto");
                Console.WriteLine(resultado);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"El número {usuario} NO es perfecto");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
    }
}