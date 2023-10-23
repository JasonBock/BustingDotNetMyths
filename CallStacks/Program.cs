using System.Diagnostics;
using System.Runtime.CompilerServices;

Method1();
GetCallingFrame();

[MethodImpl(MethodImplOptions.AggressiveInlining)]
static void GetCallingFrame()
{
	var frame = new StackFrame(1);
	Console.WriteLine(frame.GetMethod()!.Name);
}

static void Method1() => Method2();

static void Method2() => Method3();

static void Method3() => Method4();

static void Method4() { }