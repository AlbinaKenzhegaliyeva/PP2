
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7
{
	class Program
	{
		static void Main(string[] args)
		{
			int num = 1;

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(num);
				Thread.Sleep(1000);
				num++;
			}
			Console.WriteLine("Thread ends");
			Console.ReadLine();
		}
	}
}
