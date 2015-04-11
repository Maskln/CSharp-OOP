namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AnimalHierarchy
    {
        static void Main()
        {    
            // Test
            var doggy = new Dog("Pluto", 6, Gender.male);
            doggy.MakeNoise();
            Console.WriteLine(doggy);

            var frg = new Frog("Kikirica", 1, Gender.female);
            frg.MakeNoise();
            Console.WriteLine(frg);

            var sad = new Cat("Kitty", 2, Gender.female);
            Console.WriteLine(sad);
            sad.MakeNoise();

            var fdsa = new Kitten("Penka", 3);
            Console.WriteLine(fdsa);

            var sdf = new Tomcat("Tom", 2);
            Console.WriteLine(sdf);
            Console.WriteLine();

            //Create arrays of different kinds of animals and calculate the average age of each kind of animal

            var animals = new List<Animal>()
            {
                new Dog("Lasi", 2, Gender.female),
                new Dog("Sharko", 8, Gender.male),
                new Dog("Murdjo", 12, Gender.male),
                new Frog("Kikirica", 1, Gender.female),
                new Frog("Kiro", 2, Gender.male),
                new Frog("Krasta", 3, Gender.female),
                new Cat("Kitty", 5, Gender.female),
                new Cat("Tanq", 14, Gender.female),
                new Cat("Vera", 9, Gender.female),
                new Kitten("Penka", 3),
                new Kitten("Lisa", 4),
                new Kitten("Mia", 7),
                new Tomcat("Tom", 1),
                new Tomcat("Tiger", 17),
                new Tomcat("Lioncho", 10),

            };

            var averageDogs = animals.Where(x => x is Dog).Average(x => x.Age);
            var averageFrogs = animals.Where(x => x is Frog).Average(x => x.Age);
            var averageCats = animals.Where(x => x is Cat).Average(x => x.Age);
            var averageKittens = animals.Where(x => x is Kitten).Average(x => x.Age);
            var averageTomcats = animals.Where(x => x is Tomcat).Average(x => x.Age);

            Console.WriteLine("The Average age of the different animals!");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("The average age of dogs: {0:0.00}", averageDogs);
            Console.WriteLine("The average age of frogs: {0:0.00}", averageFrogs);
            Console.WriteLine("The average age of cats: {0:0.00}", averageCats);
            Console.WriteLine("The average age of kittens: {0:0.00}", averageKittens);
            Console.WriteLine("The average age of tomcats: {0:0.00}", averageTomcats);


        }
    }
}
