#pragma warning disable IDE0007 // Use implicit type
int xExplicit = 41;
#pragma warning restore IDE0007 // Use implicit type
Console.WriteLine(xExplicit.GetType().FullName);
var xInferred = 44;
Console.WriteLine(xInferred.GetType().FullName);

//Dictionary<int, string> pairsExplicit =
//	new Dictionary<int, string> { { 22, "data" } };
//Console.WriteLine(pairsExplicit[22]);
//var pairsInferred =
//	new Dictionary<int, string> { { 22, "data" } };
//Console.WriteLine(pairsInferred[22]);

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