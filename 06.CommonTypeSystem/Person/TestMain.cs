namespace Person
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
            var pers = new Person("Kiro");
            Console.WriteLine(pers);  

            var pers2 = new Person("Pesho", 12);
            Console.WriteLine(pers2);
        }
    }
}
