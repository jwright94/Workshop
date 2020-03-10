using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var userDb = new UserDb();
            
            foreach(var user in userDb.Users)
            {
                Console.WriteLine($"{user.FirstName} {user.LastName}");
                Console.WriteLine($"\t{user.ProfilePicture}");
            }
        }
    }
}

/*
Useful things you might not have seen
 -string interpolation $"{}"
 -string literals with @
 -nullable types (struct as example?)
 -null propagation
 -null coalescing
 -is/aa
*/