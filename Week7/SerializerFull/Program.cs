using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
	public class Student
	{
		public int age;
		public string name;
		public Student()
		{

		}
	}
	class Program
	{
		static void serialization(Student st)
		{
			XmlSerializer xs = new XmlSerializer(typeof(Student));
			FileStream fs = new FileStream("student.txt", FileMode.Create, FileAccess.Write);
			xs.Serialize(fs, st);
			fs.Close();
		}
		static Student deserialization()
		{
			XmlSerializer xs = new XmlSerializer(typeof(Student));
			FileStream fs = new FileStream("student.txt", FileMode.Open, FileAccess.Read);
			return xs.Deserialize(fs) as Student;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Button F2 is Serialization");
			Console.WriteLine("Button F3 is Deserialization");

			Student st = new Student();
			string n;
			int a;
			ConsoleKeyInfo pressedKey = Console.ReadKey();

			switch (pressedKey.Key)
			{
				case ConsoleKey.F2:
					Console.Write("Enter Your name: ");
					n = Console.ReadLine();
					Console.Write("Enter Your age: ");
					a = int.Parse(Console.ReadLine());
					st.name = n;
					st.age = a;
					serialization(st);
					break;
				case ConsoleKey.F3:
					st = deserialization();
					Console.WriteLine();
					Console.WriteLine("Your Name Is " + st.name);
					Console.WriteLine("Your Age Is " + st.age);
					break;
			}
		}
	}
}