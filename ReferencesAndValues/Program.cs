using ReferencesAndValues;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

var referenceData1 = new ReferenceData(1);
var referenceData2 = referenceData1;
referenceData1.Increment();

var valueData1 = new ValueData(1);
var valueData2 = valueData1;
valueData1.Increment();

Console.WriteLine($"{nameof(referenceData1)}: {referenceData1.Data}");
Console.WriteLine($"{nameof(referenceData2)}: {referenceData2.Data}");

Console.WriteLine($"{nameof(valueData1)}: {valueData1.Data}");
Console.WriteLine($"{nameof(valueData2)}: {valueData2.Data}");

Console.WriteLine();

unsafe
{
	var referenceDataTypeHandleValue = typeof(ReferenceData).TypeHandle.Value;
	var referenceDataSize = Marshal.ReadInt32(referenceDataTypeHandleValue, 4);
	Console.WriteLine($"Handle size is {referenceDataSize}");

	var referenceDataMemory = stackalloc byte[referenceDataSize];
	*(IntPtr*)referenceDataMemory = referenceDataTypeHandleValue;
	var referenceOnStack = Unsafe.AsRef<ReferenceData>(referenceDataMemory);
	Console.WriteLine(referenceOnStack.Data);
}