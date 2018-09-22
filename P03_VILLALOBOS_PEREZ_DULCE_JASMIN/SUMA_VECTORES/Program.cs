using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUMA_VECTORES
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int[] MEMORIA = new int[15]; // VECTOR DETERMINADO CON 15 ELEMENTOS

            Console.Write("________SUMA DE VECTORES _______\n");
            for (int CONTADOR = 0; CONTADOR < 15; CONTADOR++) // CICLO FOR PARA CAPTUAR DATOS 
            {
                Console.Write("INGRESA DATOS {0} : ", CONTADOR + 1);
                MEMORIA[CONTADOR] = int.Parse(Console.ReadLine());
            }

            for (int CONTAR = 0; CONTAR < 4; CONTAR++) // CICLO FOR PARA SUMAR LOS PRIMEROS 4 NUMEROS
            {
                suma = suma + MEMORIA[CONTAR];
            }
            Console.WriteLine("LA SUMA DE LOS 4 NUMEROS ES : {0} ", suma);
            Console.WriteLine("");
            suma = 0;

            for (int CONTAR = 0; CONTAR < 9; CONTAR++) // CICLO FOR PARA SUMAR LOS PRIMEROS 4 NUMEROS
            {
                suma = suma + MEMORIA[CONTAR];
            }
            Console.WriteLine("LA SUMA DE LOS 9 NUMERO INGRESADOS ES : {0} ", suma); // RESULTADO

            Console.ReadKey();
        }
    }
}