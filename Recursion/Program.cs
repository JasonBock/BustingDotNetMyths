using CollatzConjectureWithIL;
using System;

namespace Recursion
{
	public static class Program
	{
		static void Main(string[] args) =>
			//Program.CollatzWithoutRecursion();
			//Program.CollatzWithRecursion();
			Program.CollatzUsingTailCall();

		private static void CollatzWithoutRecursion()
		{
			var testSmall = new CollatzConjectureWithoutRecursion(
				Numbers.NumberThatIsSmall);
			Console.Out.WriteLine($"Value: {testSmall.Value}{Environment.NewLine}Iterations: {testSmall.Iterations}");
			Console.Out.WriteLine();

			var testLargeNumber = new CollatzConjectureWithoutRecursion(
				Numbers.NumberThatIsLargeButSafe);
			Console.Out.WriteLine($"Value: {testLargeNumber.Value}{Environment.NewLine}Iterations: {testLargeNumber.Iterations}");
			Console.Out.WriteLine();

			var testHugeNumber = new CollatzConjectureWithoutRecursion(
				Numbers.NumberThatWillAlwaysCauseStackOverflow);
			Console.Out.WriteLine($"Value: {testHugeNumber.Value}{Environment.NewLine}Iterations: {testHugeNumber.Iterations}");
		}

		private static void CollatzWithRecursion()
		{
			var testSmall = new CollatzConjecture(
				Numbers.NumberThatIsSmall);
			Console.Out.WriteLine($"Value: {testSmall.Value}{Environment.NewLine}Iterations: {testSmall.Iterations}");
			Console.Out.WriteLine();

			var testLargeNumber = new CollatzConjecture(
				Numbers.NumberThatIsLargeButSafe);
			Console.Out.WriteLine($"Value: {testLargeNumber.Value}{Environment.NewLine}Iterations: {testLargeNumber.Iterations}");
			Console.Out.WriteLine();

			var testHugeNumber = new CollatzConjecture(
				Numbers.NumberThatWillAlwaysCauseStackOverflow);
			Console.Out.WriteLine($"Value: {testHugeNumber.Value}{Environment.NewLine}Iterations: {testHugeNumber.Iterations}");
		}

		private static void CollatzUsingTailCall()
		{
			var testSmall = new CollatzConjectureUsingTailCall(
				Numbers.NumberThatIsSmall);
			Console.Out.WriteLine($"Value: {testSmall.Value}{Environment.NewLine}Iterations: {testSmall.Iterations}");
			Console.Out.WriteLine();

			var testLargeNumber = new CollatzConjectureUsingTailCall(
				Numbers.NumberThatIsLargeButSafe);
			Console.Out.WriteLine($"Value: {testLargeNumber.Value}{Environment.NewLine}Iterations: {testLargeNumber.Iterations}");
			Console.Out.WriteLine();

			var testHugeNumber = new CollatzConjectureUsingTailCall(
				Numbers.NumberThatWillAlwaysCauseStackOverflow);
			Console.Out.WriteLine($"Value: {testHugeNumber.Value}{Environment.NewLine}Iterations: {testHugeNumber.Iterations}");
		}
	}
}
