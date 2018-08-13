using BenchmarkDotNet.Attributes;
using System;

namespace Exceptions
{
	[MemoryDiagnoser]
	public class ParseVsTryParse
	{
		private const string BadValue = "7r83o4uf8ael";

		[Benchmark]
		public bool Parse()
		{
			try
			{
				int.Parse(ParseVsTryParse.BadValue);
				return true;
			}
			catch (FormatException)
			{
				return false;
			}
		}

		[Benchmark]
		public bool TryParse() =>
			int.TryParse(ParseVsTryParse.BadValue, out var result);
	}
}