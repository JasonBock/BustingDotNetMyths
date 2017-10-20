using System;
using System.Collections.Generic;

namespace Inference
{
	public static class Program
	{
		public static void Main(string[] args)
		{
#pragma warning disable IDE0007 // Use implicit type
			int xExplicit = 41;
#pragma warning restore IDE0007 // Use implicit type
			Console.Out.WriteLine(xExplicit.GetType().FullName);
			var xInferred = 44;
			Console.Out.WriteLine(xInferred.GetType().FullName);

			//Dictionary<int, string> pairsExplicit =
			//	new Dictionary<int, string> { { 22, "data" } };
			//Console.Out.WriteLine(pairsExplicit[22]);
			//var pairsInferred =
			//	new Dictionary<int, string> { { 22, "data" } };
			//Console.Out.WriteLine(pairsInferred[22]);

			//var varBase = xExplicit % 2 == 0 ?
			//	new ABase() as IBase : new BBase();
			//varBase.DoSomething();

			//IBase varBaseViaIf = null;

			//if (xExplicit % 2 == 0)
			//{
			//	varBaseViaIf = new ABase();
			//}
			//else
			//{
			//	varBaseViaIf = new BBase();
			//}

			//varBaseViaIf.DoSomething();

			//object objectBase = xExplicit % 2 == 0 ?
			//	new ABase() as IBase : new BBase();
			//objectBase.DoSomething();

			//dynamic dynamicBase = xExplicit % 2 == 0 ?
			//	new ABase() as IBase : new BBase();
			//dynamicBase.DoSomething();
			//dynamicBase.


		}
	}

	public interface IBase
	{
		void DoSomething();
	}

	public class ABase : IBase
	{
		public void DoSomething() { }
	}

	public class BBase : IBase
	{
		public void DoSomething() { }
	}
}
