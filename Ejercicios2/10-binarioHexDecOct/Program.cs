using System.Runtime.InteropServices;

namespace binarioHexDecOct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            int pasarnum;
            List<int> nums = new List<int>();
            Console.WriteLine("Este es un conversor de Binario a Decimal, Hexadecimal y Octal");
            while (true)
            {
                Console.WriteLine("Ingresa un número binario (sólo ceros 0 y unos 1) de 20 caracteres máximo:");
                usuario = Console.ReadLine();
                if (usuario == "")
                {
                    Console.WriteLine("Por favor ingrese un número binario...");
                }
                else
                {
                    if (usuario.Length <= 20)
                    {
                        foreach (char i in usuario)
                        {
                            try
                            {
                                pasarnum = int.Parse(i.ToString());
                                nums.Add(pasarnum);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Error al procersar los numeros, inténtelo de nuevo...");
                                nums.Clear();
                                break;
                            }
                        }
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"El equivalente decimal de ese binario es: {Decimal(nums)}");
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Console.WriteLine($"El equivalente hexadecimal de ese binario es: {Hex(Decimal(nums))}");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"El equivalente Octal de ese binario es: {Oct(Decimal(nums))}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("La cadena de números es demasiado larga, vuelva a intentarlo...");
                    }
                }

            }

        }

        static int Decimal(List<int> numsd)
        {
            int suma = 0;
            double potencia = 0.0;
            for (var i = numsd.Count -1; i >= 0; i--)
            {
                suma = suma + ((numsd[i]) * (Convert.ToInt32(Math.Pow(2.0, potencia))));
                potencia++;
            }
            return suma;
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
