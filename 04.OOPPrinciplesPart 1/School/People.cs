namespace School
{
    public abstract class People
    {

        public People(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }   
    }
}
