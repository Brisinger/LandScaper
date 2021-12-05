using System.Collections.Generic;

namespace Collections
{
	public class Landscape
	{
		private IList<Shape> shapes = new List<Shape>();

		public Landscape()
		{ }

		public Landscape Add(params Shape[] shapes)
		{
			foreach (var s in shapes) this.shapes.Add(s);
			return this;
		}

		public IEnumerable<Shape> Shapes {get {return shapes;} }

		public double CalcArea()
		{
			double total = 0;
			foreach (var s in shapes) total += s.CalcArea();
			return total;
		}

	}
}
