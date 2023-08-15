using System.Security.Cryptography.X509Certificates;

namespace sumaDeNummerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1, num2;
            int entero1, entero2;
            Console.WriteLine("Ingresa un rango de números enteros y se realizará la suma de los números pares comprendidos en dicho rango");
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Ingresa el número menor del rango");
                    num1 = Console.ReadLine();
                    if (Int32.TryParse(num1, out entero1))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un número entero, vuelva a intentarlo...");
                    }
                }
                while (true)
                {
                    Console.WriteLine("Ingresa el número mayor del rango");
                    num2 = Console.ReadLine();
                    if (Int32.TryParse(num2, out entero2))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un número entero, vuelva a intentarlo...");
                    }
                }
                if (entero1 < entero2)
                {
                    SumarPares(entero1, entero2);
                    break;
                }
                else
                {
                    Console.WriteLine("El primer número debe ser menor al segundo");
                }
            }
        }

        static void SumarPares(int menor, int mayor)
        {
            int suma = 0;
            for (int i = menor; i <= mayor; i++)
            {
                if (i % 2 == 0)
                {
                    suma = suma + i;
                }
            }
            Console.WriteLine($"La suma de todos los números pares que existen entre {menor} y {mayor} es {suma}");
            Console.ReadKey();
        }
    }
}