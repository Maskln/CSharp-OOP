namespace StudentsAndWorkers
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        
        
        public string FirstName
        { 
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        public override string ToString()
        {
            return string.Format("First name: {0}, Last name: {1}", this.firstName, this.lastName);
        }




    }

   
}
