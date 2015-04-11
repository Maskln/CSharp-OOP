namespace Bank
{   
    using System;

    public abstract class Account : IDepositable
    {
        private Customer customer;
        private decimal blalance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interest;
        }

        public Customer Customer
        {
            get
            {                   
                return this.customer;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.blalance;
            }
            protected set
            {
                this.blalance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            protected set
            {
                this.interestRate = value;
            }
        }

        public abstract decimal CalculateInterestAmont(int months);

         public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
            throw new ArgumentException("The amount must be bigger than 0!");
            }
	
            this.Balance += amount;
        }
                
    }
}
