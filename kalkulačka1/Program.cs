using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulačka1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, vysledek;
            string operace;

            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            operace = Console.ReadLine();
            vysledek = 0;
            if (operace == "+")
            {
                vysledek = num1 + num2;
            }
            else if (operace == "-")
            {
                vysledek = num1 - num2;
            }
            else if (operace == "*")
            {
                vysledek = num1 * num2;
            }
            else if (operace == "/")
            {
                vysledek = num1 / num2;
            }

            Console.WriteLine(vysledek);


        }   

    }
}
