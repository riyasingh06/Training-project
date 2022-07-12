using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharrpApplication
{
    public class class4
    {
        public void Num4()
        {
            string[] arr2 = new string[] { "ROME", "LONDON", "NAIROBI",
                "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            var result = from d in arr2
                         where d.StartsWith("A") && d.EndsWith("M")
                         select d;

            foreach (var item in result)
            {
               
                Console.WriteLine(item);

            }

        }
    }
    internal class Assign4
    {
    }
}
