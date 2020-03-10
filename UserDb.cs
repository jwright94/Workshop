using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo 
{
    public class UserDb
    {
        public IEnumerable<User> Users => _users;

        private User[] _users;

        public UserDb()
        {
            _users = new User[] {
                new User() {
                    FirstName = "Dude",
                    LastName = "Guy",
                    ProfilePicture = new Picture() {
                        Width = 256, Height = 256,
                        URL = "http://placekitten.com/256/256"
                    }
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
        }
    }
}