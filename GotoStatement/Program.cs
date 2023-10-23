JumpAround();
//JumpAroundGotoFree();

static void JumpAround()
{
	goto firstLine;

secondLine:
	Console.WriteLine("Let me begin");

	goto thirdLine;

firstLine:
	Console.WriteLine("Pack it up, pack it in");

	goto secondLine;

fourthLine:
	Console.WriteLine("Battle me that's a sin");

	goto finish;

thirdLine:
	Console.WriteLine("I came to win");

	goto fourthLine;

finish:
	return;
}

static void JumpAroundGotoFree()
{
	Console.WriteLine("Pack it up, pack it in");
	Console.WriteLine("Let me begin");
	Console.WriteLine("I came to win");
	Console.WriteLine("Battle me that's a sin");
}

static IEnumerable<string> ProduceLyrics()
{
	yield return "Pack it up, pack it in";
	yield return "Let me begin";
	yield return "I came to win";
	yield return "Battle me that's a sin";
}