namespace School
{
    using System;
    using System.Collections.Generic;
    

    public class SchoolMain
    {
        static void Main()
        {
            // Test Student
            var newStudent = new Student("Pesho", 12);  
            Console.WriteLine(newStudent);

            //Test Teacher
            var newTeacher = new Teacher("Minkova");
            
            Console.WriteLine(newTeacher);

            //Test Discipoline
            List<Discipline> disciplines = new List<Discipline>();

            disciplines.Add(new Discipline("Minkova", "Mathematics", 5, 15));
            disciplines.Add(new Discipline("Markova", "Physics", 10, 35));

            foreach (var discipline in disciplines)
            {
                Console.WriteLine(discipline);
            }
                           

            //Test Class
                 
            var bClass = new Class("Spiridon", 13, "7b");
            Console.WriteLine(bClass);
            
            bClass.Comment = "Spiridon pee pesen na Azis po vreme na chas!";

            Console.WriteLine(bClass.Comment);


            
        }
    }
}
