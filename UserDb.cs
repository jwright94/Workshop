using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace Demo 
{
    public class UserDb
    {
        public IEnumerable<User> Users => _users;

        private User[] _users;

        private UserDb() { }
        public static UserDb FromCode()
        {
            var userDb = new UserDb();

            userDb._users = new User[] {
                new User() {
                    FirstName = "Dude",
                    LastName = "Guy",
                    ProfilePicture = "http://placekitten.com/256/256"
                },

                new User() {
                    FirstName = "Evangelina",
                    LastName = "McClanahan",
                    ProfilePicture = null
                },

                new User() {
                    FirstName = "Forbesalina",
                    LastName = "McScotihan",
                    ProfilePicture = null
                },
            };

            return userDb;
        }

        public static UserDb FromFile(string filename)
        {
            var userDb = new UserDb();
            
            var users = JsonConvert.DeserializeObject<User[]>(File.ReadAllText(filename));

            userDb._users = users;

            return userDb;
        }
    }
}