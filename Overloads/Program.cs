using Overloaded;
using System;
using System.Linq;

namespace Overloads
{
	class Program
	{
		static void Main(string[] args)
		{
			var generator = new ValueGenerator();

			var getValueIntMethod = typeof(ValueGenerator)
				.GetMethods()
				.Single(_ => _.Name == nameof(ValueGenerator.GetValue) &&
					_.ReturnType == typeof(int));

			var value = getValueIntMethod.Invoke(generator, null);
			Console.Out.WriteLine(
				$"{value}, type is {value.GetType().Name}");

			Program.CallItB(new object(), new object());
			Program.CallItA(new Program(), new Program());
		}

		// Can't do this:
		/*
		public int Run(int a) { return 0; }
		public Guid Run(int a) { return Guid.NewGuid(); }
		*/

		public void Run(int a) { }
		public void Run(Guid a) { }
		public void Run(int a, string b) { }

		public static void CallItA<T>(object o, T t)
		{
			Console.Out.WriteLine("object o, T t");
		}

		public static void CallItB<T>(T t, object o)
		{
			Console.Out.WriteLine("T t, object o");
		}
	}
}
