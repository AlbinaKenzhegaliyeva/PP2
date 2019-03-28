using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sereliz
{
	[Serializable]
	public class Mark
	{
		public string signiture;
		public int score;
		public Mark(string signiture, int score)
		{
			this.signiture = signiture;
			this.score = score;
		}
		public Mark() { }
		public override string ToString()
		{
			return String.Format("{0} - {1}", signiture, score);
		}
	}
}
