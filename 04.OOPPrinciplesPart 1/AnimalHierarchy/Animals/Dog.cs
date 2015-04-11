namespace AnimalHierarchy
{   
    using System;

    public class Dog : Animal, ISound 
    {
        public Dog(string name, uint age, Gender sex)
            : base(name, age, sex)
            {
                
            }
        
        public void MakeNoise()
        {
            Console.WriteLine("Bark-Bark");
        }

        public override string ToString()
        {
            return string.Format("{0}", base.ToString());
        }
    }
}
