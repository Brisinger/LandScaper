namespace Collections
{
	public struct Dimension
	{
		public Dimension(uint width, uint height)
		{
			Width = width;
			Height = height;
		}
		public uint Width { get; set; }
		public uint Height { get; set; }
	}
}
