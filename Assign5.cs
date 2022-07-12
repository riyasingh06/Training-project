using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharrpApplication
{
    public class Class5
    {
        public void num5()
        {
            //int[] A = new int[] { 1, 2, 43, 66, 74, 32, 50, 22, 57, 89 };
            //Console.Write("How many records you want to display  : ");
            //int n=Convert.ToInt32(Console.ReadLine());
            //var Result = (from d in A
            //             orderby d descending
            //             select d).Take(n);
            //Console.WriteLine("the first "+n+ " records are: "  );
            //foreach (var item in Result)
            //{
            //    Console.Write(item+ " " );
            //}
            List<string> fruits = new List<string>() { "Lemon", "Apple", 
                "Orange", "Lime", "Watermelon", "Loganberry" };
            var result= from f in fruits
                        where f.StartsWith("L")
                        select f;
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

        }

    }
    internal class Assign5
    {
    }
}
