using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Aufgaben
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Aufgabe 9
            //Frage den Nutzer wie viele Einträge er ausgeben möchte, sortiere die Liste den Werten nach absteigend
            //und gebe anschließend die n Einträge aus die der Nutzer sehen möchte. (Verwende die .Take() - Methode)
            List<int> templist = new List<int>();

            Console.Write("\nLINQ : How many entries in the list do you want: ");
            Console.Write("\n------------------------------------------------\n");
            int numOfEntries = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numOfEntries; i++)
            {
                Console.Write($"\nEnter entry {i + 1} to the list: ");
                templist.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.Clear();
            Console.Write("\nLINQ : Display top nth  records from the list : ");
            Console.Write("\n----------------------------------------------\n");
            Console.WriteLine("\nThe members of the list are : ");
            foreach (var element in templist)
            {
                Console.WriteLine(element + " ");
            }

            Console.Write("How many records you want to display ? : ");
            int outputEntries = Convert.ToInt32(Console.ReadLine());

            templist.Sort();

            Console.Write($"The bottom {outputEntries} records from the list are : \n");

            foreach (int topNumber in templist.Take(outputEntries))
            {
                Console.WriteLine(topNumber);
            }

            templist.Reverse();

            Console.Write($"The top {outputEntries} records from the list are : \n");

            foreach (int topNumber in templist.Take(outputEntries))
            {
                Console.WriteLine(topNumber);
            }


            Console.ReadLine();



            //Aufgabe 8
            //Lasse den Nutzer eine Zahl eingeben, wie viele Einträge er hinzufügen möchte.
            //Frage anschließend nach den jeweiligen Werten, bis die Anzahl der Listelemente erreicht ist. 
            //Frage Anschließend nach einer Zahl und gebe nur die Elemente der Liste aus, welche größer als die Eingabe ist.


            /*
            List<int> templist = new List<int>();
            Console.Write("\nLINQ : Accept the members of a list and display the members more than a specific value : ");
            Console.Write("\n----------------------------------------------------------------------------------------\n");

            Console.Write("Input the number of members on the List : ");
            int numMembersOfTheList = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numMembersOfTheList; i++)
            {
                Console.Write($"Member {i + 1} : ");
                int memlist = Convert.ToInt32(Console.ReadLine());
                templist.Add(memlist);
            }

            Console.Write("\nInput the value above you want to display the members of the List : ");
            int aboveThisValue = Convert.ToInt32(Console.ReadLine());

            List<int> FilterList = templist.FindAll(x => x > aboveThisValue);
            Console.WriteLine("\nThe numbers greater than {0} are : ", aboveThisValue);

            foreach (var num in FilterList)
            {
                Console.WriteLine(num);
            }


            Console.ReadLine();
            */


            //Aufgabe 7
            //Gebe die Städte aus, welche mit einem bestimmten Buchstaben beginnen, sowie mit einem weiteren Buchstaben Enden. Gestalte es variabel.

            /*
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

            */



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
