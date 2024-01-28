using Labb_3___Anropa_databasen.Models;
using Microsoft.Data.SqlClient;

namespace Labb_3___Anropa_databasen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HighSchoolDbContext context = new HighSchoolDbContext();
            while (true)
            {
                Console.WriteLine("Välj en funktion:");
                Console.WriteLine("1. Hämta personal");
                Console.WriteLine("2. Hämta alla elever");
                Console.WriteLine("3. Hämta elever i en viss klass");
                Console.WriteLine("4. Hämta betyg senaste månaden");
                Console.WriteLine("5. Hämta kursstatistik");
                Console.WriteLine("6. Lägga till ny elev");
                Console.WriteLine("7. Lägga till ny personal");
                Console.WriteLine("0. Avsluta");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        GetStaff.Staff();
                        break;
                    case "2":
                        GetStudents.Students(context);
                        break;
                    case "3":
                        GetStudentsInClass.StudentsInClass(context);
                        break;
                    case "4":
                        GetGradesLastMonth.GradesLastMonth(context);
                        break;
                    case "5":
                        GetCourseStatistics.CourseStatistics(context);
                        break;
                    case "6":
                        AddNewStudent.NewStudent(context);
                        break;
                    case "7":
                        AddNewStaff.NewStaff(context);
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Vänligen försök igen.");
                        break;
                }
                context.SaveChanges();
            }
        }
    }
    
}
