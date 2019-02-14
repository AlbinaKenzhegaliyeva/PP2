using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{

	class Program
	{
		public static bool Prime(int num) //making the method for checking prime num-s
		{
			bool Isprime = false; // making boolean parameter, which is false
			if (num == 1) // checking one of the case
			{
				Isprime = true;
			}
			else
			{
				for (int i = 2; i < num; i++) // consider the divisors of the number
				{
					if (num % i == 0)
					{
						Isprime = true;
						break; // we need the numbers without dividors
					}
				}
			}
			return Isprime;
		}
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine()); // creating variable to int 
			string s = Console.ReadLine(); // write numbers to string
			string[] array = s.Split(); // creating a new array and divide the numbers by parts
			int cnt = 0; // new variable
			for (int i = 0; i < n; i++)
			{
				int num = int.Parse(array[i]); // remaking the numbers in array to the int
				if (Prime(num) == false || num == 2) // check the method
				{
					cnt++; // count elements which are prime
				}
			}
			Console.WriteLine(cnt); // show num-s on console
			for (int i = 0; i < n; i++)
			{
				int num = int.Parse(array[i]); // remaking the numbers in array to the int
				if (Prime(num) == false || num == 2) // show number on console with using if
				{
					Console.Write(num + " "); // show numbers

				}
			}

			Console.ReadKey();
		}
	}
}
