using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CircleAround1
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 20;
			int y = 20;
			Console.SetCursorPosition(x, y);
			while (x != 40)
			{
				x++;
				Console.SetCursorPosition(x, y);
				Console.WriteLine("*");
				Thread.Sleep(100);
				Console.Clear();

			}
			if (x == 40)
			{
				while (y != 40)
				{
					y++;
					Console.SetCursorPosition(x, y);
					Console.WriteLine("*");
					Thread.Sleep(100);
					Console.Clear();
				}
			}
			if (y == 40)
			{
				while (x != 20)
				{
					x--;
					Console.SetCursorPosition(x, y);
					Console.WriteLine("*");
					Thread.Sleep(100);
					Console.Clear();
				}
			}
			if (x == 20)
			{
				while (y != 20)
				{
					y--;
					Console.SetCursorPosition(x, y);
					Console.WriteLine("*");
					Thread.Sleep(100);
					Console.Clear();
				}
			}
		}
	}
}
