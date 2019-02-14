using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			FileStream fs = new FileStream(@"C:\Users\User\Desktop\Source\Writesmth.txt", FileMode.Create, FileAccess.Write); // create new file
			StreamWriter sw = new StreamWriter(fs); // access to write

			sw.Write("Lol kek 4eburek"); //wite in sw some text
			sw.Close();
			fs.Close();

			string fileName = "Writesmth.txt"; // giving name to our file
			string sourcePath = @"C:\Users\User\Desktop\Source"; // first path
			string Path2 = @"C:\Users\User\Desktop\DestFile"; //second path
			string sourceFile = Path.Combine(sourcePath, fileName); //combines 2 stings into path
			string destFile = Path.Combine(Path2, fileName); // 
			File.Copy(sourceFile, destFile, true); // copy a file in another path or folder
			File.Delete(@"C:\Users\User\Desktop\Source\Writesmth.txt"); // delete the original one


		}
	}
}
