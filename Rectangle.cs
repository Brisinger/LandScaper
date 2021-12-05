namespace Collections
{
	public class Rectangle : Shape
	{
		public Rectangle(uint width, uint height)
			: base(new Dimension(width, height)) { }

		public override double CalcArea()
		{
			return Size.Width * Size.Height;
		}

		public override string ToString()
		{
			return $"A rectangle with an area of {CalcArea()}";
		}
	}
}

