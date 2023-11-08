namespace Interfaces;

public sealed class Point
	: IPoint
{
	public Point(double x, double y) =>
		(this.X, this.Y) = (x, y);

	public override string ToString() => $"{this.X}:{this.Y}";

   public double X { get; init; }
   public double Y { get; init; }
}