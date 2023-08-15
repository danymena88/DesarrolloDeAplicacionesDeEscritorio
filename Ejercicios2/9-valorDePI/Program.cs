namespace valorDePI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario, resultado = "";
            int numero, cambiodesigno = 1;
            double suma = 0;
            List<string> lista = new List<string>();
            Console.WriteLine("Ingrese un número entero entre 1 y 10,000");
            while (true)
            {
                usuario = Console.ReadLine();
                if (Int32.TryParse(usuario, out numero))
                {
                    if (numero >= 1 && numero <= 10000)
                    {
                        for (double i = 1; i <= numero; i++)
                        {
                            if (i % 2 != 0)
                            {
                                if (cambiodesigno % 2 != 0)
                                {
                                    suma = suma + (4 / i);
                                    lista.Add($"4/{i} - ");
                                    cambiodesigno++;
                                    //Console.WriteLine($"+{i}");
                                }
                                else
                                {
                                    suma = suma - (4 / i);
                                    lista.Add($"4/{i} + ");
                                    cambiodesigno++;
                                    //Console.WriteLine($"-{i}");
                                }
                            }
                        }
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Pi = {suma}");
                        Console.ForegroundColor= ConsoleColor.White;
                        Console.WriteLine("\n");
                        foreach (string a in lista)
                        {
                            resultado = resultado + a;
                        }
                        Console.WriteLine(resultado);
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("El número no está dentro del rango especificado.");
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número entero, inténtelo de nuevo...");
                }
            }
        }
    }
}