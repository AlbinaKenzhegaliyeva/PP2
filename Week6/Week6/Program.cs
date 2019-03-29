using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
	class Program
	{
		static void Main(string[] args)
		{
			GameState gameState = new GameState();

			while (true)
			{
				gameState.Draw();
 

				

				ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

				gameState.ProcessKey(consoleKeyInfo);
			}

		}
	}
}
