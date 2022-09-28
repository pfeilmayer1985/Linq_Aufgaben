using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Aufgaben
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Aufgabe 2

            List<int> ints1 = new List<int>();
            for (int i = 1; i < 101; i++)
            {
                ints1.Add(i);
            }

            foreach (int i in ints1)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();

            //Aufgabe 1

            List<int> ints = new List<int>();
            for (int i = 1; i < 101; i++)
            {
                ints.Add(i);
            }

            foreach (int i in ints)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();

        }
    }
}
