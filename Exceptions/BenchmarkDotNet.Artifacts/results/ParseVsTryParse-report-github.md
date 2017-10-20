``` ini

BenchmarkDotNet=v0.10.9, OS=Windows 10 Redstone 2 (10.0.15063)
Processor=Intel Core i7-5600U CPU 2.60GHz (Broadwell), ProcessorCount=4
Frequency=2533196 Hz, Resolution=394.7582 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2115.0
  DefaultJob : .NET Framework 4.7 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2115.0


```
 |   Method |         Mean |        Error |       StdDev |
 |--------- |-------------:|-------------:|-------------:|
 |    Parse | 57,115.38 ns | 1,097.885 ns | 1,174.725 ns |
 | TryParse |     75.95 ns |     1.551 ns |     3.500 ns |
