namespace StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestMain
    {
        static void Main()
        {
            var firstStudent = new Student("Pesho", "Petrov", "Ivanov", 123456, "Blagoevdrad", "+359888888888", "Second",
                                    Specialty.Astronomy, University.Cambridge, Faculty.ScienceAndTechnology);
            
            var secondStudent = new Student("Kiro", "Ivanov", "Petrov", 654321, "Kaspichan", "+359899999999", "Third",
                                    Specialty.Graphic_Design, University.Harvard, Faculty.ArtsAndHumanities);

            Console.WriteLine(firstStudent);
            Console.WriteLine();
            Console.WriteLine(secondStudent);
            Console.WriteLine();


            Console.WriteLine("firstStudent == secondStudent: {0}", firstStudent == secondStudent);
            Console.WriteLine("firstStudent != secondStudent: {0}", firstStudent != secondStudent);
            Console.WriteLine("GetHashCode of the first student: {0}", firstStudent.GetHashCode());
            

            Console.WriteLine();
          


        }
    }
}
