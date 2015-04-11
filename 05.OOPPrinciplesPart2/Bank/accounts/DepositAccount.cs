using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount (Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
            {
                
            }

        public override decimal CalculateInterestAmont(int months)
        {
            if (this.Balance < 1000)
            {
                return 0.0m;
            }
            else
            {
               return months * this.InterestRate;
            }
           
        }

       
        
        public override string ToString()
        {
            return string.Format("Deposit's Account owner: {0} Balance: {1:C}", this.Customer.Name, this.Balance);
        }

        
        public void Withdraw(decimal amount)
        {
            if (this.Balance <= amount)
            {
                throw new ArgumentException("The withdraw amount is bigger than the balance1");
            }
                this.Balance -= amount;
            
        }

        
    }
}
