using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALIFICACIONES
{
    class INFORMACION
    {
            int CONTADOR = 0; int CL; int CAL = 0; int AL = 0; // ASIGNACION DE TIPO DE DATOS

            public INFORMACION() { }                   // CONSTRUCTOR

            public INFORMACION(int CONTADOR, int CL, int CAL, int AL)
            { this.CONTADOR = CONTADOR; this.CL = CL; this.CAL = CAL; this.AL = AL; }

            public int[] ALU; public int[] CALF; public String[] CLASES; // VECTORES 

            public void CAPTURAR()      // METODO 
            {
                Console.Write("CLASES : ");
                CL = int.Parse(Console.ReadLine());

                CLASES = new string[CL];    // Determinar un vector con el numero de clases asignadas por el usuario,
                ALU = new int[CL];

                for (int CONT = 0; CONT < CLASES.Length; CONT++)  // CICLO FOR PARA CAPTURAR LOS DATOS 
                {
                    Console.Write("  CLASE :  ");
                    CLASES[CONT] = Console.ReadLine();

                    Console.Write("   ALUMNOS DE CLASES : ");    // Asignar números específicos de alumnos por clase.
                    ALU[CONT] = int.Parse(Console.ReadLine());

                    CALF = new int[100];

                    for (int CONTA = 1; CONTA <= ALU[CONT]; CONTA++)   //A cada alumno que pertenezca a una clase asignarle calificación
                    {
                        Console.Write("  {0} ALUMNO CAL  : ", CONTA);
                        CALF[CONTA] = int.Parse(Console.ReadLine());
                        CAL = CALF[CONTA];
                    }
                    AL = ALU[CONT];
                }

            }
            public void IMPRIMIR()  // METODO IMPRIME LOS DATOS GENERALES 
            {
                foreach (string n in CLASES)
                {
                    Console.Write("\n LA CLASE " + n + " TIENE {0}  ALUMNOS  ", ALU[CONTADOR]);
                    CONTADOR++;
                }
                Console.ReadKey();
            }
        }
    }