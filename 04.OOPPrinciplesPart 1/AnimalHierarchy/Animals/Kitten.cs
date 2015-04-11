namespace AnimalHierarchy
{
    using System;
    
     public class Kitten: Cat, ISound
    {
         public Kitten(string name, uint age)
             : base(name, age, Gender.female)
         {
             
         }

         public void MakeNoise()
         {
             Console.WriteLine("Mrrau :D");
         }

         public override string ToString()
         {
             return string.Format("{0}", base.ToString());
         }
    }
}
