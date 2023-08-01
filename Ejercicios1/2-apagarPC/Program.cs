using System.Diagnostics;
String comando;
int minutos;
bool result;
bool bandera = true;

Console.WriteLine("Que comando desea ejecutar??");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("1.Programar apagado (ingrese 1)     2.Cancelar apagado (ingrese 2)");
Console.ForegroundColor = ConsoleColor.White;
while (bandera == true) {
    Console.WriteLine("Escriba su opción: ");
    comando = Console.ReadLine();
    if (comando == "1") {
        while (bandera == true) {
            Console.WriteLine("Dentro de cuantos minutos? (sólo números enteros)");
            comando = Console.ReadLine();
            if (result = int.TryParse(comando, out minutos))
            {
                Process.Start("cmd.exe", "/C shutdown -s -t " + (minutos*60));
                bandera = false;
            }
            else
            {
                Console.WriteLine("El número no es entero");
            }
        }
    }
    else if (comando == "2")
    {
        Console.WriteLine("Se procederá a cancelar el apagado programado...");
        Process.Start("cmd.exe", "/C shutdown -a");
        Console.WriteLine("Su equipo NO se apagará automáticamente");
        bandera = false;
    }
    else { Console.WriteLine("Opción no válida..."); }
}
Process.Start("cmd.exe", "/C exit");

