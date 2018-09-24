using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PALINDROMO
{
    class Program
    {
        static void Main(string[] args)
        {  string si; int numeroPalindromo = 0;
            do
            {
                Console.Write("\n\tPALINDROMO\n"); //INICIA 
                try
                {
                    Console.Write("\n\tINGRESE 5 DIGITOS : "); //PIDO AL USUSARIO QUE INGRESE LOS DIGITOS 
                    numeroPalindromo = int.Parse(Console.ReadLine());
                    if (numeroPalindromo >= 10000 && numeroPalindromo <= 99999) //PONGO UNA CONDICION 
                    { //INVIERTO LOS DIGITOS PARA DETERMINA SI CUMPLEN CON LO DE SER UN PALINDROMO
                        char[] invertir = numeroPalindromo.ToString().ToCharArray();
                        int palindromoReves =int.Parse(Convert.ToString(invertir[4]) +
                            Convert.ToString(invertir[3]) + Convert.ToString(invertir[2]) +
                            Convert.ToString(invertir[1]) + Convert.ToString(invertir[0]));
                        if (palindromoReves == numeroPalindromo) // SI EL NUMERO ES IGUAL AL DERECHO Y AL REVES SE CUMPLE
                            Console.Write("\n\t{0} IGUAL {1} PALINDROMO\n", numeroPalindromo, palindromoReves);
                        else // DE LO CONTRARIO NO LO ES Y SE DESPLEGA EL SINO 
                            Console.Write("\n\t{0} NO ES IGUAL {1} NO PALINDROMO\n", numeroPalindromo, palindromoReves);
                    }
                    else Console.Write("\t\aERRRO\n"); //CUANDO EL USUARIO INGRESA UN VALOR MAYOR A 5 DIGITOS APARECE ERROR 
                } //CACHO LOS POSIBLES ERRORES QUE SE PODRIAN PRESENTAR POR FOMARTO O RANGO 
                catch (FormatException) { Console.Write("\n\t\aLA CADENA DE DATOS NO TIENE EL FORMATO ASIGNADO\n"); }
                catch(OverflowException) { Console.Write("\n\t\aLA CADENA DE DATOS ESTA FUERA DEL RANGO ASIGNADO\n"); }
                finally { Console.Write("\n\t\tREINICIAR (SI || NO) : "); si = Console.ReadLine(); } // FINALIZO CON UN REINICIAR 
            }
            while (si == "si" || si == "SI"); Console.ReadKey();
        }
    }
}
