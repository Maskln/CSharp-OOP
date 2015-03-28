
namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtension
    {
        
        public static decimal Sum<T>(this IEnumerable<T> input)
        {
            decimal result = 0;

            try
            {
                foreach  (T item in input)
                {
                    result += Convert.ToDecimal(item);
                }
            }
            catch (ArgumentNullException ax)
            {

                Console.WriteLine(ax.Message);
            }
            catch (FormatException fx)
            {

                Console.WriteLine(fx.Message);
            }
            catch (InvalidCastException icx)
            {

                Console.WriteLine(icx.Message);
            }

            return result;
        }

        public static decimal Product<T>(this IEnumerable<T> input)
        {
            decimal result = 1;

            try
            {
                foreach (T item in input)
                {
                    result *= Convert.ToDecimal(item);
                }
            }
            catch (ArgumentNullException ax)
            {

                Console.WriteLine(ax.Message);
            }
            catch (FormatException fx)
            {

                Console.WriteLine(fx.Message);
            }
            catch (InvalidCastException icx)
            {

                Console.WriteLine(icx.Message);
            }

            return result;
        }
               public static T Min<T>(this IEnumerable<T> input) where T : IComparable
        {
            T min = input.First();

            foreach (T item in input.Skip(1))
            {
                if (min.CompareTo(item) == 1)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> input) where T : IComparable
        {
            T max = input.First();

            foreach (T item in input.Skip(1))
            {
                if (max.CompareTo(item) == -1)
                {
                    max = item;
                }
            }

            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> input)
        {
            decimal sum = input.Sum();
            decimal average = sum / input.Count();

            return average;
        }
    }

    
}
