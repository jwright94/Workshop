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
            
            
            // Let's calculate an average score
            

            // Again but with Linq
            

            // Transforming data
            
            
            // Filtering lists
            

            // More advanced filtering
            

            // Sorting
            
            
            
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