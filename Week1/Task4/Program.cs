using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			int st = int.Parse(Console.ReadLine()); // converting line written by keyboard to integer
			int[,] star = new int[st, st]; // creating 2d array

			for (int i = 1; i <= st; i++)// обход строки

			{
				for (int j = 1; j <= i; j++) // обход ячеек в этой строке


					Console.Write("[*]");

				Console.WriteLine();
			}


		}
	}
}
