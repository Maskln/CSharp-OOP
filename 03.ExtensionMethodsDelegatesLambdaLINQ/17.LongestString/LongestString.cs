 /* Problem 17. Longest string

Write a program to return the string with maximum length from an array of strings.
Use LINQ.
 */

namespace _17.LongestString
{
    using System;
    using System.Linq;
   

    class LongestString
    {
        static void Main()
        {
           string[] arrString =  { "sadasdasdsa", "I am The Longest string!", "dasdsad", "sad" };

            string longestString = TheLongestString(arrString);

            Console.WriteLine("The longest string is: " + longestString);
        }

        public static string TheLongestString(string[] input)
        {
            string result =
                            (from str in input
                            orderby str.Length descending
                            select str).FirstOrDefault();
            return result;
            
        }
    }
}
