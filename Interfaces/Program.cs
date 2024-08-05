using Interfaces;
using System.Globalization;

var point = new Point(3.2, 2.3);
Console.WriteLine($"Point: {point}");
Console.WriteLine($"Point.GetPolarCoordinates(): {((IPoint)point).GetPolarCoordinates()}");

var originPoint = new Point(0.0, 0.0);
Console.WriteLine($"Point at origin: {originPoint}");
Console.WriteLine($"Point.GetPolarCoordinates() at origin: {((IPoint)originPoint).GetPolarCoordinates()}");

Console.WriteLine();

var safePoint = new SafePoint(3.2, 2.3);
Console.WriteLine($"SafePoint: {safePoint}");
Console.WriteLine($"SafePoint.GetPolarCoordinates(): {safePoint.GetPolarCoordinates()}");

var safeOriginPoint = new SafePoint(0.0, 0.0);
Console.WriteLine($"SafePoint at origin: {safeOriginPoint}");

try
{
	safeOriginPoint.GetPolarCoordinates();
}
catch(NotSupportedException e)
{
	Console.WriteLine($"SafePoint.GetPolarCoordinates() at origin: {e.Message}");
}

Console.WriteLine();

var parsedSafePoint = SafePoint.Parse("5.5:10.66", CultureInfo.CurrentCulture);
Console.WriteLine($"Parsed SafePoint: {parsedSafePoint}");
Console.WriteLine($"Parsed SafePoint.GetPolarCoordinates(): {parsedSafePoint.GetPolarCoordinates()}");

Console.WriteLine();

Console.WriteLine($"safePoint + parsedSafePoint = {safePoint + parsedSafePoint}");