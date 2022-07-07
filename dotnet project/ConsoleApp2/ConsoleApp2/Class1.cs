using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    internal class Phone

    {
        public void phonedetails()
        {

            FileStream obj1 = new FileStream(@"C:\Users\RIYASINGH63\Desktop\networklog1.txt", FileMode.Open, FileAccess.Read);
            StreamReader obj2 = new StreamReader(obj1);
            Console.WriteLine("Id\t" + "Source\t\t" + "Destination\t\t" + "Date\t\t" + "Time\t\t" + "Status\t\t" + "Network ");

            while (obj2.Peek() > 0)
            {

                int i = 0;
                while (i < 6)
                {
                    string temp = obj2.ReadLine();


                    if (temp.StartsWith("Date"))
                    {


                        String[] myStrs = temp.Split(' ');
                        String[] string2 = myStrs[0].Split(':');
                        Console.Write(myStrs[1] + "\t" + string2[1]);
                    }


                    else
                    {


                        String[] myStrs = temp.Split(':');
                        Console.Write(myStrs[1] + "\t");
                    }

                    i++;
                }
                Console.WriteLine();
            }
            obj1.Close();

        }
    }
}

                
            




            

        
    

