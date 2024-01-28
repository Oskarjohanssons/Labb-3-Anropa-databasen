using Labb_3___Anropa_databasen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Anropa_databasen
{
    internal class GetGradesLastMonth
    {
        public static void GradesLastMonth(HighSchoolDbContext context)
        {
            DateOnly lastMonth = DateOnly.FromDateTime(DateTime.Now.AddMonths(-1));

            var gradeData = context.Grades
                .Where(g => g.Date >= lastMonth)
                .Select(g => new
                {
                    StudentName = $"{g.Student.Fname} {g.Student.Lname}",
                    CourseName = g.Course.CourseName,
                    GradeValue = g.Grade1
                });

            foreach (var grade in gradeData)
            {
                Console.WriteLine($"{grade.StudentName} - {grade.CourseName} Grade: {grade.GradeValue}");
            }
            Console.WriteLine("Tryck på enter för att komma till menyn igen");
            Console.ReadLine();
            Console.Clear();
        }



    }
}
