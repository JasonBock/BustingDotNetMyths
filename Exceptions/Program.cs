using BenchmarkDotNet.Running;

namespace Exceptions
{
	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkRunner.Run<ParseVsTryParse>();
		}
	}
}
