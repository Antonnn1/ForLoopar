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

            /*
            //Ovn 2.3
            Console.Write("Mata in ett heltal: ");
            int heltal = int.Parse(Console.ReadLine());
            int summa = 0;
            for (int i = 0; i<=heltal; i++)
            {summa = summa + i;}
            Console.WriteLine(summa);
            */

            /*
            //Ovn 2.4
            Console.Write("Mata in ett heltal: ");
            int heltal1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= heltal1; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                { Console.WriteLine("Talet " + i + " är jämt delbart med både 3 och 7"); }
            }
            if (heltal1 % 3 != 0 || heltal1 % 7 != 0)
            {
                Console.WriteLine("Inga tal hittades...");
            }
            */

            /*
            //Övn 2.5
            Console.WriteLine("Mata in ett heltal: ");
            int inmatat = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 1;
            int n;
            if (inmatat == 0)
            {
                Console.WriteLine("Fibonaccitalen blir: 0");
            }
            else
            {
               Console.WriteLine("Fibonaccitalen blir: 1");
               for (int i = 0; i < (inmatat-1); i++)
               {
                  n = x + y;
                  x = y;
                  y = n;
                  Console.WriteLine(n + "  ");
               }

             }
             */
            //Övn 2.6
            Console.WriteLine("Ange ett tal: ");
            int inmatat = int.Parse(Console.ReadLine());
            for (double i = 0; i < inmatat; i+= 0.1)
            {
                if ((inmatat - i * i * i) < 0.1)
                {
                    Console.WriteLine("Kubikroten av " + inmatat + " är " + i);
                    break;
                }
            }



        }
    }
}
