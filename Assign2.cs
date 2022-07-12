using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharrpApplication
{
    public class Numbers
    {
        public void num1()
        {
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var result = from d in arr1
                         group d by d into y
                         select y;

            foreach (var item in result)
            {
                Console.WriteLine("Number " + item.Key + " appears " + item.Count() + " times");

            }

        }
        internal class Assign2
        {
        }
    }
}
