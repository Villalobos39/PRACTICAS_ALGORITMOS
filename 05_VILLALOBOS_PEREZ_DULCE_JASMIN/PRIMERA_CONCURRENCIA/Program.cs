﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMERA_CONCURRENCIA
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
                    Console.Write("\n\t\b>> PRIMER ELEMENTO MAYOR <<\n");
                    Console.Write("INGRESE NUMERO DE ELEMENTOS :"); numero = int.Parse(Console.ReadLine());
                    double[] sucesion = new double[numero]; //VECTOR SUCESION QUE ALMACENA LOS DATOS INGRESADOS POR EL USUARIO
                    for (int contar = 0; contar < numero; contar++)
                    {
                        Console.Write("\n\tINGRESE {0} ELEMENTO : ", contar + 1);
                        sucesion[contar] = double.Parse(Console.ReadLine()); // ALMACENA TODOS LA SUCESION 
                    }
                    Console.Write("\n\t EL ELEMENTO MAYOR : {0}\n", (sucesion.ToList().IndexOf(sucesion.Max()) + 1));
                    Console.ReadKey(); //CON AYUDA DE LOS METODOS DE EXTENCION PUEDO DETERMINAR LA CONCUEERENCIA EL ELEMENTO MAYOR 
                }
                catch (FormatException) // CACHO CUANQUIER ERROR DE FORMATO AL MOMENTO DE INGRESAR DATOS 
                {
                    Console.Write("\n\t\b\aERROR DE FORMATO\n");
                }
                Console.Write("\n\t\tREINIZAR (SI || NO) : "); si = Console.ReadLine();
            } while (si == "si" || si == "SI"); Console.ReadKey();
        }
    }
}
