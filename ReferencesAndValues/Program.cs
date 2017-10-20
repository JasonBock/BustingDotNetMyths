using System;

namespace ReferencesAndValues
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			var referenceData1 = new ReferenceData(1);
			var referenceData2 = referenceData1;
			referenceData1.Increment();

			var valueData1 = new ValueData(1);
			var valueData2 = valueData1;
			valueData1.Increment();

			Console.Out.WriteLine($"{nameof(referenceData1)}: {referenceData1.Data}");
			Console.Out.WriteLine($"{nameof(referenceData2)}: {referenceData2.Data}");

			Console.Out.WriteLine($"{nameof(valueData1)}: {valueData1.Data}");
			Console.Out.WriteLine($"{nameof(valueData2)}: {valueData2.Data}");
		}
	}
}
