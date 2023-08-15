namespace totalPrecioArticulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String articulo, cantidad, precio;
            int cantidadInt;
            double precioUni;
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del artículo a comprar...");
                articulo = Console.ReadLine();
                if (articulo == "")
                {
                    Console.WriteLine("Debe escribir el nombre del artículo...");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                Console.WriteLine("Ingrese la cantidad a comprar...");
                cantidad = Console.ReadLine();
                if (int.TryParse(cantidad, out cantidadInt))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número entero...");
                }
            }
            while (true)
            {
                Console.WriteLine("Inmgrese el precio unitario del artículo...");
                precio = Console.ReadLine();
                if (double.TryParse(precio, out precioUni))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Debe ingresar el precio...");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"El total de la compra es: ${precioUni * cantidadInt}");
            Console.WriteLine($"Artículo: {articulo}  -- Cantidad: {cantidadInt}  --  P/Unitario: ${precioUni}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}