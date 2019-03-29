using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace nameVivod
{
	[Serializable]
	public class Student
	{
		public string name;
		public Student() { }
		public Student(string name)
		{ this.name = name; }
		public override string ToString()
		{
			return String.Format(" Students name : {0}", name);
		}

	}


	class Program
	{
		static void Main(string[] args)
		{
			Student s1 = new Student("Nazerke");
			Student s2 = new Student("Tomi");
			List<Student> list = new List<Student>();
			list.Add(s1);
			list.Add(s2);
			FileStream fs = new FileStream("book1.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			XmlSerializer xm = new XmlSerializer(typeof(List<Student>));
			xm.Serialize(fs, list);
			fs.Close();

			FileStream fs1 = new FileStream("book1.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
			List<Student> list2 = (List<Student>)xm.Deserialize(fs1);

			fs1.Close();
			foreach (Student s in list2)
			{
				Console.WriteLine( "hello"+s);
				Console.ReadKey();
			}

		}



	}



}

