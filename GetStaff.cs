using Labb_3___Anropa_databasen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Anropa_databasen
{
    internal class GetStaff
    {
        public static void Staff()
        {
            Console.WriteLine("Vill du se alla anställda eller bara lärare? (alla/lärare)");
            string categoryChoice = Console.ReadLine();

            using (var context = new HighSchoolDbContext())
            {
                var staffQuery = context.Staff.AsQueryable();

                if (categoryChoice.ToLower() == "lärare")
                {
                    staffQuery = staffQuery.Where(s => s.Position == "Teacher");
                }

                var staffList = staffQuery.ToList();

                foreach (var staff in staffList)
                {
                    Console.WriteLine($"{staff.Fname} {staff.Lname} - {staff.Position}");
                }
            }
            Console.WriteLine("Tryck på enter för att komma till menyn igen");
            Console.ReadLine();
            Console.Clear();

        }
    }

}
