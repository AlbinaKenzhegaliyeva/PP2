using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace new2
{
	[Serializable]
	public class Person
	{
		public string name;
		public string age;
		public string film;
		public Person() { }
		

		public Person(string name, string age, string film)
		{
			this.name = name;
			this.age = age;
			this.film = film;
		}
		public override string ToString()
		{
			return String.Format("{0}, {1}, {2}", name, age, film);
		}

		class Program
	{
		static void Main(string[] args)
		{
				Movie firstMovie = new Movie("Emoji movie", 2017);
				Movie secondMovie = new Movie("50 shades of gray", 2015);
				Movie thirdMovie = new Movie("Shrek", 1999);
				Movie fourthMovie = new Movie("NinjaCop", 1987);

				Person akbar = new Person("Akbar", 29, secondMovie);
				Person ramesh = new Person("Ramesh", 20, firstMovie);
				Person durga = new Person("Durga", 43, fourthMovie);
				Person daler = new Person("Daler", 38, thirdMovie);
				List<Person> list = new List<Person>();
				list.Add(akbar);
				list.Add(ramesh);
				list.Add(durga);
				list.Add(daler);
				FileStream fs = new FileStream("book.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
				XmlSerializer xm = new XmlSerializer(typeof(List<Person>));
				xm.Serialize(fs, list);
				fs.Close();

				FileStream fs1 = new FileStream("book.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
				List<Person> list2 = (List<Person>)xm.Deserialize(fs1);
				fs1.Close();
				foreach (Person s in list2)
				{
					Console.WriteLine(s);
				}

			}
		}
	}

