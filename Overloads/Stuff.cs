using System;

namespace Overloads
{
	public sealed class Stuff
	{
		// Can't do this:
		/*
		public int Run(int a) { return 0; }
		public Guid Run(int a) { return Guid.NewGuid(); }
		*/

		public void Run(int a) { }
		public void Run(Guid a) { }
		public void Run(int a, string b) { }
	}
}
