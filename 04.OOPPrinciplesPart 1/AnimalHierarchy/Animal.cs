namespace AnimalHierarchy
{
    public abstract class Animal
    {
        
        public Animal(string name, uint age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; private set; }

        public uint Age { get; private set; }

        public Gender Sex { get; private set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Gender: {2}", this.Name, this.Age, this.Sex);
        }
    }
}
