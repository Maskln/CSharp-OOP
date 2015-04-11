namespace Person
{
    using System;

    class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
            : this(name)
        {
            this.Age = age;
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
                    throw new ArgumentNullException("No name!");
                }

                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                this.age = value;
            }

        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", this.Name, this.Age == null ? "Unknown" : this.Age.ToString());
        }
    }
}
