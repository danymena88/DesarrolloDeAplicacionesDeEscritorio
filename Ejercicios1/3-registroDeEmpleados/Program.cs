
int dui = 0;
double salarioHora, horas, salario, renta, neto;
List<List<string>> empleados = new List<List<string>>();
String info;
bool bandera = true;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Vamos a crear una tabla de tus empleados, ingresa 5 empleados.");
Console.ForegroundColor = ConsoleColor.White;


while (bandera == true) {
    for (int i = 0; i < 5; i++)
    {
        var empleado = new List<string>();
        Console.WriteLine("Ingresa el nombre completo del empleado #" + (i+1) + ": ");
        info = Console.ReadLine();
        if (info == "")
        {
            Console.WriteLine("Debe escribir el nombre del empleado...");
            empleados.Clear();
            break;
        }
        else {
            empleado.Add(info);
        }
        Console.WriteLine("Ingresa el número de DUI (sin guión) del empleado #" + (i + 1) + ": ");
        info = Console.ReadLine();
        if (int.TryParse(info, out dui))
        {
            empleado.Add(dui.ToString());
        }
        else {
            Console.WriteLine("El # de dui debe contener sólo números enteros...");
            empleados.Clear();
            break;
        }
        Console.WriteLine("Ingresa el número de NIT del empleado #" + (i + 1) + ": ");
        info = Console.ReadLine();
        if (info == "")
        {
            Console.WriteLine("Debe escribir un número de NIT...");
            empleados.Clear();
            break;
        }
        else {
            empleado.Add(info);
        }
        Console.WriteLine("Ingresa el salario por HORA que gana el empleado #" + (i + 1) + ": ");
        info = Console.ReadLine();
        if (double.TryParse(info, out salarioHora)) {
            empleado.Add(salarioHora.ToString());
        }
        else {
            Console.WriteLine("El salario por Hora debe ser de tipo número...");
            empleados.Clear();
            break;
        }
        Console.WriteLine("Ingresa la cantidad de horas trabajadas por el empleado #" + (i + 1) + ": ");
        info = Console.ReadLine();
        if (double.TryParse(info, out horas))
        {
            empleado.Add(horas.ToString());
        }
        else
        {
            Console.WriteLine("La cantidad de horas debe ser de tipo número...");
            empleados.Clear();
            break;
        }
        empleados.Add(empleado);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(empleado[0] + " fue ingresado/a con éxito!");
        Console.ForegroundColor = ConsoleColor.White;
        if (i == 4) {
            bandera = false;
        }
    }
}


Console.WriteLine("A continuación se muestra la lista de los empleados:\n.\n.");
Console.ForegroundColor = ConsoleColor.Green;
PrintLine();
PrintRow("Nombre", "DUI", "NIT", "Salario/Hora", "Salario", "Renta", "Neto");
foreach (var i in empleados)
{
    salario = Convert.ToDouble(i[3], null) * Convert.ToDouble(i[4], null);
    renta = salario * 0.1;
    neto = salario - renta;
    PrintLine();
    PrintRow(i[0], i[1], i[2], "$"+i[3], "$"+salario.ToString(), "$" + renta.ToString(), "$"+neto.ToString());
}


static void PrintLine()
{
    int tableWidth = 120;
    Console.WriteLine(new string('-', tableWidth));
}


static void PrintRow(params string[] columns)
{
    int tableWidth = 120;
    int width = (tableWidth - columns.Length) / columns.Length;
    string row = "|";
    foreach (string column in columns)
    {
        row += Aligncenter(column, width) + "|";
    }

    Console.WriteLine(row);

}

static string Aligncenter(string text, int width)
{
    text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

    if (string.IsNullOrEmpty(text))
    {
        return new string(' ', width);
    }

    else
    {
        return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
    }
}
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();