namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    

    public class StudentAndWorkers
    {
        static void Main()
        {

            var students = new List<Student>(){
                                                 new Student("Pesho", "Mitrev", 4),
                                                 new Student("Kiro", "Georgiev", 2),
                                                 new Student("Miro", "Manev", 5),
                                                 new Student("Spiro", "Petrov", 6),
                                                 new Student("Lyubo", "Nikolov", 6),
                                                 new Student("Meto", "Birov", 3),
                                                 new Student("Sashko", "Mateev", 4),
                                                 new Student("Gosho", "Ivanov", 5),
                                                 new Student("Valio", "Nanev", 6),
                                                 new Student("Vladi", "Mitrev", 2),
                                             };
           
            //Sorted Student by Grade
           
            Console.WriteLine("Sorted Students by Grade");
            Console.WriteLine("-------------------------");

            var sortedByGrade =
                               from student in students
                               .OrderBy(x => x.Grade)
                               select student;
            
            foreach (var student in sortedByGrade)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
            
           
            var workers = new List<Worker>
            {
                new Worker("Grisho", "Bachkarev", 215.35, 8),
                new Worker("Misho", "Murzeliev", 365.23, 8),
                new Worker("Pesho", "Kashonov", 200.00, 8),
                new Worker("Vancho", "Kopachev", 653.79, 8),
                new Worker("Kiro", "Metleev", 1005.00, 8),
                new Worker("Spiro", "Maystorov", 956.44, 8),
                new Worker("Vilio", "Seqchev", 785.65, 8),
                new Worker("Piro", "Popov", 150.36, 8),
                new Worker("Viktor", "Draganov", 986.32, 8),
                new Worker("Gesho", "Mechkaro", 237.36, 8),

            };

            Console.WriteLine("Sorted Workers by Money per hour- Descending");
            Console.WriteLine("---------------------------------------------");

            // Sorted Worker by money per hour - descending
            
            var descSortedWrks = 
                                from worker in workers
                                .OrderByDescending(x => x.MoneyPerHour())
                                select worker;

            foreach (var worker in descSortedWrks)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();


            //Merge the lists and sort them by first name and last name
            Console.WriteLine("Sorted Lists by First Name");
            Console.WriteLine("---------------------------");

            var merged = new List<Human>();

            merged.AddRange(students);
            merged.AddRange(workers);
           
            merged = merged.OrderBy(x => x.FirstName)
                     .ThenBy(x => x.LastName)
                     .ToList();

            Console.WriteLine(String.Join(", ", merged.Select(x => String.Format("{0} {1}", x.FirstName, x.LastName))));

        }
    }
}
