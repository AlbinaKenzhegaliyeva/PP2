using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			DirectoryInfo dir1 = new DirectoryInfo(@"C:\Intel"); // connect with C:\Intel
			PrintInfo(dir1, 0); // передаем в printinfo dir1
		}

		static void PrintInfo(FileSystemInfo fsi, int k) // с помощью функции принтинфо передаем инф о файлах
		{
			string s = new string(' ', k);
			Console.WriteLine(s + fsi.Name);

			if (fsi.GetType() == typeof(DirectoryInfo)) // если папка
			{
				FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos(); // создаем массив и "перекидываем" инф о папках
				for (int i = 0; i < arr.Length; ++i)
				{
					PrintInfo(arr[i], k + 3);
				}
			}
		}
	}
}
