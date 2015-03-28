namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IEnumerableMain
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 2, 6, 7, 5, 3 };                             //Integer test
            //List<decimal> numbers = new List<decimal>() { 2.5m, 6.3m, 7.6m, 5.0m, 3.9m };    //Decimal test
            //List<string> numbers = new List<string>() { "2", "6", "7", "5", "3" };           //String Test

            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Product = {0}", numbers.Product());
            Console.WriteLine("Min = {0}", numbers.Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("Average = {0}", numbers.Average());

        }
    }
}
