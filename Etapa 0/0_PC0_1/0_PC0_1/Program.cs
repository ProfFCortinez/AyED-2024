using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC0_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TP 1 - Etapa 0
            Utilizando variable tipo string definir un programa que almacene 
            en una variable una cadena que sea "Hola Mundo!" e imprimirla
            */

            //tipoDato nombreDeVariable;
            //nombreDeVariable = Dato;

            //tipoDato nombreVariable = dato;

            //Caso 1
            string variable1; //Declaramos la variable1
            variable1 = "Hola Mundo!"; //Instanciamos variable1
            Console.WriteLine(variable1); //Imprimimos variable1
            Console.ReadKey();

            //Caso 2
            string variable2 = "Hola Mundo!"; //Manera mas optimizada
            Console.WriteLine(variable2);
            Console.ReadKey();
        }
    }
}
