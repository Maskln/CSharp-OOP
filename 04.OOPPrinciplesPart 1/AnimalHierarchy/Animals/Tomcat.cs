namespace AnimalHierarchy
{   
    using System;

    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name, uint age)
             : base(name, age, Gender.male)
         {
             
         }

        public void MakeNoise()
        {
            Console.WriteLine("Mrrr");
        }

         public override string ToString()
         {
             return string.Format("{0}", base.ToString());
         }
    }
}
