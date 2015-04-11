namespace _64BitArray
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

            BitArray64 arr = new BitArray64(7u);
            BitArray64 arr2 = new BitArray64(8u);

            Console.WriteLine(arr);
            arr[1] = 0;
            Console.WriteLine(arr);
            Console.WriteLine();
            Console.WriteLine("Equals?");
            Console.WriteLine(arr == arr2);
            Console.WriteLine();
            Console.WriteLine("Differnt?");
            Console.WriteLine(arr != arr2);
        }
    }
}
