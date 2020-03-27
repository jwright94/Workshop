using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var userDb = UserDb.FromFile("./data.json");
            
            var user = userDb.Users.FirstOrDefault();

            // What does our data look like
            Console.WriteLine(user);
            
            // Let's calculate an average score
            Console.WriteLine($"Average Score: {CalculateAverage(user.Grades)}");

            // Again but with Linq
            Console.WriteLine($"Average Score: {user.Grades.Average()}");

            // Transforming data
            var setsOfGrades = userDb.Users.Select(x => x.Grades);
            var studentAverages = setsOfGrades.Select(x => x.Average());

            var highestAverage = studentAverages.Max();

            Console.WriteLine($"The highest average is: {highestAverage}");
            
            // Filtering lists
            var usersWhoseNameStartsWithA = userDb.Users.Where(x => x.FirstName.ToLower().StartsWith('a'));

            foreach(var aUser in usersWhoseNameStartsWithA)
            {
                Console.WriteLine(aUser);
            }

            // More advanced filtering
            var gradeAStudents = userDb.Users.Where( x => x.Grades.Average() > 90);

            foreach(var student in gradeAStudents)
            {
                Console.WriteLine(student);
            }

            // Sorting
            var topStudent = userDb.Users
                .OrderByDescending(x => x.Grades.Average())
                .FirstOrDefault();

            Console.WriteLine("Top of the Class is:");
            Console.WriteLine(topStudent);
            
            
            /*
            foreach(var user in userDb.Users)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName}");
                Console.WriteLine($"\t{user.ProfilePicture}");
            }
            */
        }

        private static double CalculateAverage(int[] numbers)
        {
            double total = 0;
            
            foreach(var number in numbers)
            {
                total += number;
            }

            return total / numbers.Length;
        }
    }
}