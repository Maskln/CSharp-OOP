using System;

namespace _01.DefineClass
{
    public class GSMCallHistoryTest
    {

        private GSM phone = new GSM("Note 2", "Samsung");

        public void TestPhone()
        {
            AddCalls();
            DisplayCallInfo();
            Console.WriteLine("Total call price: " + phone.CalculateCallPrice(0.37f));
            RemoveLongestCall();
            Console.WriteLine("Longest call has been removed.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Press any key to print current call history.");
            Console.WriteLine();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;

            DisplayCallInfo();

            phone.ClearCallHistory();
            Console.WriteLine("Call history cleared!");

            DisplayCallInfo();
        }

        private void RemoveLongestCall()
        {
            int longestCallID = 0;
            for (int i = 0; i < phone.CallHistory.Count - 1; i++)
            {
                if (phone.CallHistory[i + 1].DurationCall > phone.CallHistory[i].DurationCall)
                {
                    longestCallID = i;
                }
            }
            phone.DeleteCall(phone.CallHistory[longestCallID]);
        }

        private void AddCalls()
        {
            phone.AddCalls(new Call("25/03/2015", "17:23", "+359886325897", 46));
            phone.AddCalls(new Call("10/01/2013", "10:00", "+359888888888", 12));
            phone.AddCalls(new Call("17/05/2014", "07:59", "+359899999999", 5));
        }
        private void DisplayCallInfo()
        {
            for (int i = 0; i < phone.CallHistory.Count; i++)
            {
                Console.WriteLine("Date: " + phone.CallHistory[i].DateOfCall);
                Console.WriteLine("Time: " + phone.CallHistory[i].TimeOfCall);
                Console.WriteLine("Dialed number: " + phone.CallHistory[i].DialledNumber);
                Console.WriteLine("Duration: {0} minutes.", phone.CallHistory[i].DurationCall);
                Console.WriteLine();
            }
        }
    }
}
