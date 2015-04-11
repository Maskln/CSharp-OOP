namespace Bank
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
            {
                
            }

        public override decimal CalculateInterestAmont(int months)
        {
            if (this.Customer is CompanyCustomer && months >= 12)
            {
                this.InterestRate /= 2;
            }
            else if (this.Customer is IndividualCustomer && months >= 6)
            {
                months -= 6;
            }

            return months * this.InterestRate;
        }

        public override string ToString()
        {
            return string.Format("Deposit's Account owner: {0} Balance: {1:C}", this.Customer.Name, this.Balance);
        }
    }
}
