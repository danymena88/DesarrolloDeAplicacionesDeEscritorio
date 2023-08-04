using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_registroDeEmpleados_conClases_
{
    internal class Empleado
    {
        private string nombre, nit;
        private int dui;
        private double salarioXhora, horasTrabajadas, salario, renta, neto;
        public string NombreEmpleado
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Nit
        {
            get { return nit; }
            set { nit = value; }
        }
        public int Dui
        {
            get { return dui; }
            set { dui = value; }
        }
        public double SalarioXhora { get => salarioXhora; set => salarioXhora = value; }
        public double HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }

        public void crearEmpleado(string _nombre, int _dui, string _nit, double _salarioXhora, double _horasTrabajadas)
        {
            nombre = _nombre;
            dui = _dui;
            nit = _nit;
            salarioXhora = _salarioXhora;
            horasTrabajadas = _horasTrabajadas;
            salario = Convert.ToDouble(_salarioXhora, null) * Convert.ToDouble(_horasTrabajadas, null);
            renta = salario * 0.1;
            neto = salario - renta;

        }

        public void imprimirTitulos()
        {
            PrintLine();
            PrintRow("Nombre", "DUI", "NIT", "Salario/Hora", "Salario", "Renta", "Neto");
            PrintLine();
        }

        public void imprimirEmpleado()
        {
            PrintRow(nombre, dui.ToString(), nit, salarioXhora.ToString(), salario.ToString(), renta.ToString(), neto.ToString());
            PrintLine();
        }

        public void PrintLine()
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
    }
}
