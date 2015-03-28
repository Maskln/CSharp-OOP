using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DefineClass
{
    class MobilePhoneDevice
    {
        static void Main()
        {
            GSMTest tester = new GSMTest();
            tester.PrintInfo();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press any key to run the call history test.");
            Console.WriteLine();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            GSMCallHistoryTest historyTester = new GSMCallHistoryTest();
            historyTester.TestPhone();

            
        }
    }
}
