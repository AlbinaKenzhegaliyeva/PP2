using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class FarManager // создаём класс 
	{
		public int kursor;
		public string path;
		public int size;
		DirectoryInfo directory = null;
		FileSystemInfo currentFs = null;

		public FarManager() // конструктор
		{
			kursor = 0; // указывает на нулевой индекс
		}

		public FarManager(string path) // создаём конструктор и передаем наш путь
		{
			this.path = path;
			kursor = 0;
			directory = new DirectoryInfo(path);
			size = directory.GetFileSystemInfos().Length; //внутри size сохранили все папки и файлы
			
		}

		public void Color(FileSystemInfo fs, int placeofkur) // создаём функцию, где передаем индекс курсора
		{
			if (kursor == placeofkur)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.ForegroundColor = ConsoleColor.White;
				currentFs = fs;
			}
			else if (fs.GetType() == typeof(DirectoryInfo)) // проверяем является ли экземпляр директорием 
			{
				Console.BackgroundColor = ConsoleColor.Black; //цвет
				Console.ForegroundColor = ConsoleColor.White;
			}
			else // случай, когда имеем дело с файлсистеминфо
			{
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.Yellow;
			}
		}

		public void Show() // создаём функцию
		{
			Console.BackgroundColor = ConsoleColor.Black; // закрашиваем в черный
			Console.Clear();
			directory = new DirectoryInfo(path);
			FileSystemInfo[] fs = directory.GetFileSystemInfos(); // с помощью гетфайлсистеминфо получаем все файлы и директории
			for (int i = 0; i < fs.Length; i++) // пробегаемся по всем файлам и папкам
			{
				Color(fs[i], i); // i элемент передаем в калор
				Console.WriteLine(i+1+ "."+fs[i].Name);
			}
		}

		public void Up() // управление курсорами 
		{
			kursor--;
			if (kursor < 0)
				kursor = size - 1; // уходит вниз если ушел наверх (-1)
		}
		public void Down()
		{
			kursor++;
			if (kursor == size)
				kursor = 0; // уходит наверх 
		}

		public void Start() 
		{
			ConsoleKeyInfo consoleKey = Console.ReadKey();
			while (consoleKey.Key != ConsoleKey.Escape) // пока esc не нажмется while будет повторяться 
			{
				
				Show(); // показываем, что нах-ся в папке
				consoleKey = Console.ReadKey();
				if (consoleKey.Key == ConsoleKey.UpArrow)
					Up();
				if (consoleKey.Key == ConsoleKey.DownArrow)
					Down();

				if (consoleKey.Key == ConsoleKey.Enter)
				{
					if (currentFs.GetType() == typeof(DirectoryInfo))// выбираем папку
					{
						kursor = 0; // при нажатии enter курсор =0
						path = currentFs.FullName; // полный путь этого файла
					}
					else
					{
						FileStream fs = new FileStream(currentFs.FullName, FileMode.Open, FileAccess.Read);
						StreamReader sr = new StreamReader(fs);

						Console.BackgroundColor = ConsoleColor.White;
						Console.ForegroundColor = ConsoleColor.Black;
						Console.Clear();

						Console.WriteLine(sr.ReadToEnd());
						Console.ReadKey();

					}
				}
				if (consoleKey.Key==ConsoleKey.Delete) // удалить
				{
					if (currentFs.GetType()== typeof(DirectoryInfo))
					{
						Directory.Delete(currentFs.FullName, true); // удаление папки
					}
					else
					{
						File.Delete(currentFs.FullName);// удаление файла
					}
				}
				if (consoleKey.Key == ConsoleKey.LeftArrow)
				{
					File.Move(currentFs.FullName, Console.ReadLine());
				}
				if (consoleKey.Key == ConsoleKey.Backspace)
				{
					kursor = 0;
					path = directory.Parent.FullName; // возвращаемся в изначальный путь назад
				}
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			string path = (@"C:\Users\User\Desktop\Programming");
			FarManager farManager = new FarManager(path); // передаём путь в FarManager
			farManager.Start();
		}
	}
}
