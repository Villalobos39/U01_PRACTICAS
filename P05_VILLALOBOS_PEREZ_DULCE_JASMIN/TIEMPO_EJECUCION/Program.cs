using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TIEMPO_EJECUCION
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = 0; Stopwatch timeEjecucion = Stopwatch.StartNew();
            for (int contar = 1; contar <= 1000000; contar++) // SUMATORIA DEL 1 AL 1 000 000        
                suma = suma + contar;        // IMPRIME RSULTADO              
            Console.Write("\n LA SUMA TOTAL ES : {0}\n TIEMPO DE EJECUCION : {1} ", suma, timeEjecucion.Elapsed);
            Console.ReadKey();
        }
    }
}