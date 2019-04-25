using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sereliz
{
	[Serializable]
	public class Movie
	{
		public string god;
		public int filmname;
		public Movie(string god, int filmname)
		{ 
			this.god = god;
			this.filmname = filmname;
		}
		public Movie() { }
		public override string ToString()
		{
			return String.Format("{0} - {1}", god, filmname);
		}
	}
}
