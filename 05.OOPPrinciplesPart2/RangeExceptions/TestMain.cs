namespace RangeExceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

     public class TestMain
    {
        static void Main()
        {
            try
            {
                throw new InvalidRangeException<int>("Invalid input!", 1, 100);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            try
            {
                throw new InvalidRangeException<DateTime>("Invalid date!", new DateTime(1981, 1, 1), new DateTime(2013, 12, 31));
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
