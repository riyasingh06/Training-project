using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace ConsoleApp1
{


	public class Detail
	{
		string name { get; set; }
		int age { get; set; }
		string city { get; set; }


}

	internal class Serialization
	{
		public void XmlSerialize()
		{
			Detail bs = new Detail();
            Console.WriteLine()
			XmlSerializer xs = new XmlSerializer(typeof(Detail));
			TextWriter txtWriter = new StreamWriter(@"C:\Training\Detail.xml");
			xs.Serialize(txtWriter, bs);
			txtWriter.Close();
		}

        public void XmlDeSerialize()
        {
            Detail bs = new Detail();
            XmlSerializer xs = new XmlSerializer(typeof(Detail));
            StreamReader reader = new StreamReader(@"C:\Training\serialization.xml");
            bs = (Detail)xs.Deserialize(reader);
            Console.WriteLine("Employee Details  ");
            Console.WriteLine("Name  " + bs.name);
            Console.WriteLine("Age  " + bs.age);
            Console.WriteLine("City  " + bs.city);



        }
        //public void JsonSerialize()
        //{


        //	string jsonString = JsonSerializer.Serialize(Class3);
        //	var obj = JsonSerializer.Deserialize<Class3>(jsonString);
        //	Console.Write(obj.name);
        //	Console.Write(obj.age);
        //	Console.Write(obj.city);

        //}
    }
}