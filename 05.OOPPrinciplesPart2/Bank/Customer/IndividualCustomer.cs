namespace Bank
{
    public class IndividualCustomer : Customer
    {
        public IndividualCustomer(string name)
            : base(name)
            {
                
            }

        public override string ToString()
        {
            return string.Format("Individual customer's {0}", base.ToString());
        }
    }
}
