using Labb_3___Anropa_databasen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Anropa_databasen
{
    internal class GetCourseStatistics
    {
        public static void CourseStatistics(HighSchoolDbContext context)
        {
            var gradeMappings = new Dictionary<string, int>
    {
        {"A", 5},
        {"B", 4},
        {"C", 3},
        {"D", 2},
        {"E", 1},
        {"F", 0}
    };

            var courseStatistics = context.Courses
                .Include(c => c.Grades)
                .Select(c => new
                {
                    CourseNames = c.CourseName,
                    Grades = c.Grades.Select(g => g.Grade1)
                })
                .AsEnumerable()
                .Select(c => new
                {
                    c.CourseNames,
                    AverageGrade = c.Grades.Average(g => gradeMappings.ContainsKey(g) ? gradeMappings[g] : (int?)null) ?? 0,
                    MaxGrade = c.Grades.Max(g => gradeMappings.ContainsKey(g) ? gradeMappings[g] : (int?)null) ?? 0,
                    MinGrade = c.Grades.Min(g => gradeMappings.ContainsKey(g) ? gradeMappings[g] : (int?)null) ?? 0
                });

            foreach (var stat in courseStatistics)
            {
                Console.WriteLine($"{stat.CourseNames} - Avg Grade: {stat.AverageGrade}, Max Grade: {stat.MaxGrade}, Min Grade: {stat.MinGrade}");
            }
            Console.WriteLine("Tryck på enter för att komma till menyn igen");
            Console.ReadLine();
            Console.Clear();
        }


    }
}
