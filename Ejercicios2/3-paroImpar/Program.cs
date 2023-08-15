namespace paroImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int resultado;
            while (true)
            {
                Console.WriteLine("Ingresa un número entero para saber si es par o impar...");
                numero = Console.ReadLine();
                if (Int32.TryParse(numero, out resultado))
                {
                    if (resultado % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("El número ingresado es PAR");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("El número ingresado es IMPAR");
                        Console.ForegroundColor= ConsoleColor.White;
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