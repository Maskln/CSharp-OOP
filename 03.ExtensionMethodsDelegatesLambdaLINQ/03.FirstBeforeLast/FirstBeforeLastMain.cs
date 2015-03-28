
namespace _03.FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FirstBeforeLastMain
    {
        static void Main()
        {
            Student[] someStudents =
            {
                new Student("Ivan", "Georgiev", 25),
                new Student("Peter", "Ivanov", 22),
                new Student("Gosho", "Lyubenov", 16),
                new Student("Kiro", "Dimitrov", 18),
                new Student("Asen", "Berbatov", 24),

            };

            //Problem 3
            Console.WriteLine("Students whose first name is before its last name alphabetically:");
            var firstBeforeLast = FirstBeforeLastName(someStudents);

            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();


            //Problem 4
            Console.WriteLine("Students with age between 18 and 24:");

            var studentInRange = FindPeopleInAgeBetween(someStudents, 18, 24);

            foreach (var student in studentInRange)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            //Problem 5 using lambda

            Console.WriteLine("Sorted students by first name and last name in descending order by Lambda expresions");

            var lambdaDescendingOrder = StudentsDescendingOrderWithLambda(someStudents);

            foreach (var studen in lambdaDescendingOrder)
            {
                Console.WriteLine(studen);
            }

            Console.WriteLine();

            //Problem 5 using Linq

            Console.WriteLine("Sorted students by first name and last name in descending order by LINQ");
            var linqDescendingOrder = StudentsDescendingOrderWithLINQ(someStudents);

            foreach (var student in linqDescendingOrder)
            {
                Console.WriteLine(student);
            }
            {

            }

        }

        //Problem 3
        private static IEnumerable<Student> FirstBeforeLastName(Student[] students)
        {
            IEnumerable<Student> result = from student in students
                                          where student.FirstName.CompareTo(student.LastName) < 0
                                          select student;
            return result;
        }

        //Problem 4
        private static IEnumerable<Student> FindPeopleInAgeBetween(Student[] students, int minAge, int maxAge)
        {
            IEnumerable<Student> result = from student in students
                                          where student.Age >= minAge && student.Age <= maxAge
                                          select student;
            return result;
        }

        // Problem 5
        private static IEnumerable<Student> StudentsDescendingOrderWithLambda(Student[] studentsList)
        {
            var result = studentsList
                        .OrderByDescending(st => st.FirstName)
                        .ThenByDescending(st => st.LastName)
                        .ToArray();

            return result;
        }

        // Problem 5
        private static IEnumerable<Student> StudentsDescendingOrderWithLINQ(Student[] studentsList)
        {
            var result = from student in studentsList
                         orderby student.FirstName descending,
                         student.LastName descending
                         select student;
            return result;
        }
    }
}
