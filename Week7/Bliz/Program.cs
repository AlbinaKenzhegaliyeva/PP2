using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Circlearound
{
	class Program
	{
		public static Object obj = new Object();
		static void Main(string[] args)
		{
			Thread[] th = new Thread[4];
			for (int i = 0; i < 4; i++)
			{
				Console.CursorVisible = false;
				th[0] = new Thread(Line1);
				th[0].Start();
				th[1] = new Thread(Line2);
				th[1].Start();
				th[2] = new Thread(Line3);
				th[2].Start();
				th[3] = new Thread(Line4);
				th[3].Start();
			}
		}
		public static void Line1()
		{
			lock (obj)
			{
				for (int i = 1; i < 71; i++)
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.SetCursorPosition(i, 1);
					Console.WriteLine("X");
					Thread.Sleep(100);
					Console.Clear();
				}
			}
		}
		public static void Line2()
		{
			lock (obj)
			{
				for (int i = 1; i < 41; i++)
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.SetCursorPosition(70, i);
					Console.WriteLine("X");
					Thread.Sleep(100);
					Console.Clear();
				}
			}
		}
		public static void Line3()
		{
			lock (obj)
			{
				for (int i = 70; i >= 0; i--)
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.SetCursorPosition(i, 40);
					Console.WriteLine("X");
					Thread.Sleep(100);
					Console.Clear();
				}
			}
		}
		public static void Line4()
		{
			lock (obj)
			{
				for (int i = 40; i >= 0; i--)
				{
					Console.ForegroundColor = ConsoleColor.White;
					Console.SetCursorPosition(1, i);
					Console.WriteLine("X");
					Thread.Sleep(100);
					Console.Clear();
				}
			}
		}
	}
} 

/*
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 

namespace Sample1
{
	[Serializable]
	public class Mark
	{
		public string signiture;
		public int score;
		public Mark(string signiture, int score)
		{
			this.signiture = signiture;
			this.score = score;
		}
		public Mark() { }
		public override string ToString()
		{
			return String.Format("{0} - {1}", signiture, score);
		}
	}
} */
/*
using System; 
using System.Collections.Generic; 
using System.IO; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using System.Xml.Serialization; 

namespace Sample1
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
}*/