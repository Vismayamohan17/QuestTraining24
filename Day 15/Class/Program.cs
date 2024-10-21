using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public string Country { get; set; }

        public override string ToString() => $"Name:{Name},Age:{Age},Country:{Country}";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Person>()
            {
                new Person { Name = "Person 1", Country = "US", Age = 45 },
                new Person { Name = "Person 2", Country = "US", Age = 30 },
                new Person { Name = "Person 3", Country = "US", Age = 58 },
                new Person { Name = "Person 4", Country = "Uk", Age = 54 }

            };
            var res = data.Where(p => p.Country == "US");

            foreach (var person in res)
            {
                Console.WriteLine(person.Name);
            }
            //var minAge = data.Where(p => p.Country == "US").Min(p => p.Age);
            //var person = data.Where(p => p.Country == "US" && p.Age == minAge).FirstOrDefault();
            //Console.WriteLine(minAge.ToString());

            //var pplInDescending = data.OrderByDescending(p => p.Age);
            //var Countries = data.Select(p => p.Country).Distinct();


            //new Person { Name = "Person 1", Emails = new string[] {"a@gmail.com", "a@outlook.com"}},
            //new Person { Name = "Person 2", Emails = new string[] {"b@gmail.com", "b@outlook.com"}},
            //new Person { Name = "Person 3", Emails = new string[] {"c@gmail.com", "c@outlook.com"}},
            //new Person { Name = "Person 4", Emails = new string[] {"d@gmail.com", "d@outlook.com"}}

            //new Person { Name = "Person 1", Country = "US" };
            //new Person { Name = "Person 2", Country = "US" };
            //new Person { Name = "Person 3", Country = "IN" };
            //new Person { Name = "Person 4", Country = "Uk", };

                //    var emailArrayList = data.Select(p=> p.Emails).ToList();
                //    var emails = data.SelectMany(p => p.Emails).ToList();
                //    foreach (var email in emails)
                //{
                //    Console.WriteLine(email);
                //}

            //var groups = data.GroupBy(p => p.Country);

            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"{group.Key} - {group.Count()}");
            //}
            
            //foreach (var person in group)
            //{
            //    Console.WriteLine($"\t{person}");
            //}
        }
    }
}
