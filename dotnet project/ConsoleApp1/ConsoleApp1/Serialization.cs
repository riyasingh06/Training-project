using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;

namespace ConsoleApp1
{
	public class WeatherForecast
	{
		public DateTimeOffset Date { get; set; }
		public int TemperatureCelsius { get; set; }
		public string summary { get; set; }
	}
		public class Employee
		{
			public int Id = 1;
			public string name = "John Smith";
			public string subject = "Physics";
		}
	

		internal class Serialization
		{
			public void JsonSerialize()
			{
				var weatherForecast = new WeatherForecast
				{
					Date = DateTime.Parse("2019-08-01"),
					TemperatureCelsius = 25,
					summary = "Hot"
				};
				//WeatherForecast obj = new WeatherForecast();
				//obj.Date = DateTime.Now;
				//obj.TemperatureCelsius = 20;
				//obj.summary = "cool";
				string jsonString = JsonSerializer.Serialize(weatherForecast);
				var obj = JsonSerializer.Deserialize< WeatherForecast>(jsonString);
				Console.Write(obj.Date);

			}
			public void XmlSerialize()
			{
				Employee bs = new Employee();
				XmlSerializer xs = new XmlSerializer(typeof(Employee));
				TextWriter txtWriter = new StreamWriter(@"C:\Training\Serialization.xml");
				xs.Serialize(txtWriter, bs);
				txtWriter.Close();
			}
			public void XmlDeSerialize()
			{
				Employee bs = new Employee();
				XmlSerializer xs = new XmlSerializer(typeof(Employee));
				StreamReader reader = new StreamReader(@"C:\Training\serialization.xml");
				bs = (Employee)xs.Deserialize(reader);
				Console.WriteLine("Employee Details  ");
				Console.WriteLine("ID  " + bs.Id);
				Console.WriteLine("Name  " + bs.name);
				Console.WriteLine("Subject  " + bs.subject);

			}

		}
	
}

