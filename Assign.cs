using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharrpApplication
{
    public class Num
    { 
    public static void Number()
    {
        int[] n1 = {
                1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14
            };

            var result = from d in n1
                         where d > 0
                         select d;
            foreach(var item in result)
            {
                Console.WriteLine(item);

            }
            Num num = new Num();



    }
}

    internal class Assign
    {

    }
}
