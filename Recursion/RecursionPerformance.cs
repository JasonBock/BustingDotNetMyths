﻿using BenchmarkDotNet.Attributes;
using System.Numerics;

namespace Recursion;

[MemoryDiagnoser]
public class RecursionPerformance
{
	[Benchmark]
	public BigInteger CollatzWithoutRecursion() =>
		new CollatzConjectureWithoutRecursion(Numbers.NumberThatIsLargeButSafe).Value;

	[Benchmark]
	public BigInteger CollatzWithRecursion() =>
		new CollatzConjecture(Numbers.NumberThatIsLargeButSafe).Value;
}
