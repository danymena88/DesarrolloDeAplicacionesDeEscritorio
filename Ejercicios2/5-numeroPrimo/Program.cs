
namespace numeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String numeroUsuario;
            int entero;
            while (true)
            {
                Console.WriteLine("Ingrese un número entero y comprobaremos si es número primo...");
                numeroUsuario = Console.ReadLine();
                if (int.TryParse(numeroUsuario, out entero))
                {
                    MetodoPrimo num = new MetodoPrimo();
                    Console.WriteLine($"El número ingresado es primo: {num.EsPrimo(entero)}");
                }
                else
                {
                    Console.WriteLine("Sólo se permite números enteros...");
                }
            }
        }
    }
}