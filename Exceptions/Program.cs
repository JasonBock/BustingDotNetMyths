using BenchmarkDotNet.Running;

namespace Exceptions
{
	public static class Program
	{
		public static void Main(string[] args) =>
			BenchmarkRunner.Run<ParseVsTryParse>();
	}
}
