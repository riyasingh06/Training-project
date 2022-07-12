using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharrpApplication
{
    public class class2
    {
        public void Num2()
        {
            Console.Write("Enter the String");
            string a = Console.ReadLine();
            var Frequency = from x in a
                            group x by x into y
                            select y;
            Console.Write("The frequency of the characters are :\n");
            foreach (var item in Frequency)
            {
                Console.WriteLine("Character " + item.Key + ": " + item.Count() + " times");
            }



        }




    }

    internal class Assign3
    {
    }
}



