using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    internal class Movie
    {
        public void CreateMovie()
        {
            //step 1 how to create file ?
            FileStream filestreamobj = new FileStream("C:\\Users\\RIYASINGH63\\Documents\\dotnet project\\Movie", FileMode.Create,FileAccess.Write);
            //how to write file
            StreamWriter streamWriter = new StreamWriter(filestreamobj);
            Console.Write("Movie Name: ");
            streamWriter.WriteLine(Console.ReadLine());
            Console.Write("Movie ID: ");
            streamWriter.WriteLine(Console.ReadLine());
            Console.Write("MovieLanguage : ");
            streamWriter.WriteLine(Console.ReadLine());
            
            streamWriter.Close();
            filestreamobj.Close();
            Console.WriteLine("File Operation Completed");


        }
        public void SelectMovie()
        {
            FileStream obj2 = new FileStream("C:\\Users\\RIYASINGH63\\Documents\\dotnet project\\Movie", FileMode.Open, FileAccess.Read);
            StreamReader streamobj = new StreamReader(obj2);
            //Console.WriteLine(streamobj.ReadLine());
            //Console.WriteLine(streamobj.ReadLine());
            //Console.WriteLine(streamobj.ReadLine());
            //obj2.Close();
            //Array
            //string[] myValues = new string[5];
            //myValues[0] = "A";
            //myValues[1] = "B";
            //myValues[2] = "C";
            //myValues[3] = "D";
            //myValues[4] = "E";

            while (streamobj.Peek() > 0)
            {
                

                string line=streamobj.ReadLine();
                String[] myStrs = line.Split(':');
                Console.WriteLine(myStrs[1]);


            }
            //obj2.Close();

        }

       
    }
}
