namespace Bank
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer,balance, interestRate)
            {
                
            }

        public override decimal CalculateInterestAmont(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                months -= 3;
            }
            else
            {
                months -= 2;
            }

            return months * this.InterestRate;
        }

        public override string ToString()
        {
            return string.Format("Loan's Account owner: {0} Balance: {1:C}", this.Customer.Name, this.Balance);
        }
    }
}
