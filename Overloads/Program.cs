using Overloaded;
using Overloads;

var generator = new ValueGenerator();
var getValueIntMethod = typeof(ValueGenerator)
	.GetMethods()
	.Single(_ => _.Name == nameof(ValueGenerator.GetValue) &&
		_.ReturnType == typeof(int));

var value = getValueIntMethod.Invoke(generator, null)!;
Console.WriteLine(
	$"{value}, type is {value.GetType().Name}");

CallItB(new object(), new object());
CallItA(new Stuff(), new Stuff());

static void CallItA<T>(object o, T t) =>
	Console.WriteLine("object o, T t");

static void CallItB<T>(T t, object o) =>
	Console.WriteLine("T t, object o");