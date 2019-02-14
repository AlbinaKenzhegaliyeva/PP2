using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			FileStream fs = new FileStream(@"C:\programming2\pp.txt", FileMode.Open, FileAccess.Read); // creating filestream for a file with path to Open and Read
			StreamReader sr = new StreamReader(fs);//creating StreamReader that reads characters from a byte stream fs
			string str = sr.ReadLine();
			sr.Close();
			fs.Close();
			for (int i = 0; i < str.Length / 2; i++) //go through the array
			{
				if (str[i] != str[str.Length - i - 1]) // comparing the 1st and 
				{
					Console.WriteLine("No");
					break;
				} else
				{
					Console.WriteLine("Yes");
					break;
				}
			}

			Console.ReadKey();
		}
	}
	}






