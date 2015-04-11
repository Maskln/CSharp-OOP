namespace AnimalHierarchy
{   
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, uint age, Gender sex)
            : base(name, age, sex)
            {
                
            }

        public void MakeNoise()
        {
            Console.WriteLine("Kvak- Kvak");                
        }

        public override string ToString()
        {
            return string.Format("{0}", base.ToString());
        } 
    }

}
