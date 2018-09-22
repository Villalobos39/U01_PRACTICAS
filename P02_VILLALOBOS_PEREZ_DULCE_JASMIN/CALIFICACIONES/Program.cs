using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALIFICACIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" \n REGISTRO DE CALIFICACIONES \n ");

            INFORMACION C = new INFORMACION();
            string s;
            do
            {
                try
                {
                    C.CAPTURAR();
                    C.IMPRIMIR();
                }

                catch (FormatException e) { Console.Write(e.Message); }

                Console.WriteLine("\n ____________________________________________\n");
                Console.WriteLine("DESEA INGRESAR NUEVOS VALORES ? : (s/n) ");
                s = Console.ReadLine(); // El programa pregunta si se desea volver a ejecutar
            }
            while (s == "s" || s == "S");
            Console.Clear();
        }
    }
}