using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace traffic
{
	class Program
	{
		static void Main(string[] args)
		{


			Console.CursorVisible = false;
			Console.SetCursorPosition(0, 1);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Stop");
			Console.WriteLine("*");
			Thread.Sleep(1000);
			Console.Clear();
			Console.SetCursorPosition(0, 2);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Get Ready");
			Console.WriteLine("*");
			Thread.Sleep(1000);
			Console.Clear();
			Console.SetCursorPosition(0, 3);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("Run");
			Console.WriteLine("*");
			Console.ReadKey();

		}
	}
}