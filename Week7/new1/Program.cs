using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ЦветКонсоли
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.CursorVisible = false;
				Thread green = new Thread(Green);
				green.Start();
				Thread.Sleep(1000);
				Thread red = new Thread(Red);
				red.Start();
				Thread.Sleep(1000);
				Thread blue = new Thread(Blue);
				blue.Start();
				Thread.Sleep(1000);
				Thread yellow = new Thread(Yellow);
				yellow.Start();
				Thread.Sleep(1000);
				Thread cyan = new Thread(Cyan);
				cyan.Start();
				Thread.Sleep(1000);
			}
		}
		public static void Green()
		{
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Green;
			Console.Clear();
			Console.SetCursorPosition(50, 13);
			Console.WriteLine("Go!");

		}

		public static void Red()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Red;
			Console.Clear();
			Console.SetCursorPosition(50, 13);
			Console.WriteLine("Good luck!");
		}
		public static void Blue()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.Clear();
			Console.SetCursorPosition(50, 13);
			Console.WriteLine("Hello World!!!!!");
		}
		public static void Yellow()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.Clear();
			Console.SetCursorPosition(50, 13);
			Console.WriteLine("Hello World!");
		}
		public static void Cyan()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.Clear();
			Console.SetCursorPosition(50, 13);
			Console.WriteLine("Hello World!!!!!");
		}
	}
}

