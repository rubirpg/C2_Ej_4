using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2_Ej_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca el valor para N: ");
            int numn = Convert.ToInt32(Console.ReadLine()); //leemos y asignamos a numn el valor de N

            Console.WriteLine();
            Console.WriteLine("El valor de N es: " + numn); //Mostramos por pantalla el valor de N.

            numn += 77; //Incrementamos en 77 el valor de N.
            Console.WriteLine("El valor de N + 77 es: " + numn); //Mostramos por pantalla el nuevo valor de N.

            numn -= 3; //Restamos 3 al valor de N.
            Console.WriteLine("El valor de N - 3 es: " + numn); //Mostramos por pantalla el nuevo valor de N.

            numn *= 2; //Multiplicamos por 2 el valor de N.
            Console.WriteLine("El doble de N es: " + numn); //Mostramos por pantalla el nuevo valor de N.
        }
    }
}