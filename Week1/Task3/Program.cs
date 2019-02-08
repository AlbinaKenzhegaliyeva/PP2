using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			string line1 = Console.ReadLine(); // creating 2 lines
			string line2 = Console.ReadLine();
			int n = int.Parse(line1); // by Parse convert string (line1)into int n
			string[] parts = line2.Split(' ');// creating an array ; each element is divided by backspace

			for (int i = 0; i < n; ++i)
			{
				Console.Write(parts[i] + " " + parts[i]);
				Console.Write(" ");
			}

		}
	}
}
