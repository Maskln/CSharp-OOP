namespace Bank
{
    public class CompanyCustomer : Customer
    {
        public CompanyCustomer(string name)
            : base(name)
            {
                
            }

        public override string ToString()
        {
            return string.Format("Company customer's {0}", base.ToString());
        }
    }
}
