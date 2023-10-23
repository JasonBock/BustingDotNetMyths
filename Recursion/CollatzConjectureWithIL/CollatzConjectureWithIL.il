// To compile: ilasm CollatzConjectureWithIL.il /dll /debug

.assembly extern System.Runtime
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )
  .ver 7:0:0:0
}

.assembly CollatzConjectureWithIL
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                                   63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [System.Runtime]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [System.Runtime]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [System.Runtime]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 18 2E 4E 45 54 43 6F 72 65 41 70 70 2C 56   // ....NETCoreApp,V
                                                                                                              65 72 73 69 6F 6E 3D 76 37 2E 30 01 00 54 0E 14   // ersion=v7.0..T..
                                                                                                              46 72 61 6D 65 77 6F 72 6B 44 69 73 70 6C 61 79   // FrameworkDisplay
                                                                                                              4E 61 6D 65 08 2E 4E 45 54 20 37 2E 30 )          // Name..NET 7.0
  .custom instance void [System.Runtime]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 0D 43 6C 61 73 73 4C 69 62 72 61 72 79 31   // ...ClassLibrary1
                                                                                                      00 00 ) 
  .custom instance void [System.Runtime]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 07 52 65 6C 65 61 73 65 00 00 )             // ...Release..
  .custom instance void [System.Runtime]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyInformationalVersionAttribute::.ctor(string) = ( 01 00 05 31 2E 30 2E 30 00 00 )                   // ...1.0.0..
  .custom instance void [System.Runtime]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 0D 43 6C 61 73 73 4C 69 62 72 61 72 79 31   // ...ClassLibrary1
                                                                                                      00 00 ) 
  .custom instance void [System.Runtime]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 0D 43 6C 61 73 73 4C 69 62 72 61 72 79 31   // ...ClassLibrary1
                                                                                                    00 00 ) 
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}

.module CollatzConjectureWithIL.dll
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY

/*
.assembly extern System.Numerics
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
*/

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [System.Runtime]System.Attribute
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Attribute::.ctor()
    IL_0006:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [System.Runtime]System.Attribute
{
  .custom instance void [System.Runtime]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [System.Runtime]System.AttributeUsageAttribute::.ctor(valuetype [System.Runtime]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                                     4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                                     72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       14 (0xe)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [System.Runtime]System.Attribute::.ctor()
    IL_0006:  ldarg.0
    IL_0007:  ldarg.1
    IL_0008:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000d:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class public auto ansi sealed beforefieldinit CollatzConjectureWithIL.CollatzConjectureUsingTailCall
       extends [mscorlib]System.Object
{
  .field private initonly valuetype [System.Numerics]System.Numerics.BigInteger '<Iterations>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .field private initonly valuetype [System.Numerics]System.Numerics.BigInteger '<Value>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(valuetype [System.Numerics]System.Numerics.BigInteger 'value') cil managed
  {
    // Code size       71 (0x47)
    .maxstack  3
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ldarg.1
    IL_0007:  ldc.i4.0
    IL_0008:  conv.i8
    IL_0009:  call       bool [System.Numerics]System.Numerics.BigInteger::op_LessThanOrEqual(valuetype [System.Numerics]System.Numerics.BigInteger,
                                                                                              int64)
    IL_000e:  brfalse.s  IL_001b

    IL_0010:  ldstr      "Value must be greater than 0."
    IL_0015:  newobj     instance void [mscorlib]System.NotSupportedException::.ctor(string)
    IL_001a:  throw

    IL_001b:  ldarg.0
    IL_001c:  ldarg.1
    IL_001d:  stfld      valuetype [System.Numerics]System.Numerics.BigInteger CollatzConjectureWithIL.CollatzConjectureUsingTailCall::'<Value>k__BackingField'
    IL_0022:  ldarg.1
    IL_0023:  ldc.i4.1
    IL_0024:  conv.i8
    IL_0025:  call       bool [System.Numerics]System.Numerics.BigInteger::op_Equality(valuetype [System.Numerics]System.Numerics.BigInteger,
                                                                                       int64)
    IL_002a:  brfalse.s  IL_0039

    IL_002c:  ldarg.0
    IL_002d:  ldc.i4.0
    IL_002e:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::op_Implicit(int32)
    IL_0033:  stfld      valuetype [System.Numerics]System.Numerics.BigInteger CollatzConjectureWithIL.CollatzConjectureUsingTailCall::'<Iterations>k__BackingField'
    IL_0038:  ret

    IL_0039:  ldarg.0
    IL_003a:  ldarg.0
    IL_003b:  ldarg.1
    IL_003c:  call       instance valuetype [System.Numerics]System.Numerics.BigInteger CollatzConjectureWithIL.CollatzConjectureUsingTailCall::GetIterations(valuetype [System.Numerics]System.Numerics.BigInteger)
    IL_0041:  stfld      valuetype [System.Numerics]System.Numerics.BigInteger CollatzConjectureWithIL.CollatzConjectureUsingTailCall::'<Iterations>k__BackingField'
    IL_0046:  ret
  } // end of method CollatzConjecture::.ctor

  .method private hidebysig instance valuetype [System.Numerics]System.Numerics.BigInteger 
          GetIterations(valuetype [System.Numerics]System.Numerics.BigInteger 'value') cil managed
  {
    // Code size       32 (0x20)
    .maxstack  3
    .locals init ([0] valuetype [System.Numerics]System.Numerics.BigInteger iterations)
    IL_0000:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::get_Zero()
    IL_0005:  stloc.0
    IL_0006:  ldarg.1
    IL_0007:  ldc.i4.1
    IL_0008:  conv.i8
    IL_0009:  call       bool [System.Numerics]System.Numerics.BigInteger::op_GreaterThan(valuetype [System.Numerics]System.Numerics.BigInteger,
                                                                                          int64)
    IL_000e:  brfalse.s  IL_0019

    IL_0010:  ldarg.0
    IL_0011:  ldarg.1
    IL_0012:  ldloc.0
    IL_0013:  call       instance valuetype [System.Numerics]System.Numerics.BigInteger CollatzConjectureWithIL.CollatzConjectureUsingTailCall::GetIterations(valuetype [System.Numerics]System.Numerics.BigInteger,
                                                                                                                                   valuetype [System.Numerics]System.Numerics.BigInteger)
    IL_0018:  ret

    IL_0019:  ldc.i4.0
    IL_001a:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::op_Implicit(int32)
    IL_001f:  ret
  } // end of method CollatzConjecture::GetIterations

  .method private hidebysig instance valuetype [System.Numerics]System.Numerics.BigInteger 
          GetIterations(valuetype [System.Numerics]System.Numerics.BigInteger currentValue,
                        valuetype [System.Numerics]System.Numerics.BigInteger iterations) cil managed
  {
    // Code size       41 (0x29)
    .maxstack  8
    IL_0000:  ldarg.2
    IL_0001:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::op_Increment(valuetype [System.Numerics]System.Numerics.BigInteger)
    IL_0006:  starg.s    iterations
    IL_0008:  ldarg.0
    IL_0009:  ldarg.1
    IL_000a:  call       instance valuetype [System.Numerics]System.Numerics.BigInteger CollatzConjectureWithIL.CollatzConjectureUsingTailCall::GetNextValue(valuetype [System.Numerics]System.Numerics.BigInteger)
    IL_000f:  starg.s    currentValue
    IL_0011:  ldarg.1
    IL_0012:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::get_One()
    IL_0017:  call       bool [System.Numerics]System.Numerics.BigInteger::op_Equality(valuetype [System.Numerics]System.Numerics.BigInteger,
                                                                                       valuetype [System.Numerics]System.Numerics.BigInteger)
    IL_001c:  brfalse.s  IL_0020

    IL_001e:  ldarg.2
    IL_001f:  ret

    IL_0020:  ldarg.0
    IL_0021:  ldarg.1
    IL_0022:  ldarg.2
	tail.
    IL_0023:  call       instance valuetype [System.Numerics]System.Numerics.BigInteger CollatzConjectureWithIL.CollatzConjectureUsingTailCall::GetIterations(valuetype [System.Numerics]System.Numerics.BigInteger,
                                                                                                                                   valuetype [System.Numerics]System.Numerics.BigInteger)
    IL_0028:  ret
  } // end of method CollatzConjecture::GetIterations

  .method private hidebysig instance valuetype [System.Numerics]System.Numerics.BigInteger 
          GetNextValue(valuetype [System.Numerics]System.Numerics.BigInteger 'value') cil managed
  {
    // Code size       58 (0x3a)
    .maxstack  8
    IL_0000:  ldarg.1
    IL_0001:  ldc.i4.2
    IL_0002:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::op_Implicit(int32)
    IL_0007:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::op_Modulus(valuetype [System.Numerics]System.Numerics.BigInteger,
                                                                                                                                       valuetype [System.Numerics]System.Numerics.BigInteger)
    IL_000c:  ldc.i4.0
    IL_000d:  conv.i8
    IL_000e:  call       bool [System.Numerics]System.Numerics.BigInteger::op_Equality(valuetype [System.Numerics]System.Numerics.BigInteger,
                                                                                       int64)
    IL_0013:  brtrue.s   IL_002d

    IL_0015:  ldc.i4.3
    IL_0016:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::op_Implicit(int32)
    IL_001b:  ldarg.1
    IL_001c:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::op_Multiply(valuetype [System.Numerics]System.Numerics.BigInteger,
                                                                                                                                        valuetype [System.Numerics]System.Numerics.BigInteger)
    IL_0021:  ldc.i4.1
    IL_0022:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::op_Implicit(int32)
    IL_0027:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::op_Addition(valuetype [System.Numerics]System.Numerics.BigInteger,
                                                                                                                                        valuetype [System.Numerics]System.Numerics.BigInteger)
    IL_002c:  ret

    IL_002d:  ldarg.1
    IL_002e:  ldc.i4.2
    IL_002f:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::op_Implicit(int32)
    IL_0034:  call       valuetype [System.Numerics]System.Numerics.BigInteger [System.Numerics]System.Numerics.BigInteger::op_Division(valuetype [System.Numerics]System.Numerics.BigInteger,
                                                                                                                                        valuetype [System.Numerics]System.Numerics.BigInteger)
    IL_0039:  ret
  } // end of method CollatzConjecture::GetNextValue

  .method public hidebysig specialname instance valuetype [System.Numerics]System.Numerics.BigInteger 
          get_Iterations() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      valuetype [System.Numerics]System.Numerics.BigInteger CollatzConjectureWithIL.CollatzConjectureUsingTailCall::'<Iterations>k__BackingField'
    IL_0006:  ret
  } // end of method CollatzConjecture::get_Iterations

  .method public hidebysig specialname instance valuetype [System.Numerics]System.Numerics.BigInteger 
          get_Value() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      valuetype [System.Numerics]System.Numerics.BigInteger CollatzConjectureWithIL.CollatzConjectureUsingTailCall::'<Value>k__BackingField'
    IL_0006:  ret
  } // end of method CollatzConjecture::get_Value

  .property instance valuetype [System.Numerics]System.Numerics.BigInteger
          Iterations()
  {
    .get instance valuetype [System.Numerics]System.Numerics.BigInteger CollatzConjectureWithIL.CollatzConjectureUsingTailCall::get_Iterations()
  } // end of property CollatzConjecture::Iterations
  .property instance valuetype [System.Numerics]System.Numerics.BigInteger
          Value()
  {
    .get instance valuetype [System.Numerics]System.Numerics.BigInteger CollatzConjectureWithIL.CollatzConjectureUsingTailCall::get_Value()
  } // end of property CollatzConjecture::Value
} // end of class CollatzConjectureWithIL.CollatzConjectureUsingTailCall