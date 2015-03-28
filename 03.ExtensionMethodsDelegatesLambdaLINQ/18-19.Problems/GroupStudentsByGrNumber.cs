/*Problem 18. Grouped by GroupNumber

Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
Use LINQ.
Problem 19. Grouped by GroupName extensions

Rewrite the previous using extension methods.
 */
namespace _18_19.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   
    using Problems1;     //using by 09-16.Problems project

    public class GroupStudentsByGrNumber
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

            //Problem 18

            var groupedStudentsLINQ = from student in students
                                      orderby student.GroupNumber
                                      select (string.Format("{0} {1}, GroupNumber: {2}", student.FirstName, student.LastName, student.GroupNumber));
            
            Console.WriteLine("The selected students by group number!");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(String.Join(Environment.NewLine, groupedStudentsLINQ));
            Console.WriteLine();
            //Problem 19

            
            var groupedStudentsExt = students
                .OrderBy(x => x.GroupNumber)
                .Select(x => string.Format("{0} {1}, GroupNumber: {2}", x.FirstName, x.LastName, x.GroupNumber));
            
            
            Console.WriteLine("The selected students by group number using extension");
            Console.WriteLine("-----------------------------------------------------"); 
            Console.WriteLine(String.Join(Environment.NewLine, groupedStudentsExt));
            Console.WriteLine();
        }
    }
}
