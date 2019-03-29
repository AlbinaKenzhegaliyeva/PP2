using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6
{
	class Food: GameObject
	{
		public Food(char sign): base(sign)
		{
			body.Add(new Point { X = 30, Y = 20 });

		}
	}
}
