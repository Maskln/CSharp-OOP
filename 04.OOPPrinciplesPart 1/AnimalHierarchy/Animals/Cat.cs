namespace AnimalHierarchy
{     
    using System;

    public class Cat : Animal, ISound
    {
         public Cat(string name, uint age, Gender sex)
            : base(name, age, sex)
            {
                
            }
        
        public void MakeNoise()
        {
            Console.WriteLine("Miaw- Miaw");
        }

        public override string ToString()
        {
            return string.Format("{0}", base.ToString());
        }
    }
}
