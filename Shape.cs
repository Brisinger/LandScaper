namespace Collections
{
	public abstract class Shape
	{
		public Shape(Dimension size)
		{
			Size = size;
		}
		public Dimension Size { get; set; }

		public abstract double CalcArea();

		public override string ToString()
		{
			return $"A shape with an area of {CalcArea()}";
		}


	}

}
