using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Movie movieobj = new Movie();
            //movieobj.CreateMovie();
            //movieobj.SelectMovie();
            //Console.Read();
            //int a;
            //int b;
            //int c;
            //Console.Write("enter value of A : ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter value of B : ");
;            //b = Convert.ToInt32(Console.ReadLine());
             //c = a + b;
             //how to print/DISPLAY OUTPUT
             //Console.Write("output : ");
             //Console.WriteLine(c);
             //Console.Read();//HOW TO READ KEYBOARD
             //for (int i = 0; i < 5; i++)
             //
             //    Console.WriteLine(i);
             //}
             // Event eventobj= new Event();//how to create object,new keyword allocate memory allocation
             // eventobj.CreateEvent();
             //eventobj.SelectEvents();
             //Console.ReadLine(); //how to read keyboard input
             //Serialization serialize = new Serialization();
             //serialize.XmlSerialize();
             //serialize.XmlDeSerialize();
             //serialize.JsonSerialize();

            //GenericsDemo Demo = new GenericsDemo();
            //Demo.ShowReport(22);
            //Demo.ShowReport("Female");
            //Demo.ShowReport(30000);
            Serialization serialize = new Serialization();
            serialize.XmlSerialize();
            

            Console.ReadLine();
        }
    }
}
