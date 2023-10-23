using BenchmarkDotNet.Running;
using Recursion;

//CollatzWithoutRecursion();
//CollatzWithRecursion();
//CollatzUsingTailCall();
//BenchmarkRunner.Run<RecursionPerformance>();

BenchmarkRunner.Run<RecursionPerformance>();

static void CollatzWithoutRecursion()
{
	var testSmall = new CollatzConjectureWithoutRecursion(
		Numbers.NumberThatIsSmall);
	Console.WriteLine($"Value: {testSmall.Value}{Environment.NewLine}Iterations: {testSmall.Iterations}");
	Console.WriteLine();

	var testLargeNumber = new CollatzConjectureWithoutRecursion(
		Numbers.NumberThatIsLargeButSafe);
	Console.WriteLine($"Value: {testLargeNumber.Value}{Environment.NewLine}Iterations: {testLargeNumber.Iterations}");
	Console.WriteLine();

	var testHugeNumber = new CollatzConjectureWithoutRecursion(
		Numbers.NumberThatWillAlwaysCauseStackOverflow);
	Console.WriteLine($"Value: {testHugeNumber.Value}{Environment.NewLine}Iterations: {testHugeNumber.Iterations}");
}

static void CollatzWithRecursion()
{
	var testSmall = new CollatzConjecture(
		Numbers.NumberThatIsSmall);
	Console.WriteLine($"Value: {testSmall.Value}{Environment.NewLine}Iterations: {testSmall.Iterations}");
	Console.WriteLine();

	var testLargeNumber = new CollatzConjecture(
		Numbers.NumberThatIsLargeButSafe);
	Console.WriteLine($"Value: {testLargeNumber.Value}{Environment.NewLine}Iterations: {testLargeNumber.Iterations}");
	Console.WriteLine();

	var testHugeNumber = new CollatzConjecture(
		Numbers.NumberThatWillAlwaysCauseStackOverflow);
	Console.WriteLine($"Value: {testHugeNumber.Value}{Environment.NewLine}Iterations: {testHugeNumber.Iterations}");
}

static void CollatzUsingTailCall()
{
	var testSmall = new CollatzConjectureUsingTailCall(
		Numbers.NumberThatIsSmall);
	Console.WriteLine($"Value: {testSmall.Value}{Environment.NewLine}Iterations: {testSmall.Iterations}");
	Console.WriteLine();

	var testLargeNumber = new CollatzConjectureUsingTailCall(
		Numbers.NumberThatIsLargeButSafe);
	Console.WriteLine($"Value: {testLargeNumber.Value}{Environment.NewLine}Iterations: {testLargeNumber.Iterations}");
	Console.WriteLine();

	var testHugeNumber = new CollatzConjectureUsingTailCall(
		Numbers.NumberThatWillAlwaysCauseStackOverflow);
	Console.WriteLine($"Value: {testHugeNumber.Value}{Environment.NewLine}Iterations: {testHugeNumber.Iterations}");
}
