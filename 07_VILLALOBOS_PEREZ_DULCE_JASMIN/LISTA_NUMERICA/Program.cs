using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_NUMERICA
{
    class Program
    {
        static void Main(string[] args)
        { 
            Random desorden = new Random(); // USE UNA VARIABLE LOCAL
            List<int> numeros = new List<int>(); string si;
            Console.Write("\n\t\bSUCESION NUMERICA\n");
            do { try {                  
                    for (int contar = 1; contar <=100; contar++)  // DESPLIEGO LOS DATOS
                    {                     
                        Console.Write(" {0} ", +contar); // numeros.Add(contar);  
                        numeros.Add(desorden.Next(1, 100));//SE DEPLEGAN DE MANERA ORDENADA 
                    }                    
                    Console.Write("\n"); numeros.Reverse(); // LOS IMPRIMO DE MANERA DESORDENADA 
                    foreach (int suscecion in numeros) 
                    {
                        Console.Write("{0}", suscecion); Console.Write("||");                       
                    }   }
                catch (Exception) { Console.Write("\n\t\aERROR"); } //SE CACHAN LOS ERRORES POSIBLES 
                Console.Write("\n\n\tNUMEROS : {0}", numeros.LongCount());              
                Console.Write("\n\t\tREINIZAR (SI || NO) : "); si = Console.ReadLine();
                numeros.Clear();
            }  while (si == "si" || si == "SI");  Console.ReadKey();
        }
    }
}
