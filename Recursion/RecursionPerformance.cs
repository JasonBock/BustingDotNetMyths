using BenchmarkDotNet.Attributes;
using CollatzConjectureWithIL;
using System.Numerics;

namespace Recursion
{
	public class RecursionPerformance
	{
		[Benchmark]
		public BigInteger CollatzWithoutRecursion() =>
			new CollatzConjectureWithoutRecursion(Numbers.NumberThatIsLargeButSafe).Value;

		[Benchmark]
		public BigInteger CollatzWithRecursion() =>
			new CollatzConjecture(Numbers.NumberThatIsLargeButSafe).Value;

		[Benchmark]
		public BigInteger CollatzUsingTailCall() =>
			new CollatzConjectureUsingTailCall(Numbers.NumberThatIsLargeButSafe).Value;
	}
}
