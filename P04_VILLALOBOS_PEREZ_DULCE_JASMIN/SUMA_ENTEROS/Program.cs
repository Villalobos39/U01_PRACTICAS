using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMA_ENTEROS
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int[] MEMORIA = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            for (int CONTAR = 0; CONTAR < 4; CONTAR++)
            {
                suma = suma + MEMORIA[CONTAR];
            }
            Console.WriteLine("LA SUMA DE LOS 4 NUMEROS ES : {0} ", suma);
            Console.WriteLine("");
            suma = 0;
            for (int CONTAR = 0; CONTAR < 9; CONTAR++)
            {
                suma = suma + MEMORIA[CONTAR];
            }
            Console.WriteLine("LA SUMA DE LOS 9 NUMERO INGRESADOS ES : {0} ", suma);
            Console.ReadKey();
        }
    }
}