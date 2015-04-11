namespace Bank
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BankMainTest
    {
        static void Main()
        {
             //Test Deposit Account
            Console.WriteLine("Deposit account");
            Console.WriteLine("---------------");   
            var sad = new DepositAccount(new IndividualCustomer("Pesho"), 1500, 3.5m);
            sad.Deposit(100m);                                                                  //Deposit 100
            Console.WriteLine(sad);
            Console.WriteLine("The interest amount of {0}", sad.CalculateInterestAmont(5));     
            sad.Withdraw(1500m);                                                                // Withdraw 1500
            Console.WriteLine(sad);
            Console.WriteLine("The interest amount of {0}", sad.CalculateInterestAmont(5));     //Test Interset amount under 1000
            Console.WriteLine();

            //Test Loan Account
            Console.WriteLine("Loan account");
            Console.WriteLine("---------------");            
            var asd = new LoanAccount(new CompanyCustomer("NASA"), 265325, 5);             
            asd.Deposit(123);                                                                   //Deposit 123
            Console.WriteLine(asd);
            Console.WriteLine("The interest amount of {0}", asd.CalculateInterestAmont(5));     
            Console.WriteLine();

            var testIndividualAcc = new LoanAccount(new IndividualCustomer("Spiridon"), 1000, 3);
            Console.WriteLine(testIndividualAcc);
            Console.WriteLine("The interest amount of {0}", testIndividualAcc.CalculateInterestAmont(5));
            Console.WriteLine();


            Console.WriteLine("Mortgage account");
            Console.WriteLine("---------------");  
            var das = new MortgageAccount(new CompanyCustomer("Intel"), 1000, 10);
            Console.WriteLine(das);
            Console.WriteLine("The interest amount of {0}", das.CalculateInterestAmont(12));  // test Company customer Interest Rate for 12 months must be 1/2 or 10/2 = 5; 5 * 12 = 60
            Console.WriteLine();

            var dass = new MortgageAccount(new IndividualCustomer("Kiro"), 1000, 10);
            Console.WriteLine(dass);
            Console.WriteLine("The interest amount of {0}", dass.CalculateInterestAmont(6));  //  test Individual customer interest rate for 6 months must be 0;
        
        }
    }
}
