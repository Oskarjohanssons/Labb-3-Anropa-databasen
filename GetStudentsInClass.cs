using Labb_3___Anropa_databasen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Anropa_databasen
{
    class GetStudentsInClass
    {

        public static void StudentsInClass(HighSchoolDbContext context)
        {
            Console.WriteLine("Välj en klass att visa elever för:");
            var classes = context.Students.Select(s => s.Class).Distinct().ToList();
            foreach (var classItem in classes)
            {
                Console.WriteLine(classItem);
            }

            string selectedClass = Console.ReadLine();
            var studentsInClass = context.Students.Where(s => s.Class == selectedClass);

            foreach (var student in studentsInClass)
            {
                Console.WriteLine($"{student.Fname} {student.Lname}");
            }
            Console.WriteLine("Tryck på enter för att komma till menyn igen");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
