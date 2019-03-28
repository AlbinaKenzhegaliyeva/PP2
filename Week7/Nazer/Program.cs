using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImportantTrafficLight
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			Thread threadGreen = new Thread(Green);
			threadGreen.Start();

			Console.ForegroundColor = ConsoleColor.Black;
			Thread.Sleep(1000);
			Thread threadYellow = new Thread(Yellow);
			threadYellow.Start();

			Console.ForegroundColor = ConsoleColor.Black;
			Thread.Sleep(1000);
			Thread threadRed = new Thread(Red);
			threadRed.Start();

			Console.Read();
		}

		public static void Green()
		{
			Console.Clear();
			Console.SetCursorPosition(0, 0);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("*");
			Console.WriteLine("GO");
		}
		public static void Yellow()
		{
			Console.Clear();
			Console.SetCursorPosition(0, 3);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("*");
			Console.WriteLine("BE READY");

		}
		public static void Red()
		{
			Console.Clear();
			Console.SetCursorPosition(0, 5);
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("*");
			Console.WriteLine("STOP");
		}
	}
}

