using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//oops,Design pattern
//Async await
//parallel programming
//Linq- Language integrated query--select statement
//Linq with objects(Collections)
//Linq with xml
//Linq with dataset/datatable
//

namespace CSharrpApplication
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            //select*from tablename where group having order
            //int[] values = { 5, 6, 7, 8, 9, 10, 55, 12, 2, 7 };
            //select * from d where d>10 and <50
            //var result = from d in values
            //    where d> 10 &&d<50
            //    select d;
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Student.ShowStudentDetail();
            //Num.Number();
            //Numbers numobj = new Numbers();
            //numobj.num1();
            Person obj = new Person();
            obj.older();
            obj.Ending_with();

            Console.ReadLine();
        }
    }
}
