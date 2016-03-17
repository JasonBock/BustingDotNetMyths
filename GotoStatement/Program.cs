using System;
using System.Collections;
using System.Collections.Generic;

namespace GotoStatement
{
	class Program
	{
		static void Main(string[] args)
		{
			Program.JumpAround();
		}

		private static void JumpAround()
		{
			goto firstLine;

			secondLine:
			Console.Out.WriteLine("Let me begin");

			goto thirdLine;

			firstLine:
			Console.Out.WriteLine("Pack it up, pack it in");

			goto secondLine;

			fourthLine:
			Console.Out.WriteLine("Battle me that's a sin");

			goto finish;

			thirdLine:
			Console.Out.WriteLine("I came to win");

			goto fourthLine;

			finish:
			return;
		}

		private static void JumpAroundGotoFree()
		{
			Console.Out.WriteLine("Pack it up, pack it in");
			Console.Out.WriteLine("Let me begin");
			Console.Out.WriteLine("I came to win");
			Console.Out.WriteLine("Battle me that's a sin");
		}

		private static void CheckArgument(string value)
		{
			if(value == null)
			{
				throw new ArgumentNullException(nameof(value));
			}
		}

		private static IEnumerable<string> ProduceLyrics()
		{
			yield return "Pack it up, pack it in";
			yield return "Let me begin";
			yield return "I came to win";
			yield return "Battle me that's a sin";
		}
	}
}
