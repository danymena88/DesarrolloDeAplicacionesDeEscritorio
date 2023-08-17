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
                        Decimal(nums);
                    }
                    else
                    {
                        Console.WriteLine("La cadena de números es demasiado larga, vuelva a intentarlo...");
                    }
                }

            }

        }
    }
}