using GotosInRoslyn;
using Microsoft.CodeAnalysis.CSharp;

var statementCount = 0;
var gotoStatementCount = 0;
var gotoCaseStatementCount = 0;
var gotoDefaultStatementCount = 0;

// Set directory to the location that contains the Roslyn repo
var directory = new DirectoryInfo(@"C:\Users\jason\source\repos\dotnet\roslyn");

foreach (var file in directory.EnumerateFiles("*.cs", SearchOption.AllDirectories))
{
	Console.WriteLine($"Analyzing {file.FullName}...");

	var tree = CSharpSyntaxTree.ParseText(File.ReadAllText(file.FullName));
	var walker = new GotoWalker();
	walker.Visit(tree.GetRoot());

	statementCount += walker.StatementCount;
	gotoStatementCount += walker.GotoStatementCount;
	gotoCaseStatementCount += walker.GotoCaseStatementCount;
	gotoDefaultStatementCount += walker.GotoDefaultStatementCount;
}

Console.WriteLine();
Console.WriteLine($"Total statement count: {statementCount}");
Console.WriteLine($"Total goto statement count: {gotoStatementCount}");
Console.WriteLine($"Total goto case statement count: {gotoCaseStatementCount}");
Console.WriteLine($"Total goto default statement count: {gotoDefaultStatementCount}");