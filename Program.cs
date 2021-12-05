using System;

namespace Collections
{
	class Program
	{
		static void Main(string[] args)
		{
			var myYard = new Landscape();
			Console.WriteLine(myYard.Add(new Circle(5), new Rectangle(10, 10)).CalcArea());
		}
	}
}
