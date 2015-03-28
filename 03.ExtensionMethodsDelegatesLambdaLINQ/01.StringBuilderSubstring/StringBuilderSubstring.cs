/*Problem 1. StringBuilder.Substring

Implement an extension method Substring(int index, int length)
for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
 */



namespace _01.StringBuilderSubstring
{
    using System;
    using System.Linq;
    using System.Text;

    public class StringBuilderSubstring
    {
        static void Main()
        {
            StringBuilder someText = new StringBuilder();

            someText.Append("The horse went into the river!");
            Console.WriteLine(someText);

            someText = someText.Substring(4, 10);
            Console.WriteLine(someText);                            //horse went
        }
    }
}
