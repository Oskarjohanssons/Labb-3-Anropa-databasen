using Labb_3___Anropa_databasen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Anropa_databasen
{
    internal class AddNewStudent
    {
        public static void NewStudent(HighSchoolDbContext context)
        {
            Console.WriteLine("Lägg till ny elev:");
            Console.Write("Förnamn: ");
            string firstName = Console.ReadLine();
            Console.Write("Efternamn: ");
            string lastName = Console.ReadLine();
            Console.Write("Personnummer: ");
            string ssn = Console.ReadLine();
            Console.Write("Klass: ");
            string studentClass = Console.ReadLine();

            var newStudent = new Student
            {
                Fname = firstName,
                Lname = lastName,
                Ssn = ssn,
                Class = studentClass
            };

            context.Students.Add(newStudent);
            context.SaveChanges();
            Console.WriteLine("Ny elev tillagd!");
            Console.WriteLine("Tryck på enter för att komma till menyn igen");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
