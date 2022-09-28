using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Aufgaben
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 7
            //Gebe die Städte aus, welche mit einem bestimmten Buchstaben beginnen, sowie mit einem weiteren Buchstaben Enden. Gestalte es variabel.

            string chst, chen;

            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            Console.Write("\nLINQ : Find the string which starts and ends with a specific character : ");
            Console.Write("\n-----------------------------------------------------------------------\n");
            Console.Write("\nThe cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");

            Console.Write("\nInput starting character for the string : ");
            chst = Console.ReadLine();
            Console.Write("\nInput ending character for the string : ");
            chen = Console.ReadLine();

            if (chst.Any(char.IsLower))
            {
                chst = chst.ToUpper();
            }

            if (chen.Any(char.IsLower))
            {
                chen = chen.ToUpper();
            }





            var _result = from x in cities
                          where x.StartsWith(chst)
                          where x.EndsWith(chen)
                          select x;
            Console.Write("\n\n");

            foreach (var city in _result)
            {
                Console.Write("The city starting with {0} and ending with {1} is : {2} \n", chst, chen, city);
            }

            Console.ReadLine();

            //Aufgabe 6


            /*
            //Gebe die Zahl, das Auftreten der Zahl im Array, sowie die Multiplikation der Zahl mit der Zahl ihres Auftretens

            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

            var timesBy = from int z in nums
                          group z by z into y
                          select y;

            foreach (var arrEle in timesBy)
            {
                Console.WriteLine(arrEle.Key + "\t" + arrEle.Count() + "\t" + arrEle.Sum());
            }

            Console.ReadLine();
            */



            //Aufgabe 5a

            /*
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.Write("\nLINQ : Display the name of the days of a week : ");
            Console.Write("\n------------------------------------------------\n");


            var days = from WeekDay in dayWeek
                       select WeekDay;
            foreach (var WeekDay in days)
            {
                Console.WriteLine(WeekDay);
            }
            Console.WriteLine();

            Console.ReadLine();
            */

            //Aufgabe 5
            /*
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
            */



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
