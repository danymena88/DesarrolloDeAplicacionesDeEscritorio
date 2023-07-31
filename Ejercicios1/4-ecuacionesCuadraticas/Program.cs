double a, b, c, numerador, operacion, operacion2;
bool bandera = true;
Console.WriteLine("Vamos a solucionar una ecuación cuadrática del tipo:"); Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("ax^2 + bx + c = 0     la variable 'a' debe ser diferente a cero");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Ingrese los los valores de las variables a, b y c en ese orden (no decimales):");
while (bandera==true) {
    while (true) {
        Console.WriteLine("Ingrese el valor de la variable a:");
        string num1 = Console.ReadLine();
        Console.WriteLine("Ingrese el valor de la variable b:");
        string num2 = Console.ReadLine();
        Console.WriteLine("Ingrese el valor de la variable c:");
        string num3 = Console.ReadLine();
        if (double.TryParse(num1, out a) && double.TryParse(num2, out b) && double.TryParse(num3, out c))
        {
            if (a == 0)
            {
                Console.WriteLine("El número ingresado en la variable a es CERO, vuelva a ingresar los números...");
                continue;
            }
            else
            {
                //operacion = Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
                operacion2 = 4 * a * c;
                operacion = b * b;
                numerador = Math.Sqrt(operacion - operacion2);
                if (numerador % 1 == 0)
                {
                    Console.WriteLine("La primera solución es: X1=(" + (-1 * b) + "+" + numerador + ")/" + 2 * a);
                    Console.WriteLine("La segunda solución es: X2=(" + (-1 * b) + "-" + numerador + ")/" + 2 * a);
                    bandera = false;
                    break;
                }
                else if (operacion2 % 1 != 0 | operacion % 1 != 0)
                {
                    Console.WriteLine("La primera solución es: X1=(" + (-1 * b) + "+" + "√(" + operacion + "-" + operacion2 + ")/" + 2 * a);
                    Console.WriteLine("La segunda solución es: X2=(" + (-1 * b) + "-" + "√(" + operacion + "-" + operacion2 + ")/" + 2 * a);
                    bandera = false;
                    break;
                }
                else {
                    Console.WriteLine("La primera solución es: X1=(" + (-1 * b) + "+" + "√(" + operacion + "-" + operacion2 + ")/" + 2 * a);
                    Console.WriteLine("La segunda solución es: X2=(" + (-1 * b) + "-" + "√(" + operacion + "-" + operacion2 + ")/" + 2 * a);
                    bandera = false;
                    break;
                }
                
                
            }
        }
        else {
            Console.WriteLine("Debe ingresar sólo numeros (no letras ni caracteres especiales), vuelva a intentarlo");
            break;
        }
        
    }
}

Console.ReadKey();  