using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
	public class Calc
	{
		public double first;
		public double second;
		public bool sec;
		public bool complete;
		public int entermod;
		public double result;
		public string operationmono;
		public string operationbi;
		public string error;

		public Calc()
		{
			first = 0;
			second = 0;
			sec = false;
			complete = false;
			result = 0;
			operationmono = "";
			operationbi = "";
			error = "";
			entermod = 1;
		}

		int fact(int x)
		{
			if (x != 0) return x * fact(x - 1);
			else return 1;
		}
		public double Fibonacci(double n)
		{
			if (n == 0)
				return 0;
			if (n == 1)
				return 1;
			return Fibonacci(n - 1) + Fibonacci(n - 2);
		}

		public void Mono(string operation)
		{
			double k;
			if (entermod == 1) k = first;
			else k = second;
			switch (operation)
			{
				case "x!":
					if (k < 0) error = "It is impossible";
					else
					{
						if (Math.Round(k) != k)
							result = Math.Sqrt(2 * Math.PI * first) * Math.Pow(first / Math.E, first);
						else result = (double)(fact((int)(k)));
					}
					break;
				case "x^2":
					result = k * k;
					break;
				case "10^x":
					result = Math.Pow(10, k);
					break;
				case "e^x":
					result = Math.Exp(k);
					break;
				case "sqrt":
					if (k >= 0) result = Math.Sqrt(k);
					else error = "It is impossible";
					break;
				case "lnx":
					if (k > 0) result = Math.Log(k);
					else error = "It is impossible";
					break;
				case "1/x":
					if (k != 0) result = 1 / k;
					else error = "It is impossible";
					break;
				case "sinx":
					result = Math.Sin(k * Math.PI / 180);
					break;
				case "cosx":
					result = Math.Cos(k * Math.PI / 180);
					break;
				case "tanx":
					if (Math.Cos(k * Math.PI / 180) != 0)
						result = Math.Tan(k * Math.PI / 180);
					else error = "It is impossible";
					break;
				case "cotx":
					if (Math.Tan(k * Math.PI / 180) != 0)
						result = 1 / Math.Tan(k * Math.PI / 180);
					else error = "It is impossible";
					break;

				case "binary":
					string s = ((Convert.ToString((int)first, 2)));
					result = int.Parse(s);
					break;

			}
			if (entermod == 1) first = result;
			else second = result;
		}
		private double gcd(double n, double m)
		{
			while (m != n)
			{
				if (m > n)
					m = m - n;
				else
					n = n - m;
			}
			return m;
		}
		private double lcm(double n, double m)
		{
			return m * n / gcd(m, n);
		}
		private bool isPalindrome(double n)
		{
			string s = n.ToString();
			for (int i = 0; i < s.Length - 1; i++)
			{
				if (s[i] != s[s.Length - 1 - i])
				{
					return false;
				}
			}
			return true;
		}
		private bool isPrime(double n)
		{
			if (n == 1) return false;
			for (int i = 2; i < Math.Sqrt(n); i++)
			{
				if (n % i == 0) return false;
			}
			return true;
		}
		public void Bi(string operation)
		{
			switch (operation)
			{
				case "+":
					result = first + second;
					break;
				case "-":
					result = first - second;
					break;
				case "х":
					result = first * second;
					break;
				case "÷":
					if (second != 0) result = first / second;
					else error = "It is impossible";
					break;
				case "%":
					result = first * second / 100;
					break;
				case "mod":
					result = first % second;
					break;
				case "x^y":
					result = Math.Pow(first, second);
					break;
				case "sqrt^x":
					if (first % 2 == 0 && second < 0) error = "It is impossible";
					else result = Math.Pow(second, 1 / first);
					break;
				case "logxy":
					result = Math.Log10(second) / Math.Log10(first);
					break;
				case "XOR":
					result = ((int)first ^ (int)second);

					break;
				case "gcd":
					result = gcd(first, second);
					break;
				case "lcm":
					result = lcm(first, second);
					break;
				case "Palin":
					if (isPalindrome(first))
					{
						result = 1;
					}
					else result = 0;
					break;
				case "Prime":
					if (isPrime(first))
					{
						result = 1;
					}
					else result = 0;
					break;
				case "Fibonacci":
					result = Fibonacci(first);
					break;
			}

		}
	}
}