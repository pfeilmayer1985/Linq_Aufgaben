using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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

            //Aufgabe 17
            //Erstelle das Kartesische Produkt dieser beiden Listen.
            //X1,X2,X3,Y1,Y2,Y3,Z1,Z2,Z3

            /*
            var setOfStringsArray = new string[] { "X", "Y", "Z" };
            var setOfIntsArray = new int[] { 1, 2, 3 };

            Console.Write("\nLINQ : Generate a cartesian product of two sets : ");
            Console.Write("\n------------------------------------------------\n");

            var cartesianProduct = from letter in setOfStringsArray
                                   from number in setOfIntsArray
                                   select new { letter, number };

            Console.Write("The cartesian product are : \n");
            foreach (var productItem in cartesianProduct)
            {
                Console.WriteLine(productItem);
                //Console.WriteLine(productItem.letter + " " + productItem.number);
            }
            Console.ReadLine();
            */

            //Aufgabe 16
            //Verkette die zwei Arrays indem das erste Element der ersten Liste mit dem ersten
            //Element der zweiten Liste (2. Element der 1. Liste mit 2. Element der 2. Liste ….)
            //als String gespeichert wird. 

            var setOfStringsArray = new string[] { "X", "Y", "Z" };
            var setOfIntsArray = new int[] { 1, 2, 3 };

            Console.Write("\nLINQ : Bind the elements of two sets : ");
            Console.Write("\n--------------------------------------\n");


            Console.Write("The product is : \n");

            var neueArray = new string[setOfStringsArray.Length];


            var combine = setOfStringsArray.Zip(setOfIntsArray, (a, c) => new { setOfStringsArray = a, setOfIntsArray = c });

            foreach (var a in combine)
            {
                Console.WriteLine(a.setOfStringsArray + a.setOfIntsArray);
            }

            //for (int i = 0; i < setOfStringsArray.Length; i++)
            //{
            //    neueArray[i] = setOfIntsArray[i] + setOfStringsArray[i];

            //}

            //foreach (var result in neueArray)
            //{
            //    Console.WriteLine(result);
            //}







            Console.ReadLine();


            //Aufgabe 15
            //Lösche nun das Element „P“ der obigen Listen indem du es direkt in der Methode Remove suchst und übergibst.


            /*
            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");


            Console.Write("\nLINQ : Remove items from list by creating object internally by filtering  : ");
            Console.Write("\n--------------------------------------------------------------------------\n");

            var _result1 = from y in listOfString
                           select y;
            Console.Write("Here is the list of items : \n");
            foreach (var tchar in _result1)
            {
                Console.WriteLine($"Char: {tchar} ");
            }

            listOfString.Remove(listOfString.FirstOrDefault(en => en == "p"));


            var _result = from z in listOfString
                          select z;
            Console.Write("\nHere is the list after removing the item 'p' from the list : \n");
            foreach (var rChar in _result)
            {
                Console.WriteLine($"Char: {rChar} ");
            }

            Console.ReadLine();
            */

            //Aufgabe 14
            //Entferne ein Element mittels der Remove Methode indem du davor über FirstOrDefault das Element „o“ erst findest.


            /*
            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");


            Console.Write("\nLINQ : Remove items from list using remove function : ");
            Console.Write("\n----------------------------------------------------\n");

            var _result1 = from y in listOfString
                           select y;
            Console.Write("Here is the list of items : \n");
            foreach (var tchar in _result1)
            {
                Console.WriteLine($"Char: {tchar} ");
            }

            string newstr = listOfString.FirstOrDefault(en => en == "o");
            listOfString.Remove(newstr);


            var _result = from z in listOfString
                          select z;
            Console.Write("\nHere is the list after removing the item 'o' from the list : \n");
            foreach (var rChar in _result)
            {
                Console.WriteLine($"Char: {rChar} ");
            }

            Console.ReadLine();
            */


            //Aufgabe 13
            //Zähle die Anzahl der jeweiligen File-Extensions im gegebenen Array.
            //string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };
            //Und gebe es dann aus mit
            //Console.WriteLine($"{count} File(s) with {extension} Extension")

            /*
            string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

            Console.Write("\nLINQ : Count file extensions and group it : ");
            Console.Write("\n------------------------------------------\n");

            Console.Write("\nThe files are : aaa.frx, bbb.TXT, xyz.dbf,abc.pdf");
            Console.Write("\n                aaaa.PDF,xyz.frt, abc.xml, ccc.txt, zzz.txt\n");

            Console.Write("\nHere is the group of extension of the files : \n\n");

            var fGrp = arr1.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                     .GroupBy(z => z, (fExt, extCtr) => new
                     {
                         Extension = fExt,
                         Count = extCtr.Count()
                     });

            foreach (var m in fGrp)
                Console.WriteLine($"{m.Count} File(s) with {m.Extension} Extension ");
            Console.ReadLine();
            */



            //Aufgabe 12
            //Erstelle eine Klasse Studenten public class Students  
            //Fülle die Liste der Studenten mit Folgenden Werten
            //Frage den Nutzer nach einer Zahl zwischen 1 und 6, und gebe dann
            //die jeweiligen Studenten aus, welche 1 (am meisten Punkte) 6 (am wenigsten Punkte) hat. 

            /*
            Console.Write("\nLINQ : Find the nth Maximum Grade Point achieved by the students from the list of student : ");
            Console.Write("\n------------------------------------------------------------------------------------------\n");
            Console.Write("Which maximum grade point(1st, 2nd, ..., 6th) you want to find  : ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            Students e = new Students();

            var stulist = e.GtStuRec();
            var students = (from stuMast in stulist
                            group stuMast by stuMast.GrPoint into g
                            orderby g.Key descending
                            select new
                            {
                                StuRecord = g.ToList()
                            }).ToList();

            students[userChoice - 1].StuRecord
                .ForEach(i => Console.WriteLine($" Id : {i.StuId},  Name : {i.StuName},  achieved Grade Point : {i.GrPoint}"));

            Console.ReadLine();
            */


            //Aufgabe 11
            //Speichere die Werte des angegeben String[] in einem gesamten String mit einem Komma separiert. Gebe diesen String anschließend aus.
            //string[] arr1 = new string[4] { "cat", "dog", "cow", "tiger" };


            /*
            string[] arr1 = new string[4] { "cat", "dog", "cow", "tiger" };

            string arrayToString = String.Join(", ", arr1.Select(s => s.ToString()));

            Console.Write("\nHere is the string below created with elements of the above array  :\n\n");
            Console.WriteLine(arrayToString);
            Console.Write("\n");


            Console.ReadLine();
            */

            //Aufgabe 10
            //Lasse den Nutzer einen Satz eingeben, in welchen er bestimmte Wörter in UPPER CASE schreibt. 
            //Gebe anschließend nur die Wörter aus welche komplett mit UPPERCASE geschrieben wurden.-

            /*
            Console.Write("\nLINQ : Find the uppercase words in a string : ");
            Console.Write("\n----------------------------------------------\n");
            Console.WriteLine("Input a sentence. A few words must be written in UPPERCASE : ");
            string strNew = Console.ReadLine();

            var upWord = strNew.Split(' ')
                       .Where(x => String.Equals(x, x.ToUpper(),
                       StringComparison.Ordinal));

            Console.Write("\nThe UPPER CASE words are :\n ");
            foreach (string strRet in upWord)
            {
                Console.WriteLine(strRet);
            }

            Console.ReadLine();
            */

            //Aufgabe 9
            //Frage den Nutzer wie viele Einträge er ausgeben möchte, sortiere die Liste den Werten nach absteigend
            //und gebe anschließend die n Einträge aus die der Nutzer sehen möchte. (Verwende die .Take() - Methode)


            /*
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

            Console.ReadLine();
            Console.Clear();


            Console.Write("How many records you want to display ? : ");
            int outputEntries = Convert.ToInt32(Console.ReadLine());

            templist.Sort();

            Console.Write($"The bottom {outputEntries} records from the list are : \n");

            foreach (int topNumber in templist.Take(outputEntries))
            {
                Console.WriteLine(topNumber);
            }

            Console.WriteLine();

            templist.Reverse();

            Console.Write($"The top {outputEntries} records from the list are : \n");

            foreach (int topNumber in templist.Take(outputEntries))
            {
                Console.WriteLine(topNumber);
            }


            Console.ReadLine();
            */


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
