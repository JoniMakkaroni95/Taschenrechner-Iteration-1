using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erste Zahl: ");
            int ersteZahl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zweite Zahl: ");
            int zweiteZahl = Convert.ToInt32(Console.ReadLine());
            int summe = ersteZahl + zweiteZahl;
            Console.WriteLine($"Summe der beiden Zahlen: {summe}");
            Console.ReadLine();
        }
    }
}
