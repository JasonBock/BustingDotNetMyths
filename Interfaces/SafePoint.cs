using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace Interfaces;

public sealed class SafePoint
	: IPoint, IParsable<SafePoint>, IAdditionOperators<SafePoint, SafePoint, SafePoint>
{
	public SafePoint(double x, double y) =>
		(this.X, this.Y) = (x, y);

	internal (double radius, double theta) GetPolarCoordinates()
	{
		if (this.X != 0.0)
		{
			return (double.Sqrt(this.X * this.X + this.Y * this.Y), double.Atan(this.Y / this.X));
		}
		else
		{
			throw new NotSupportedException("X cannot be equal to 0");
		}
	}

	public override string ToString() => $"{this.X}:{this.Y}";

	public static SafePoint operator +(SafePoint left, SafePoint right)
	{
		ArgumentNullException.ThrowIfNull(left);
		ArgumentNullException.ThrowIfNull(right);
		return new(left.X + right.X, left.Y + right.Y);
	}

	public static SafePoint Add(SafePoint left, SafePoint right) =>
		left + right;

	public static SafePoint Parse(string s, IFormatProvider? provider)
	{
		if (SafePoint.TryParse(s, provider, out var result))
		{
			return result;
		}

		throw new NotSupportedException();
	}

	public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out SafePoint result)
	{
		if (s is not null)
		{
			var parts = s.Split(':');

			if (parts.Length == 2 && double.TryParse(parts[0], out var x) &&
				double.TryParse(parts[1], out var y))
			{
				result = new SafePoint(x, y);
				return true;
			}
		}

		result = null;
		return false;
	}

	public double X { get; init; }
	public double Y { get; init; }
}
