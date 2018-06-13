using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleTest
{
	public class Rectangle	{

		public int side1 { get; set; }
		public int side2 { get; set; }
		

		public Rectangle(int length, int width) {
			side1 = length;
			side2 = width;
			
		}
		public int GetPerimeter()		{
			return 2 * (side1 + side2);
		}

		public int GetArea()		{
			return side1 * side2;
		}
		public Rectangle() { }

		


		

	}
}
