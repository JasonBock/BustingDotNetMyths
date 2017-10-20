``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-5600U CPU 2.60GHz (Broadwell), ProcessorCount=4
Frequency=2533196 Hz, Resolution=394.7582 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2115.0
  DefaultJob : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2115.0


```
 |                  Method |     Mean |    Error |    StdDev |
 |------------------------ |---------:|---------:|----------:|
 | CollatzWithoutRecursion | 175.3 us | 3.717 us |  5.676 us |
 |    CollatzWithRecursion | 237.7 us | 4.830 us |  5.932 us |
 |    CollatzUsingTailCall | 485.2 us | 9.096 us | 13.614 us |
