using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArrayDemo
    {
        public static void GetTotalTicket() //static allows to accss directly by class classname
        {
            // What is jagged array?tEasy to customized
            string[][] counter = new string[3][];
            counter[0] = new string[3]; //["p1", "p2"];
            counter[1] = new string[2];
            counter[3]= new string[4];
            counter[0][0] = "p1";
            counter[0][1] = "p1";
            counter[0][2] = "p1";
            counter[1][0] = "p4";
            counter[1][1] = "p5";
            counter[2][0] = "p6";
            counter[2][1] = "p7";
            counter[2][2] = "p8";
            counter[2][3] = "p9";
            for(int i=0; i <counter.Length;i++)
            {
                for (int j = 0; j < counter[i].Length;j++)
                {

                }
            }
              //NON GENERIC DICTIONARY  inside a function 
              Dictionary<int, string> dic = new Dictionary<int, string>();
            dic[101] = "passed";
            dic[102] = "failed";
            foreach(var item in dic)
            {
                Console.WriteLine(item.key);
                Console.WriteLine(item.value);
                Console.WriteLine(dic[item.key]);
            }
            //hashtable
            Hashtable hashtable = new Hashtable();
            hashtable[101] = "passed";
            hashtable[102] = "Failed";





        }
    }
}
