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
            //Aufgabe 5

            Console.Write("\nLINQ : Display the characters and frequency of character from giving string : ");
            Console.Write("\n----------------------------------------------------------------------------\n");
            Console.Write("Input the string : ");
            string str = Console.ReadLine();
            Console.Write("\n");

            var FreQ = from x in str
                       group x by x into y
                       select y;
            Console.Write("The frequency of the characters are :\n");
            foreach (var ArrEle in FreQ)
            {
                Console.WriteLine("Character " + ArrEle.Key + ": " + ArrEle.Count() + " times");
            }
            Console.ReadLine();

            //Aufgabe 4
            /*
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var n = from x in arr1
                    group x by x into y
                    select y;

            Console.WriteLine("\nThe number and the Frequency are : \n");
            foreach (var arrNo in n)
            {
                Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            }

            Console.ReadLine();

            */

            //Aufgabe 3

            /*
            var myArray = new[] { 3, 9, 2, 8, 6, 5 };

            Console.Write("\nLINQ : Find the number and its square of an array which is more than 20 : ");
            Console.Write("\n------------------------------------------------------------------------\n");


            var squareNumber = from int Number in myArray
                               let SqrNo = Number * Number
                               where SqrNo > 20
                               select new { Number, SqrNo };

            foreach (var a in squareNumber)
                Console.WriteLine(a);

            Console.ReadLine();
            */


            //Aufgabe 2

            /*
            List<int> ints = new List<int>();
            for (int i = 1; i < 101; i++)
            {
                ints.Add(i);
            }

            var result = from s in ints
                         where s % 2 != 0
                         select s;

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            //Aufgabe 1

            /*
            List<int> ints = new List<int>();
            for (int i = 1; i < 101; i++)
            {
                ints.Add(i);
            }

            var result = from s in ints
                         where s % 2 == 0
                         select s;

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */


        }
    }
}
