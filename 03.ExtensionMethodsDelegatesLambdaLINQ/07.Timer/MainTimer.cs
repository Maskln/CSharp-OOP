/* Problem 7. Timer

Using delegates write a class Timer that can execute certain method at each t seconds.
*/

namespace _07.Timer
{
    using System;
    using System.Linq;

    public class MainTimer
    {
        private static void PrintMethod()
        {
            Console.WriteLine("|");
        }

        public static void Main()
        {
            Timer timer = new Timer(300, 20);
            timer.TDelegate += PrintMethod;

            Console.WriteLine("Start");
            timer.Execute();
            Console.WriteLine("End");
        }
    }
}
