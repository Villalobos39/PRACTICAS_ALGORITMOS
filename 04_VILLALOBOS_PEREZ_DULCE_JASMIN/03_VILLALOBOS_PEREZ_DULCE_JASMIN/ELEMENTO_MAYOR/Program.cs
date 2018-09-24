using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELEMENTO_MAYOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string si; int numero = 0; //ATRIBUTOS 
            do
            {
                try
                {
                    Console.Write("\n\t\b>> ULTIMO ELEMENTO MAYOR <<\n");
                    Console.Write("INGRESE NUMERO DE ELEMENTOS :"); numero = int.Parse(Console.ReadLine());
                    double[] sucesion = new double[numero]; // ALMACENO LOS DATOS 
                    for (int contar = 0; contar < numero; contar++)
                    {
                        Console.Write("\n\tINGRESE {0} ELEMENTO : ", contar + 1); 
                        sucesion[contar] = double.Parse(Console.ReadLine()); 
                    } 
                    Console.Write("\n\t EL ELEMENTO MAYOR : {0}\n", (sucesion.ToList().LastIndexOf(sucesion.Max()) + 1));
                    Console.ReadKey(); //USE LOS METODOS DE EXTENSION PARA DEPLEGAR EL ELEMENTO MAYOR 
                } 
                catch (FormatException) // CACHA LOS POSIBLES ERRORES DE FORMATOS
                {
                    Console.Write("\n\t\b\aERROR DE FORMATO\n");
                }
                Console.Write("\n\t\tREINIZAR (SI || NO) : "); si = Console.ReadLine();
            } while (si == "si" || si == "SI"); Console.ReadKey();
        }
    }
}