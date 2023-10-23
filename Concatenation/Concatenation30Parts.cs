using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Text;

namespace Concatenation;

[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.Net481), SimpleJob(RuntimeMoniker.Net70)]
public class Concatenation30Parts
{
	private static readonly string dataOf5Length = StringCreation.Create(5);
	private static readonly string dataOf25Length = StringCreation.Create(25);
	private static readonly string dataOf200Length = StringCreation.Create(200);

	[Benchmark(Baseline = true)]
	public int ConcatenateWithAddition() =>
		(Concatenation30Parts.dataOf5Length + " and " +
		Concatenation30Parts.dataOf200Length + " and " +
		Concatenation30Parts.dataOf25Length + " and " +
		Concatenation30Parts.dataOf5Length + " and " +
		Concatenation30Parts.dataOf200Length + " and " +
		Concatenation30Parts.dataOf25Length + " and " +
		Concatenation30Parts.dataOf5Length + " and " +
		Concatenation30Parts.dataOf200Length + " and " +
		Concatenation30Parts.dataOf25Length + " and " +
		Concatenation30Parts.dataOf5Length + " and " +
		Concatenation30Parts.dataOf200Length + " and " +
		Concatenation30Parts.dataOf25Length + " and " +
		Concatenation30Parts.dataOf5Length + " and " +
		Concatenation30Parts.dataOf200Length + " and " +
		Concatenation30Parts.dataOf25Length + " and " +
		Concatenation30Parts.dataOf5Length + " and " +
		Concatenation30Parts.dataOf200Length + " and " +
		Concatenation30Parts.dataOf25Length + " and " +
		Concatenation30Parts.dataOf5Length + " and " +
		Concatenation30Parts.dataOf200Length + " and " +
		Concatenation30Parts.dataOf25Length + " and " +
		Concatenation30Parts.dataOf5Length + " and " +
		Concatenation30Parts.dataOf200Length + " and " +
		Concatenation30Parts.dataOf25Length + " and " +
		Concatenation30Parts.dataOf5Length + " and " +
		Concatenation30Parts.dataOf200Length + " and " +
		Concatenation30Parts.dataOf25Length + " and " +
		Concatenation30Parts.dataOf5Length + " and " +
		Concatenation30Parts.dataOf200Length + " and " +
		Concatenation30Parts.dataOf25Length).Length;

	[Benchmark]
	public int ConcatenateWithStringBuilder()
	{
		var builder = new StringBuilder();
		builder.Append(Concatenation30Parts.dataOf5Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf200Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf25Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf5Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf200Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf25Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf5Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf200Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf25Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf5Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf200Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf25Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf5Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf200Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf25Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf5Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf200Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf25Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf5Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf200Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf25Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf5Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf200Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf25Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf5Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf200Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf25Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf5Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf200Length);
		builder.Append(" and ");
		builder.Append(Concatenation30Parts.dataOf25Length);

		return builder.ToString().Length;
	}

	[Benchmark]
	public int ConcatenateWithInterpolation() =>
		$"{Concatenation30Parts.dataOf5Length} and {Concatenation30Parts.dataOf200Length} and {Concatenation30Parts.dataOf25Length} and {Concatenation30Parts.dataOf5Length} and {Concatenation30Parts.dataOf200Length} and {Concatenation30Parts.dataOf25Length} and {Concatenation30Parts.dataOf5Length} and {Concatenation30Parts.dataOf200Length} and {Concatenation30Parts.dataOf25Length} and {Concatenation30Parts.dataOf5Length} and {Concatenation30Parts.dataOf200Length} and {Concatenation30Parts.dataOf25Length} and {Concatenation30Parts.dataOf5Length} and {Concatenation30Parts.dataOf200Length} and {Concatenation30Parts.dataOf25Length} and {Concatenation30Parts.dataOf5Length} and {Concatenation30Parts.dataOf200Length} and {Concatenation30Parts.dataOf25Length} and {Concatenation30Parts.dataOf5Length} and {Concatenation30Parts.dataOf200Length} and {Concatenation30Parts.dataOf25Length} and {Concatenation30Parts.dataOf5Length} and {Concatenation30Parts.dataOf200Length} and {Concatenation30Parts.dataOf25Length} and {Concatenation30Parts.dataOf5Length} and {Concatenation30Parts.dataOf200Length} and {Concatenation30Parts.dataOf25Length} and {Concatenation30Parts.dataOf5Length} and {Concatenation30Parts.dataOf200Length} and {Concatenation30Parts.dataOf25Length}".Length;
}
