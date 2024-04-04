using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GotosInRoslyn;

internal sealed class GotoWalker
	: CSharpSyntaxWalker
{
	public override void Visit(SyntaxNode? node)
	{
		var kind = node?.Kind() ?? SyntaxKind.None;

		if(kind != SyntaxKind.None)
		{
			if (kind == SyntaxKind.BreakStatement || kind == SyntaxKind.ContinueStatement ||
				kind == SyntaxKind.CheckedStatement || kind == SyntaxKind.DoStatement ||
				kind == SyntaxKind.EmptyStatement || kind == SyntaxKind.ExpressionStatement ||
				kind == SyntaxKind.FixedStatement || kind == SyntaxKind.ForEachStatement ||
				kind == SyntaxKind.ForEachVariableStatement || kind == SyntaxKind.ForStatement ||
				kind == SyntaxKind.GlobalStatement || kind == SyntaxKind.GotoCaseStatement ||
				kind == SyntaxKind.GotoDefaultStatement || kind == SyntaxKind.GotoStatement ||
				kind == SyntaxKind.IfStatement || kind == SyntaxKind.LabeledStatement ||
				kind == SyntaxKind.LocalDeclarationStatement || kind == SyntaxKind.LocalFunctionStatement ||
				kind == SyntaxKind.LockStatement || kind == SyntaxKind.ReturnStatement ||
				kind == SyntaxKind.SwitchStatement || kind == SyntaxKind.ThrowStatement ||
				kind == SyntaxKind.TryStatement || kind == SyntaxKind.UncheckedStatement ||
				kind == SyntaxKind.UnsafeStatement || kind == SyntaxKind.UsingStatement ||
				kind == SyntaxKind.WhileStatement || kind == SyntaxKind.YieldBreakStatement ||
				kind == SyntaxKind.YieldReturnStatement)
			{
				this.StatementCount++;
			}

			if (kind == SyntaxKind.GotoStatement)
			{
				this.GotoStatementCount++;
			}
			else if (kind == SyntaxKind.GotoCaseStatement)
			{
				this.GotoCaseStatementCount++;
			}
			else if (kind == SyntaxKind.GotoDefaultStatement)
			{
				this.GotoDefaultStatementCount++;
			}
		}

		base.Visit(node);
	}

	public int StatementCount { get; private set; }
	public int GotoStatementCount { get; private set; }
	public int GotoCaseStatementCount { get; private set; }
	public int GotoDefaultStatementCount { get; private set; }
}