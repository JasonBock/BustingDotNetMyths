// To compile: ilasm Overloaded.il /dll

.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )
  .ver 1:0:0:0
}

.assembly Overloaded
{
  .custom instance void 
    [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void 
    [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = 
	  ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78 63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )
  .hash algorithm 0x00008004
  .ver 0:0:0:0
}

.module Overloaded.dll
.imagebase 0x00400000
.subsystem 0x00000003
.file alignment 512
.corflags 0x00000001

.class public auto ansi beforefieldinit Overloaded.ValueGenerator
       extends [mscorlib]System.Object
{
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  }

  .method public hidebysig instance int32 
          GetValue() cil managed
  {
    .maxstack  8
    IL_0000:  ldc.i4 0x64
    IL_0005:  ret
  }

  .method public hidebysig instance string 
          GetValue() cil managed
  {
    .maxstack  8
    IL_0000:  ldstr "100"
    IL_0005:  ret
  }
}