using System;
using System.Linq;

namespace CsharpAdvance.LINQ
{
    public class LINQJOin
    {
        public void LinqInnerJoin()
        {
            var customers = new[]
            {
                new { Id = 1, Name = "Alice" },
                new { Id = 2, Name = "Bob" }
            };

            var orders = new[]
            {
                new { OrderId = 101, CustomerId = 1, Product = "Laptop" },
                new { OrderId = 102, CustomerId = 2, Product = "Phone" },
                new { OrderId = 103, CustomerId = 1, Product = "Tablet" }
            };

            var query = customers.Join(orders, c => c.Id, o => o.CustomerId, (c, o) => new
            {
                c.Name,
                o.Product,
                o.OrderId

            });

            foreach (var item in query)
                Console.WriteLine($"{item.Name} bought {item.Product}");
        }

        /*
         * Left Outer Join ensures that every item from the left sequence appears in the result.
         * If there’s no matching item in the right sequence, LINQ fills it with null.
         * Implemented using join ... into and DefaultIfEmpty().
         */
        public void LinqLeftJoin()
        {
            var customers = new[]
            {
                new { Id = 1, Name = "Alice" },
                new { Id = 2, Name = "Bob" },
                 new { Id = 3, Name = "Charlie" }
            };

            var orders = new[]
            {
                new { OrderId = 101, CustomerId = 1, Product = "Laptop" },
                new { OrderId = 102, CustomerId = 2, Product = "Phone" },

            };

            var query = from c in customers
                        join o in orders
                        on c.Id equals o.CustomerId into gj
                        from d in gj.DefaultIfEmpty()
                        select new
                        {
                            Customer = c.Name,
                            ProductName = d?.Product ?? "No Order"
                        };
            foreach (var item in query)
                Console.WriteLine($"{item.Customer} - {item.ProductName}");
        }

        /*
         * Right Outer Join includes all elements from the right sequence.
         * If no match exists in the left sequence, LINQ fills the left side with null.
         * Implemented using join ... into and DefaultIfEmpty() — just like a left join, but reversed.
         */
        public void LinqRightJoin()
        {
            var customers = new[]
            {
                new { Id = 1, Name = "Alice" },
                new { Id = 2, Name = "Bob" }
            };

            var orders = new[]
            {
                new { OrderId = 101, CustomerId = 1, Product = "Laptop" },
                new { OrderId = 102, CustomerId = 3, Product = "Tablet" }
            };

            // Right Outer Join (swap collections)
            var query = from o in orders
                        join c in customers
                        on o.CustomerId equals c.Id into gj
                        from c in gj.DefaultIfEmpty()
                        select new
                        {
                            CustomerName = c?.Name ?? "Unknown Customer",
                            ProductName = o.Product
                        };


            foreach (var item in query)
                Console.WriteLine($"{item.CustomerName} - {item.ProductName}");
        }

        /*
         * GroupJoin pairs each element from the left sequence with a collection of matching elements from the right sequence.
         * The result is a sequence of groups, where each group contains the left element and all its matches.
         * Useful for one-to-many relationships (e.g., Customer → Orders).
         */
        public void LinqGroupJoin()
        {
            var customers = new[]
            {
                new { Id = 1, Name = "Alice" },
                new { Id = 2, Name = "Bob" }
            };

            var orders = new[]
            {
                new { OrderId = 101, CustomerId = 1, Product = "Laptop" },
                new { OrderId = 102, CustomerId = 1, Product = "Tablet" },
                new { OrderId = 103, CustomerId = 2, Product = "Phone" }
            };

            // GroupJoin
            var query = customers.GroupJoin(orders,
                c => c.Id,
                o => o.CustomerId, (c, orderGroup) => new
                {
                    Customer = c.Name,
                    Orders = orderGroup
                });

            foreach (var item in query)
            {
                Console.WriteLine($"{item.Customer}:");
                foreach (var order in item.Orders)
                    Console.WriteLine($"  - {order.Product}");
            }
        }

        /*
         * Full Join = All records from both sequences.
         * Matches are paired, and non-matches are filled with null.
         * Implemented by combining DefaultIfEmpty() on both sides.
         */
        public void LinqFullOuterJoin()
        {
            var customers = new[]
            {
                new { Id = 1, Name = "Alice" },
                new { Id = 2, Name = "Bob" }
            };

            var orders = new[]
            {
                new { OrderId = 101, CustomerId = 1, Product = "Laptop" },
                new { OrderId = 102, CustomerId = 3, Product = "Tablet" }
            };

            var leftjoin = from c in customers
                           join o in orders
                           on c.Id equals o.CustomerId into gj
                           from o in gj.DefaultIfEmpty()
                           select new
                           {
                               Customer = c.Name,
                               Product = o?.Product?? "No Orders"
                           };

            var rightJoin = from o in orders
                            join c in customers
                            on o.CustomerId equals c.Id into gj
                            from c in gj.DefaultIfEmpty()
                            select new
                            {
                                Customer = c?.Name ?? "Unknown Customer",
                                Product = o.Product

                            };

            var fullJoin = leftjoin.Union(rightJoin);
            foreach (var item in fullJoin)
                Console.WriteLine($"{item.Customer} - {item.Product}");

        }

    }
}
