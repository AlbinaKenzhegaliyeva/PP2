﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{

		static bool IsPrime(int x) // creating bool
		{
			if (x == 1) return false; 
			if (x == 2) return true;

			bool functionResult = true;

			for (int i = 2; i < x; ++i)
			{
				if (x % i == 0)
				{
					functionResult = false;
					break;
				}
			}
			return functionResult;
		}

		static bool IsPrimeString(string s)
		{
			return IsPrime(int.Parse(s));
		}

		static void Main(string[] args)
		{

			List<string> res = new List<string>();

			FileStream fs = new FileStream(@"C:\Users\User\Desktop\PP2\blok\input.txt", FileMode.Open, FileAccess.Read); // creating filestream for a file with path to Open and Read
			StreamReader sr = new StreamReader(fs); // reading the Stream to know where fs is indicates 

			string line = sr.ReadLine(); 
			string[] nums = line.Split(' '); 

			foreach (var x in nums) 
			{
				if (IsPrimeString(x))
				{
					res.Add(x);
				}
			}

			sr.Close();
			fs.Close();



			FileStream fs2 = new FileStream(@"C:\Users\User\Desktop\PP2\blok\output.txt", FileMode.Create, FileAccess.Write); 
			StreamWriter sw = new StreamWriter(fs2); 

			foreach (var x in res) 
			{
				sw.Write(x + " ");
				Console.Write(x + " "); 
			}

			sw.Close(); 
			fs2.Close();
		}
	}
}