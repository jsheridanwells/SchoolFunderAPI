using SchoolFunderAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolFunderAPI.DataAccessLayer
{
    public static class SchoolFunderDbInitializer
    {
        public static void Initialize(SchoolFunderContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any()) return;

            var users = new User[]
            {
                new User()
                {
                    FirstName = "Jeremy",
                    LastName = "Wells",
                    Email = "jeremy@example.com",
                    Address = "123 Main Street",
                    City = "Cordosa",
                    State = "WY",
                    ZipCode = "12234"

                }
            };

            foreach(User u in users)
            {
                context.Users.Add(u);
            }

            context.SaveChanges();
        }
        
    }
}
