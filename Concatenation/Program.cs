using BenchmarkDotNet.Running;

namespace Concatenation
{
	class Program
	{
		static void Main(string[] args) =>
			BenchmarkRunner.Run<Concatenation30Parts>();
	}
}
