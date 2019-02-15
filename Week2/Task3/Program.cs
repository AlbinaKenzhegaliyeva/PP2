using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
	class Program
	{
		static void Main(string[] args)
		{
			DirectoryInfo dir = new DirectoryInfo(@"C:\Users\User\Desktop\ICT"); // указываем path, чтобы получить информацию о папках
			PrintInfo(dir, 0);
			Console.ReadKey();

		}

		static void PrintInfo(FileSystemInfo fsi, int k) 
		{
			string s = new string(' ', k); // пробел
			Console.WriteLine(s + fsi.Name); // выводим название файлов 


			if (fsi.GetType() == typeof(DirectoryInfo)) //если папка
			{
				FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos(); 
				for (int i = 0; i < arr.Length; ++i) // пробегаемся по всему содержимому папки
				{
					PrintInfo(arr[i], k + 3); // отступ на 3 пробела, чтобы показать содержимое паки, т.е. файлы внутри папки сдвинутся
				}
				
			}
			
		} 
	}
}