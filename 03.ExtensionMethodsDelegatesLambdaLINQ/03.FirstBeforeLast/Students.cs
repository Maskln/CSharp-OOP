namespace _03.FirstBeforeLast
{
    using System;
    using System.Linq;
   
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("No First Name!");   
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("No Last Name!");
                }
                
                this.lastName = value;  
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new AggregateException("The age must be bigger than 0");    
                }
                
                this.age = value;
            }
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + " " + this.age;
        }
        
    }
}
