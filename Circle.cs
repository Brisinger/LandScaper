using System;

namespace Collections
{
	public class Circle : Shape
	{


		public Circle(uint radius) : base(new Dimension(radius * 2, radius * 2)) { }

		public override double CalcArea()
		{
			return Math.PI * (Size.Width / 2) * (Size.Width / 2);
		}

		public override string ToString()
		{
			return $"A circle with an area of {CalcArea()}";
		}



	}

}
