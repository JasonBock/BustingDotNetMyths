// To compile: ilasm CollatzConjectureWithIL.il /dll /debug

.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern System.Numerics
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly CollatzConjectureWithIL
{
  .permissionset reqmin
             = {[mscorlib]System.Security.Permissions.SecurityPermissionAttribute = {property bool 'SkipVerification' = bool(true)}}
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}

.module CollatzConjectureWithIL.dll
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED

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