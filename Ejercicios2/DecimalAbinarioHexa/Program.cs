
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DecimalAbinarioHexa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            int pasarnum;
            List<int> nums = new List<int>();
            Console.WriteLine("Este es un conversor de Decimal a Binario, Hexadecimal y Octal");
            while (true)
            {
                Console.WriteLine("Ingresa un número Decimal:");
                usuario = Console.ReadLine();
                if (usuario == "")
                {
                    Console.WriteLine("Por favor ingrese un número Decimal...");
                }
                else
                {
                    if (Int32.TryParse(usuario, out pasarnum))
                    {
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"El equivalente binario de ese decimal es: {Binario(pasarnum)}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"El equivalente hexadecimal de ese decimal es: {Hex(pasarnum)}");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"El equivalente Octal de ese decimal es: {Oct(pasarnum)}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("El valor ingresado no es número entero, vuelva a intentarlo...");
                    }
                }

            }

        }

        static string Binario(int cociente)
        {
            string resultado = "";
            int residuo;
            residuo = cociente % 2;
            cociente = cociente / 2;
            if (cociente < 2)
            {
                return cociente.ToString() + residuo.ToString();
            }
            else
            {
                resultado = Binario(cociente) + residuo.ToString();
            }
            return resultado;
        }




        static string Hex(int cociente)
        {
            List<string> hexadecimal = new List<string>() { "A", "B", "C", "D", "E", "F" };
            string resultado = "";
            int residuo;
            residuo = cociente % 16;
            cociente = cociente / 16;
            if (cociente < 16)
            {
                if (cociente > 9)
                {
                    cociente -= 10;
                    if (residuo > 9)
                    {
                        residuo -= 10;
                        return hexadecimal[cociente] + hexadecimal[residuo];
                    }
                    else
                    {
                        return hexadecimal[cociente] + residuo.ToString();
                    }
                }
                else
                {
                    if (residuo > 9)
                    {
                        residuo -= 10;
                        return cociente.ToString() + hexadecimal[residuo];
                    }
                    else
                    {
                        return cociente.ToString() + residuo.ToString();
                    }
                }
            }
            else
            {
                if (residuo > 9)
                {
                    residuo -= 10;
                    resultado = Hex(cociente) + hexadecimal[residuo];
                }
                else
                {
                    resultado = Hex(cociente) + residuo.ToString();
                }
            }
            return resultado;
        }



        static string Oct(int cociente)
        {
            string resultado = "";
            int residuo;
            residuo = cociente % 8;
            cociente = cociente / 8;
            if (cociente < 8)
            {
                return cociente.ToString() + residuo.ToString();
            }
            else
            {
                resultado = Oct(cociente) + residuo.ToString();
            }
            return resultado;
        }
    }
}