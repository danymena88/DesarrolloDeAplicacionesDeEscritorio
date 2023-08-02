using System;
using System.Formats.Tar;
using System.IO;

class Test
{
    public static void Main()
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        path = path + @"\toDoList.txt";
        string lin;
        int lineas;

        try
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.CreateNew)))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Vamos a escribir un archivo .txt con una lista de tareas...");
                Console.ForegroundColor= ConsoleColor.White;
                bool bandera = true;
                while (bandera==true) {
                    Console.WriteLine("Cuántas tareas agregaremos?? (ingresa un número)");
                    lin = Console.ReadLine();
                    if (int.TryParse(lin, out lineas))
                    {
                        sw.WriteLine("Mi lista de tareas:");
                        sw.WriteLine("");
                        for (int j = 0; j < lineas; j++) {
                            string tarea;
                            Console.WriteLine("Escribe la tarea #" + (j+1) + ":");
                            tarea = Console.ReadLine();
                            sw.WriteLine("#" + (j+1) + ". " + tarea);                     
                        }
                        bandera = false;   
                    }
                    else
                    {
                        Console.WriteLine("Debes ingresar un número entero...");
                    }
                }
            }
            Console.WriteLine("\n\nLeyendo el archivo...");
            Console.ForegroundColor = ConsoleColor.Cyan;
            using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open)))
            {
                while (sr.Peek() >= 0)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ha ocurrido un error: {0}", e.ToString());
        }
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
    }
}