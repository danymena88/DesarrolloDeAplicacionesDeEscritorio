using _6_registroDeEmpleados_conClases_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int dui = 0;
double salarioHora, horas, salario, renta, neto;
List<List<string>> empleados = new List<List<string>>();
String info, evaluar;
bool bandera = true;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Vamos a crear una tabla de tus empleados, ingresa 5 empleados.");
Console.ForegroundColor = ConsoleColor.White;


while (bandera == true)
{
    for (int i = 0; i < 2; i++)
    {
        var empleado = new List<string>();
        Console.WriteLine("Ingresa el nombre completo del empleado #" + (i + 1) + ": ");
        info = Console.ReadLine();
        if (info == "")
        {
            Console.WriteLine("Debe escribir el nombre del empleado...");
            empleados.Clear();
            break;
        }
        else
        {
            empleado.Add(info);
        }
        Console.WriteLine("Ingresa el número de DUI (sin guión) del empleado #" + (i + 1) + ": ");
        info = Console.ReadLine();
        if (int.TryParse(info, out dui))
        {
            empleado.Add(dui.ToString());
        }
        else
        {
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
        else
        {
            empleado.Add(info);
        }
        Console.WriteLine("Ingresa el salario por HORA que gana el empleado #" + (i + 1) + ": ");
        info = Console.ReadLine();
        if (double.TryParse(info, out salarioHora))
        {
            empleado.Add(salarioHora.ToString());
        }
        else
        {
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
        if (i == 1)
        {
            bandera = false;
        }
    }
}

Console.WriteLine("A continuación se muestra la lista de los empleados:\n.\n.");
Console.ForegroundColor = ConsoleColor.Green;
evaluar = empleados[0][0]; 
foreach (var i in empleados)
{
    Empleado objEmpleado = new Empleado();
    objEmpleado.crearEmpleado(i[0], Int32.Parse(i[1]), i[2], double.Parse(i[3]), double.Parse(i[4]));
    if (i[0] == evaluar)
    {
        objEmpleado.imprimirTitulos();
    }
    objEmpleado.imprimirEmpleado();
}

Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();
