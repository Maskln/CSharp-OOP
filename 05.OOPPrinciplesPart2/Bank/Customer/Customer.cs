namespace Bank
{
    using System;

    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }   
        }

        public override string ToString()
        {
            return string.Format("Name: {0},", this.Name);
        }
    }
}
