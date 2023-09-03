using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenPractico1DAE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            bool bandera = true;
            while (bandera == true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nElige la aplicación que deseas utilizar (coloca el número):");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n1 -Ejercicio 1 (Guardar canciones)\n2 -Ejercicio 2 (Registro de alumnos)\n3 -Salir");
                usuario = Console.ReadLine();
                switch (usuario)
                {
                    case "1":
                        Canciones();
                        break;
                    case "2":
                        Alumnos();
                        break;
                    case "3":
                        Console.WriteLine("Salió de la app...");
                        bandera = false;
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Debe escribir una opción válida...");
                        Console.ForegroundColor= ConsoleColor.White;
                        break;
                }
            }
        }


        static void Canciones()
        {
            bool bandera = true;
            string[][] matriz = new string[20][];
            while (bandera == true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Guardaremos la información de tus canciones favoritas (máximo 20):");
                Console.ForegroundColor = ConsoleColor.White;
                string respuesta = "";
                for (int i = 0; i < matriz.Length; i++)
                {
                    matriz[i] = new string[4];
                    int numero;
                    while (true)
                    {
                        Console.WriteLine($"Cual es el título de la canción #{i + 1}?");
                        respuesta = Console.ReadLine();
                        if (respuesta != "")
                        {
                            matriz[i][0] = respuesta;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Debe escribir una respuesta...");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine($"Quién es el artista de la canción {matriz[i][0]}?");
                        respuesta = Console.ReadLine();
                        if (respuesta != "")
                        {
                            matriz[i][1] = respuesta;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Debe escribir una respuesta...");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine($"Cuántos segundos dura la canción {matriz[i][0]}?");
                        respuesta = Console.ReadLine();
                        if (Int32.TryParse(respuesta, out numero))
                        {
                            matriz[i][2] = Convert.ToString(numero);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Debe escribir un número entero...");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine($"Cuántos kilobytes pesa la canción {matriz[i][0]}?");
                        respuesta = Console.ReadLine();
                        if (Int32.TryParse(respuesta, out numero))
                        {
                            matriz[i][3] = Convert.ToString(numero);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Debe escribir un número entero...");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Deseas agregar otra canción? (s = Si, n = No)");
                        respuesta = Console.ReadLine();
                        if (respuesta == "n")
                        {
                            i = 21;
                            bandera = false;
                            break;
                        }
                        else if (respuesta == "s")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Debes escribir una respuesta válida...");
                        }
                    }
                    
                }

            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Estas son las canciones guardadas:");
            Console.ForegroundColor = ConsoleColor.White;
            for (int m = 0; m <= 20; m++)
            {
                try
                {
                    Console.WriteLine($"La canción número {m + 1} es: {matriz[m][0]}.mp3\nInterpretada por: {matriz[m][1]}\nDuración: {matriz[m][2]} Segundos\nPeso: {matriz[m][3]} Kb\n");
                }
                catch (Exception e)
                {
                    //  Block of code to handle errors
                }
            }
            Console.ReadKey();
        }


        static void Alumnos()
        {
            string[][] alumnos = new string[200][];
            string usuario;
            bool bandera = true;
            while (bandera == true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sistema de registro de alumnos");
                Console.WriteLine("Que acción desea realizar?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1 -Agregar alumno\n2 -Mostrar listado de alumnos\n3 -Buscar alumno por código\n4 -Editar la información de un alumno\n5 - Salir");
                usuario = Console.ReadLine();
                switch (usuario)
                {
                    case "1":
                        int verificar = 0;
                        for (int i = 0; i < alumnos.Length; i++)
                        {
                            for (int v = verificar; v < alumnos.Length; v++)
                            {
                                try
                                {
                                    if (alumnos[verificar].Length == 5)
                                    {
                                        verificar++;
                                    }
                                }
                                catch (Exception e)
                                {
                                    break;
                                }
                            }
                            alumnos[verificar] = new string[5];
                            int numero;
                            string respuesta;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Registraremos al nuevo alumno");
                            Console.ForegroundColor = ConsoleColor.White;
                            while (true)
                            {
                                Console.WriteLine("Ingrese el código del nuevo alumno (número entero):");
                                respuesta = Console.ReadLine();
                                if (Int32.TryParse(respuesta, out numero))
                                {
                                    alumnos[verificar][0] = Convert.ToString(numero);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Debe escribir un número entero...");
                                }
                            }
                            while (true)
                            {
                                Console.WriteLine("Nombre completo del Alumno:");
                                respuesta = Console.ReadLine();
                                if (respuesta != "")
                                {
                                    alumnos[verificar][1] = respuesta;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Debe escribir el nombre completo...");
                                }
                            }
                            while (true)
                            {
                                Console.WriteLine("Fecha de nacimiento del alumno (formato dd/mm/aaaa):");
                                respuesta = Console.ReadLine();
                                if (respuesta != "")
                                {
                                    alumnos[verificar][2] = respuesta;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Debe escribir una fecha de nacimiento...");
                                }
                            }
                            while (true)
                            {
                                Console.WriteLine("Ingrese el grado al que asiste el alumno (en decimal):");
                                respuesta = Console.ReadLine();
                                if (Int32.TryParse(respuesta, out numero))
                                {
                                    alumnos[verificar][3] = Convert.ToString(numero);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Debe escribir un número entero...");
                                }
                            }
                            while (true)
                            {
                                Console.WriteLine("Año de registro del alumno:");
                                respuesta = Console.ReadLine();
                                if (Int32.TryParse(respuesta, out numero))
                                {
                                    alumnos[verificar][4] = Convert.ToString(numero);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Debe escribir un número entero...");
                                }
                            }
                            while (true)
                            {
                                Console.WriteLine("Deseas agregar otro alumno? (s = Si, n = No)");
                                respuesta = Console.ReadLine();
                                if (respuesta == "n")
                                {
                                    i = 201;
                                    break;
                                }
                                else if (respuesta == "s")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Debes escribir una respuesta válida...");
                                }
                            }

                        }
                        break;
                    case "2":
                        ListaAlumnos(alumnos);
                        break;
                    case "3":
                        BuscarAlumnos(alumnos);
                        break;
                    case "4":
                        try
                        {
                            if (alumnos[0].Length == 5)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Editar información de alumnos registrados");
                                Console.ForegroundColor = ConsoleColor.White;
                                int codigo, resultado;
                                bool verificar2 = false;
                                while (true)
                                {
                                    Console.WriteLine("Escriba el código del alumno que desea editar:");
                                    string busqueda = Console.ReadLine();
                                    if (Int32.TryParse(busqueda, out codigo))
                                    {
                                        try
                                        {
                                            foreach (string[] m in alumnos)
                                            {
                                                try
                                                {
                                                    Int32.TryParse(m[0], out resultado);
                                                    if (resultado == codigo)
                                                    {
                                                        Console.WriteLine("Se encontró este registro:\n");
                                                        Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                                                        Console.WriteLine($"  Código: {m[0]}  |  Nombre: {m[1]}  |  Fecha de Nacimiento: {m[2]}  |  Grado: {m[3]}°  |  Año de Registro: {m[4]}");
                                                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                                                        verificar2 = true;
                                                        bool bandera2 = true;
                                                        int entero;
                                                        while (bandera2 == true)
                                                        {
                                                            Console.WriteLine("\nQue campo desea modificar?\n1 -Código\n2 -Nombre\n3 -Fecha de Nacimiento\n4 -Grado\n5 -Año de Registro\n6 CANCELAR");
                                                            string usuario2 = Console.ReadLine();
                                                            switch (usuario2)
                                                            {
                                                                case "1":
                                                                    Console.WriteLine("Ingrese el nuevo valor del campo Código (número entero):");
                                                                    usuario2 = Console.ReadLine();
                                                                    if (Int32.TryParse(usuario2, out entero))
                                                                    {
                                                                        m[0] = Convert.ToString(entero);
                                                                        bandera2 = false;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("No ingresó un dato válido...");
                                                                    }
                                                                    break;
                                                                case "2":
                                                                    Console.WriteLine("Ingrese el nuevo valor del campo Nombre:");
                                                                    usuario2 = Console.ReadLine();
                                                                    if (usuario2 != "")
                                                                    {
                                                                        m[1] = usuario2;
                                                                        bandera2 = false;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("Debe ingresar un nuevo nombre...");
                                                                    }
                                                                    break;
                                                                case "3":
                                                                    Console.WriteLine("Ingrese el nuevo valor del campo Fecha de Nacimiento:");
                                                                    usuario2 = Console.ReadLine();
                                                                    if (usuario2 != "")
                                                                    {
                                                                        m[2] = usuario2;
                                                                        bandera2 = false;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("Debe ingresar una nueva fecha...");
                                                                    }
                                                                    break;
                                                                case "4":
                                                                    Console.WriteLine("Ingrese el nuevo valor del campo Grado (número entero):");
                                                                    usuario2 = Console.ReadLine();
                                                                    if (Int32.TryParse(usuario2, out entero))
                                                                    {
                                                                        m[3] = Convert.ToString(entero);
                                                                        bandera2 = false;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("No ingresó un dato válido...");
                                                                    }
                                                                    break;
                                                                case "5":
                                                                    Console.WriteLine("Ingrese el nuevo valor del campo Año de Registro (número entero):");
                                                                    usuario2 = Console.ReadLine();
                                                                    if (Int32.TryParse(usuario2, out entero))
                                                                    {
                                                                        m[4] = Convert.ToString(entero);
                                                                        bandera2 = false;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("No ingresó un dato válido...");
                                                                    }
                                                                    break;
                                                                case "6":
                                                                    bandera2 = false;
                                                                    break;
                                                                default:
                                                                    Console.WriteLine("Ingrese la opción correcta...");
                                                                    break;
                                                            }
                                                        }
                                                    }
                                                }
                                                catch (Exception e)
                                                {
                                                    break;

                                                }

                                            }
                                            break;

                                        }
                                        catch (Exception e)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Aún no ha registrado alumnos...");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Debe ingresar un número entero...");
                                    }
                                }
                                if (verificar2 == false)
                                {
                                    Console.WriteLine("No se encontró ningún registro...");
                                }
                                Console.ReadKey();
                            }

                        }
                        catch (Exception e)
                        {
                            Console.Clear();
                            Console.WriteLine("Aún no ha registrado alumnos...");
                            Console.ReadKey();
                        }
                        break;                   
                
                    case "5":
                        Console.WriteLine("Salió de la app...");
                        bandera = false;
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Debe escribir una opción válida...");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }

        }


        static void ListaAlumnos(string[][] arreglo)
        {
            
            try
            {
                if (arreglo[0].Length == 5)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Lista de alumnos registrados:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                    for (int m = 0; m <= 20; m++)
                    {
                        try
                        {
                            Console.WriteLine($"  Código: {arreglo[m][0]}  |  Nombre: {arreglo[m][1]}  |  Fecha de Nacimiento: {arreglo[m][2]}  |  Grado: {arreglo[m][3]}°  |  Año de Registro: {arreglo[m][4]}");
                        }
                        catch (Exception e)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                    Console.ReadKey();
                }
                    
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Aún no ha registrado alumnos...");
                Console.ReadKey();
            }
        }






        static void BuscarAlumnos(string[][] arreglo)
        {
            try
            {
                if (arreglo[0].Length == 5)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Búsqueda de alumnos registrados");
                    Console.ForegroundColor = ConsoleColor.White;
                    int codigo, resultado;
                    bool verificar = false;
                    while (true)
                    {
                        Console.WriteLine("Escriba el código del alumno:");
                        string busqueda = Console.ReadLine();
                        if (Int32.TryParse(busqueda, out codigo))
                        {
                            try
                            {
                                foreach (string[] m in arreglo)
                                {
                                    try
                                    {
                                        Int32.TryParse(m[0], out resultado);
                                        if (resultado == codigo)
                                        {
                                            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                                            Console.WriteLine($"  Código: {m[0]}  |  Nombre: {m[1]}  |  Fecha de Nacimiento: {m[2]}  |  Grado: {m[3]}°  |  Año de Registro: {m[4]}");
                                            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
                                            verificar = true;
                                        }
                                    }
                                    catch (Exception e)
                                    {
                                        break;

                                    } 

                                }
                                break;

                            }
                            catch (Exception e)
                            {
                                Console.Clear();
                                Console.WriteLine("Aún no ha registrado alumnos...");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Debe ingresar un número entero...");
                        }
                    }
                    if (verificar == false)
                    {
                        Console.WriteLine("No se encontró ningún registro...");
                    }
                    Console.ReadKey();
                }

            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Aún no ha registrado alumnos...");
                Console.ReadKey();
            }
        }




        
            
    }
}