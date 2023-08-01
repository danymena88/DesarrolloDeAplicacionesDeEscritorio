String nombreProducto;
int cantidadxProducto, cantidadDeProductos = 10;
double precio, total, totalAcumulado = 0;

for (int i = 1; i <= cantidadDeProductos; i++)
{
    Console.WriteLine("Nombre del producto #" + i + ":");
    nombreProducto = Console.ReadLine();
    Console.WriteLine("Cantidad del producto #" + i + ":");
    cantidadxProducto = int.Parse(Console.ReadLine());
    Console.WriteLine("Precio del producto #" + i + ":");
    precio = double.Parse(Console.ReadLine());
    total = (cantidadxProducto * precio) * 1.13;
    totalAcumulado = totalAcumulado + total;
    Console.Clear();
}
Console.WriteLine("El total a pagar es: $" + double.Round(totalAcumulado, 2) + " (IVA incluido)");
