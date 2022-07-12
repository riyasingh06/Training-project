using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharrpApplication
{
    public class Students
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public int GrPoint { get; set; }

        public void max_grade()
        {

            List<Students> stulist = new List<Students>() {
            new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 },
            new Students { StuId = 2, StuName = "Alex", GrPoint = 458 },
            new Students { StuId = 3, StuName = "Harris", GrPoint = 900 },
            new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 },
            new Students { StuId = 5, StuName = "Smith", GrPoint = 458 },
            new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 },
            new Students { StuId = 7, StuName = "David", GrPoint = 750 },
            new Students { StuId = 8, StuName = "Harry", GrPoint = 700 },
            new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 },
            new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 },
        };
            Console.WriteLine("Which maximum grade point do you want to find:");

            int input = Convert.ToInt32(Console.ReadLine());
            var result = (from n in stulist
                          group n by n.GrPoint into g
                          orderby g.Key descending
                          select new
                          {
                              record = g.ToList()
                          }).ToList();
            var temp = result[input - 1].record;
            foreach (var item in temp)
            {
                Console.WriteLine("Id:{0}, Name:{1}, Achieved grade point:{2} ", item.StuId, item.StuName, item.GrPoint);
            }
            Console.Read();
        }
    }
    public class Person
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }
        public void Ending_with()
        {

            var people = new List<Person>();

            people.Add(new Person { First_Name = "Bill", Last_Name = "Smith", Age = 41 });
            people.Add(new Person { First_Name = "Sarah", Last_Name = "Jones", Age = 22 });
            people.Add(new Person { First_Name = "Stacy", Last_Name = "Baker", Age = 21 });
            people.Add(new Person { First_Name = "Vivianne", Last_Name = "Dexter", Age = 19 });
            people.Add(new Person { First_Name = "Bob", Last_Name = "Smith", Age = 49 });
            people.Add(new Person { First_Name = "Brett", Last_Name = "Baker", Age = 51 });
            people.Add(new Person { First_Name = "Mark", Last_Name = "Parker", Age = 19 });
            people.Add(new Person { First_Name = "Alice", Last_Name = "Thompson", Age = 18 });
            people.Add(new Person { First_Name = "Evelyn", Last_Name = "Thompson", Age = 58 });
            people.Add(new Person { First_Name = "Mort", Last_Name = "Martin", Age = 58 });
            people.Add(new Person { First_Name = "Eugene", Last_Name = "DeLauter", Age = 84 });
            people.Add(new Person { First_Name = "Gail", Last_Name = "Dawson", Age = 19 });


            var result = from d in people
                         where d.Last_Name.StartsWith("D")

                         select d;
            int i = 0;
            foreach (var item in result)
            {
                i++;
                Console.WriteLine(item.Last_Name);

            }
            Console.WriteLine(i);
            Console.Read();
        }
        public void older()
        {
            var people = new List<Person>();

            people.Add(new Person { First_Name = "Bill", Last_Name = "Smith", Age = 41 });
            people.Add(new Person { First_Name = "Sarah", Last_Name = "Jones", Age = 22 });
            people.Add(new Person { First_Name = "Stacy", Last_Name = "Baker", Age = 21 });
            people.Add(new Person { First_Name = "Vivianne", Last_Name = "Dexter", Age = 19 });
            people.Add(new Person { First_Name = "Bob", Last_Name = "Smith", Age = 49 });
            people.Add(new Person { First_Name = "Brett", Last_Name = "Baker", Age = 51 });
            people.Add(new Person { First_Name = "Mark", Last_Name = "Parker", Age = 19 });
            people.Add(new Person { First_Name = "Alice", Last_Name = "Thompson", Age = 18 });
            people.Add(new Person { First_Name = "Evelyn", Last_Name = "Thompson", Age = 58 });
            people.Add(new Person { First_Name = "Mort", Last_Name = "Martin", Age = 58 });
            people.Add(new Person { First_Name = "Eugene", Last_Name = "DeLauter", Age = 84 });
            people.Add(new Person { First_Name = "Gail", Last_Name = "Dawson", Age = 19 });

            var result = from d in people
                         orderby d.First_Name ascending
                         where d.Age > 40
                         select d;
            foreach (var item in result)
            {
                Console.WriteLine(item.First_Name);
            }

        }



    }


    internal class Assignfinal
    {
    }
}
