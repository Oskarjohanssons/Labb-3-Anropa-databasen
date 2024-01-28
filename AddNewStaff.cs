using Labb_3___Anropa_databasen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Anropa_databasen
{
    internal class AddNewStaff
    {
        public static void NewStaff(HighSchoolDbContext context)
        {
            Console.WriteLine("Lägg till ny personal:");
            Console.Write("Förnamn: ");
            string firstName = Console.ReadLine();
            Console.Write("Efternamn: ");
            string lastName = Console.ReadLine();
            Console.Write("Position: ");
            string position = Console.ReadLine();

            var newStaff = new Staff
            {
                Fname = firstName,
                Lname = lastName,
                Position = position
            };

            context.Staff.Add(newStaff);
            context.SaveChanges();
            Console.WriteLine("Ny personal tillagd!");
            Console.WriteLine("Tryck på enter för att komma till menyn igen");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
