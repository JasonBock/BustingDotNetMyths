using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CallStacks
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			Program.Method1();
			Program.GetCallingFrame();
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetCallingFrame()
		{
			var frame = new StackFrame(1);
			Console.Out.WriteLine(frame.GetMethod().Name);
		}

		private static void Method1() => Program.Method2();

		private static void Method2() => Program.Method3();

		private static void Method3() => Program.Method4();

		private static void Method4() { }
	}
}
