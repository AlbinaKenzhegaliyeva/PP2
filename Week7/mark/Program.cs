using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace sereliz
{
	[Serializable]
	public class Student
	{
		public string name;
		public string ID;
		public Student() { }
		public Mark english;

		public Student(string name, string ID, Mark english)
		{
			this.name = name;
			this.ID = ID;
			this.english = english;
		}
		public override string ToString()
		{
			return String.Format("Students name : {0}, ID : {1}, Mark:{2}", name, ID, english);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Mark eng = new Mark("A", 95);
			Mark physics = new Mark("B", 80);
			Student s1 = new Student("Aray", "123", eng);
			Student s2 = new Student("Ayau", "0000", physics);
			List<Student> list = new List<Student>();
			list.Add(s1);
			list.Add(s2);

			FileStream fs = new FileStream("book.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			XmlSerializer xm = new XmlSerializer(typeof(List<Student>));
			xm.Serialize(fs, list);
			fs.Close();

			FileStream fs1 = new FileStream("book.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			List<Student> list2 = (List<Student>)xm.Deserialize(fs1);
			fs1.Close();
			foreach (Student s in list2)
			{
				Console.WriteLine(s);
			}

		}
	}
}
