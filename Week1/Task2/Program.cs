using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Student
	{
		public string name;
		public string id;
		public int year = 0;
		public Student(string n, string g) // creating two parameters(передаем параметры)
		{
			name = n; // give names for our two parameters
			id = g;
		}
		public void Inc() // creating a constructor
		{
			year++;// increment our year of study
			Console.WriteLine("Year of study :" + year);
		}
		public void PrintInfo()
		{
			Console.WriteLine(name + " " + id + " ");

		}
		static void Main(string[] args)
		{
			Student s = new Student("Kenzhegaliyeva", "18BD12067"); // method
			s.PrintInfo(); 
			s.Inc();
			Console.ReadLine();
		}



	}
}

