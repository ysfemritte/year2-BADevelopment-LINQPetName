using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace PetNameLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            /* (Sorting Pets Names by Length) Write a console app that inputs pets’ names into a
            List<string>. Perform the following queries on the List and display your results:
            a) Use LINQ to sort the List in ascending order on the basis of number of characters in
            the name.
            b) Use LINQ to sort the List in descending order on the same basis.
            c) Display the List count after removing duplicate names from the list. */

            Console.WriteLine("Enter the number of Elements: ");
            int numElements = Convert.ToInt32(Console.ReadLine()); 

            //Initialize a list of strings
            List<string> sampleList = new List<string>();

            for (int i=0; i < numElements; i++)
            {
                Console.Write($"\nEnter Element {i + 1}: ");
                string animalsName = Console.ReadLine();
                sampleList.Add(animalsName); //add the letter to the list
            }

            Console.WriteLine($"\nYou entered the Element as: ");
            foreach (string s1 in sampleList)
            {
                Console.WriteLine(s1);
            }


            //a) Use LINQ to sort the List in ascending order on the basis of number of characters in the name.
            var characterNames =
                from List in sampleList
                orderby List
                select List;

            //display Character Names
            Console.WriteLine("\n\nAnimals Name in Ascending Order");
            foreach (var List in characterNames)
            {
                Console.WriteLine(List);
            }


            //b) Use LINQ to sort the List in descending order on the same basis.
            var characterNamesDesc =
               from List in sampleList
               orderby List descending
               select List;

            //display Character Names
            Console.WriteLine("\n\nAnimals Name in Descending Order");
            foreach (var List in characterNamesDesc)
            {
                Console.WriteLine(List);
            }

            Console.WriteLine("");
            Console.WriteLine("");


            //c) Display the List count after removing duplicate names from the list.
            var distinctSampleList =
                (from List in sampleList
                orderby List
                select List).Distinct();
            //display Characters Name
            Console.WriteLine("\n\nList with no duplicates: ");
            foreach (var List in distinctSampleList)
            {
                Console.WriteLine(List);
            }

            Console.ReadLine();
        }
    }
}
