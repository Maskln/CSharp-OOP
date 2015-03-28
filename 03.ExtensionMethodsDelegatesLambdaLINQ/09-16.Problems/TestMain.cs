/* Problem 9. Student groups

Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.
 */

namespace Problems1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TestMain
    {
        public static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Gosho", "Mirkov", "432311", "+359885652545", "gosho.mirkov@abv.bg", 1, new List<int> { 2, 3, 4, 5, 6 }),
                new Student("Pesho", "Ivanov", "324306", "+359888888888", "pesho.ivanov@gmail.com", 2, new List<int> { 3, 2, 4, 3, 2 }),
                new Student("Kiro", "Petkov", "123456", "02 7265845", "morjo@abv.bg", 1, new List<int> { 2, 5, 4, 5, 5 }),
                new Student("Miro", "Georgiev", "543306", "+359886329855", "gotin94@mail.bg", 2, new List<int> { 6, 6, 4, 6, 6 })
            };

            // Problem 9
            Console.WriteLine("Students from group 2 sorted by first name (using LINQ):");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine(string.Join(Environment.NewLine, StudentsByGroupTwoWithLINQ(students)));

            // Problem 10
            Console.WriteLine("\nStudents from group 2 sorted by first name (using lambda):");
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine(string.Join(Environment.NewLine, StudentsByGroupTwoWithLambda(students)));

            // Problem 11
            Console.WriteLine("\nStudents with email in \"abv.bg\" (using LINQ):");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine(string.Join(Environment.NewLine, StudentsByEmailWithLINQ(students)));

            // Problem 12
            Console.WriteLine("\nStudents with Sofian phone number (using LINQ):");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine(string.Join(Environment.NewLine, StudentsByPhoneWithLINQ(students)));

            // Problem 13
            Console.WriteLine("\nStudents with excelent mark (using LINQ):");
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine(string.Join(Environment.NewLine, StudentsWithMark6WithLINQ(students)));

            // Problem 14
            Console.WriteLine("\nStudents with tho marks (2) (using lambda):");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine(string.Join(Environment.NewLine, StudentsWithTwoMarks2WithLambda(students)));

            // Problem 15
            Console.WriteLine("\nStudents that enrolled in 2006:");
            Console.WriteLine("---------------------------------");

            Console.WriteLine(string.Join(Environment.NewLine, StudentsEnrolled2006(students)));

            // Problem 16
            Console.WriteLine("\nStudents from 'Mathematics' department:");
            Console.WriteLine("-----------------------------------------");

            StudentsFromMathematicsDepartment(students);
        }

        //Problem 9
        private static IEnumerable<Student> StudentsByGroupTwoWithLINQ(List<Student> students)
        {
            return from student in students
                   where student.GroupNumber == 2
                   orderby student.FirstName
                   select student;
        }

        // Problem 10
        private static IEnumerable<Student> StudentsByGroupTwoWithLambda(List<Student> students)
        {
            return students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
        }

        //Problem 11
        private static IEnumerable<Student> StudentsByEmailWithLINQ(List<Student> students)
        {
            return from student in students
                   where student.Email.EndsWith("abv.bg")
                   select student;
        }

        //Problem 12
        private static IEnumerable<Student> StudentsByPhoneWithLINQ(List<Student> students)
        {
            return from student in students
                   where student.PhoneNumber.Contains("(02)") || student.PhoneNumber.StartsWith("02") ||
                         student.PhoneNumber.StartsWith("+3592")
                   select student;
        }

        //Problem 13
        private static IEnumerable<string> StudentsWithMark6WithLINQ(List<Student> students)
        {
            var newStudents = from student in students
                              where student.Marks.Contains(6)
                              select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            List<string> output = new List<string>();

            foreach (var student in newStudents)
            {
                output.Add(string.Format("{0}, Marks: {1}", student.FullName, string.Join(", ", student.Marks)));
            }

            return output;
        }

        //Problem 14
        private static IEnumerable<Student> StudentsWithTwoMarks2WithLambda(List<Student> students)
        {
            return students.Where(st => st.Marks.FindAll(m => m == 2).Count >= 2);
        }

        // Problem 15
        private static IEnumerable<string> StudentsEnrolled2006(List<Student> students)
        {
            var newStudents = students.Where(st => st.FacultyNumber.EndsWith("06"));

            List<string> output = new List<string>();

            foreach (var student in newStudents)
            {
                output.Add(string.Format("{0} {1}, Marks: {2}", student.FirstName, student.LastName, string.Join(", ", student.Marks)));
            }

            return output;
        }

        // Problem 16
        private static void StudentsFromMathematicsDepartment(List<Student> students)
        {
            List<Group> groups = new List<Group>()
            {
                new Group(1, "Mathematics"),
                new Group(2, "Physics")
            };

            var mathStudents = from student in students
                               join gr in groups on student.GroupNumber equals gr.GroupNumber
                               where gr.DepartmentName == "Mathematics"
                               select (string.Format("{0} {1}, GR: {2}, Department: {3}", student.FirstName, student.LastName,
                                       student.GroupNumber, gr.DepartmentName));

            foreach (var student in mathStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
