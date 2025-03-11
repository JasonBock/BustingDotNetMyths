using Spackle;

namespace Concatenation;

internal static class StringCreation
{
	internal static string Create(int length)
	{
		var random = new SecureRandom();
		var data = new char[length];

		for (var i = 0; i < length; i++)
		{
			data[i] = (char)random.Next(32, 127);
		}

		return new string(data);
	}
}