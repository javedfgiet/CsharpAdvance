using System;
using System.Linq;
using BookRepository = CsharpAdvance.LINQ.BookRepository;

namespace CsharpAdvance
{
    public class Program
    {

        static void Main(string[] args)
        {

            var employees = new[]
                        {
                new { Name = "Alice", Salary = 50000 },
                new { Name = "Bob", Salary = 70000 },
                new { Name = "Charlie", Salary = 60000 },
                new { Name = "David", Salary = 80000 }
            };

            //find second heighest Salary

            var salary = employees.OrderByDescending(x => x.Salary).Skip(1).First().Salary;
            Console.WriteLine($"Second heighest salary is : {salary}");
        }
    }
}


    }
}
