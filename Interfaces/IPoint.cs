using System.Numerics;

namespace Interfaces;

public interface IPoint
{
   internal (double radius, double theta) GetPolarCoordinates() => 
		(double.Sqrt(this.X * this.X + this.Y * this.Y), double.Atan(this.Y / this.X));

   double X { get; init; }
	double Y { get; init; }
}