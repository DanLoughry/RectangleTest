using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RectangleTest
{
	[TestClass]
	public class RectangleTest1	{

		[TestMethod]
		public void PerimeterTest() {

			var r = new Rectangle(2, 4);
			Assert.AreEqual(12, r.GetPerimeter());

			var b = new Rectangle(8, 4);
			Assert.AreNotEqual(45, b.GetPerimeter());


		}

	}
}
