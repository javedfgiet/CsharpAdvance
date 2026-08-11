using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance.LINQ
{
    public class LinqDemoFunctions
    {
        public void DemoSelectMany()
        {
            var students = new[]
            {
                new { Name = "Alice", Courses = new[] { "Math", "Physics" } },
                new { Name = "Bob", Courses = new[] { "Chemistry" } },
                new { Name = "Charlie", Courses = new[] { "Biology", "Math" } }
            };

            // SelectMany flattens nested collections
            var query = students.SelectMany(
                s => s.Courses,
                (student, course) => new { student.Name, course }
            );

            foreach (var item in query)
                Console.WriteLine($"{item.Name} enrolled in {item.course}");
        }
    }
}
