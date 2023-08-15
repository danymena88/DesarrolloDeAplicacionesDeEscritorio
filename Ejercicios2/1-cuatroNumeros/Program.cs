
namespace cuatroNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> numerosOP = new List<double>();
            string numUsuario;
            double numero, suma, producto;
            Console.WriteLine("Ingrese 4 números y haremos operaciones con ellos...");
            for (int i = 0; i < 4; i++)
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
            suma = numerosOP[0] + numerosOP[1];
            producto = numerosOP[2] * numerosOP[3];
            Console.WriteLine($"La suma de los dos primeros números es: {suma.ToString()}");
            Console.WriteLine($"El producto de los dos últimos números es: {producto.ToString()}");
            Console.ReadKey();
        }
    }
}