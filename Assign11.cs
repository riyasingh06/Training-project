using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharrpApplication
{
    public class Class11
    {
        List<int> mixedNum = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
        public void num11()
        {
            var result = from d in mixedNum
                         where d % 4 == 0 || d % 6 == 0
                         select d;
            Console.Write("All the numbers which are multiple of 4 or 6 area : ");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
        }

    }
    internal class Assign11
    {
    }
}
