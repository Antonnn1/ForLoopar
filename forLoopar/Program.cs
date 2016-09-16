using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Ovn 1
            for (int i = 0; i <= 100; i++) { Console.WriteLine(i); }
            */

            /*
            //Ovn 2
            for (int i = 20; i >= 1; i--){ Console.WriteLine(i); }
            */

            /*
            //Ovn 3
            for(int i = 0; i<=50; i=i + 2) { Console.WriteLine(i); }
            */
            /*
            //Ovn 2.1
            Console.WriteLine("Mata in start: ");
            string inmatat;
            inmatat = Console.ReadLine();
            int start = int.Parse(inmatat);
            Console.WriteLine("Mata in stop: ");
            int stop = int.Parse(Console.ReadLine());
            Console.WriteLine("Mata in steg: ");
            int steg = int.Parse(Console.ReadLine());

            for (int i = start; i<=stop; i= i + steg) { Console.WriteLine(i); }
            */

            //Ovn 2.3
            Console.Write("Mata in ett heltal: ");
            int heltal = int.Parse(Console.ReadLine());
            int summa = 0;
            for (int i = 0; i<=heltal; i++)
            {summa = summa + i;}
            Console.WriteLine(summa);


      }
    }
}
