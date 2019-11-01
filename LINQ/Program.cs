using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LINQ
{
    static class Extensions
    {
        public static bool MyContains(this string s, string key)
        {
            Console.WriteLine("MyContains called");
            return s.Contains(key);
        }
        public static bool IsPrime(this int x)
        {
            return true;
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var list = Enumerable.Range(0, 100);

            var filtered = list.Where(x => x.IsPrime())
                .OrderBy(x => x % 10)
                .ThenByDescending(x => x % 100 / 10)
                .Take(5);

            foreach (var x in filtered)
            {
                Console.WriteLine(x);
            }
            //var slist = new System.Collections.Generic.List<String>();

            //for (int i=0;i<100;i++)
            //{
            //    slist.Add(RandomString());
            //}
            //var filtered = slist.Where(s => s.MyContains("0"))
            //    .Select( s => s.Reverse())
            //    .ToList(); // LINQ uses deferred execution

            //Console.WriteLine("Deferred");

            //Console.WriteLine(filtered.Count());
            //foreach(var s in filtered)
            //{
            //    Console.WriteLine(s);
            //}


            //var elist = new List<Employee>();
            //var etransformed = elist.Select(emp =>new { FullName = emp.LastName + ", " + emp.FirstName, Id = emp.Id }); // anonymous class

            //foreach (var e in etransformed)
            //{
            //    Console.WriteLine(e.FullName);
            //}
        }

        private static string RandomString()
        {
            var r = new Random();
            return "" + r.Next();
        }
    }
}
