using System;
using System.Collections.Generic;

namespace Methods_Exercise_02
{
    internal class Program
    {
        public static void SampleMethod()
        {
            // method logic 
        }

        static void Main(string[] args)
        {
            // TODO: Call each of the methods you created below here


            #region Three examples of calling the above SampleMethod()

            // Example 1:
            // Console.WriteLine(SampleMethod());

            /* 
            Example 2:
            var answer = SampleMethod();
            Console.WriteLine(answer);
            */

            // Example 3:
            // SampleMethod();

            #endregion
            // Hint: The way you choose to call the method will depend upon that methods return type!

            #region EXAMPLES of printing out each field on a single line with spaces in-between
            _list1 = Utility.RandomColorsList(1, 11);
            _arr1 = Utility.RandomColorsArray(1, 11);
            _str1 = Utility.RandomString(50);
            _numbers = Utility.RandomNumberCollection(50);

            //// Example 1:
            //foreach (var item in _list1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Utility.AddSpaces(2);

            ////Example 2:
            //foreach (var item in _arr1)
            //{
            //    Console.Write($"{item} ");
            //}
            //Utility.AddSpaces(2);

            //// Example 3:
            //foreach (var item in _str1)
            //{
            //    Console.Write(item);
            //}
            //Utility.AddSpaces(2);

            //// Example 4:
            //foreach (var item in _numbers)
            //{
            //    Console.Write(item);
            //}
            //Utility.AddSpaces(2);

            #endregion
        }

        // TODO: Create a method that takes the collection below and iterates through it printing out each item to the console
        static List<string> _list1;


        // TODO: Create a method that takes the array below and prints out Found it! if there is the string "blue" inside of it
        static string[] _arr1;


        // TODO: Create a method that removes all of the vowels from the string below
        static string _str1;

        // TODO: Create a method that removes all of the even numbers
        static IEnumerable<int> _numbers;
    }
}
