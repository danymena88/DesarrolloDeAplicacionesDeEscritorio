namespace numeroMayoryMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numerosOP = new List<double>();
            string numUsuario;
            double numero;
            Console.WriteLine("Ingrese 3 números e identificaremos el mayor y menor");
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Ingrese el {i + 1}° número:");
                    numUsuario = Console.ReadLine();
                    if (double.TryParse(numUsuario, out numero))
                    {
                        numerosOP.Add(numero);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar sólo numeros...");
                    }
                }
            }
            numerosOP.Sort();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"El número mayor es {numerosOP[2]} y el menor es {numerosOP[0]}");
            Console.ForegroundColor= ConsoleColor.White;
            Console.ReadKey();
        }
    }
}