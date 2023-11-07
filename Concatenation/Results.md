# Concatenation Results

## Concatenation3Parts

.NET 4.8.1

| Method                       | Mean      | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|----------------------------- |----------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      |  90.79 ns | 1.114 ns | 1.700 ns |  1.00 |    0.00 | 0.1529 |     642 B |        1.00 |
| ConcatenateWithStringBuilder | 209.21 ns | 2.294 ns | 1.916 ns |  2.30 |    0.07 | 0.3767 |    1581 B |        2.46 |
| ConcatenateWithInterpolation |  81.59 ns | 0.947 ns | 0.840 ns |  0.90 |    0.03 | 0.1529 |     642 B |        1.00 |

.NET 7

| Method                       | Mean      | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|----------------------------- |----------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      |  66.96 ns | 1.248 ns | 1.106 ns |  1.00 |    0.00 | 0.1358 |     568 B |        1.00 |
| ConcatenateWithStringBuilder | 132.24 ns | 2.090 ns | 1.955 ns |  1.98 |    0.05 | 0.3748 |    1568 B |        2.76 |
| ConcatenateWithInterpolation |  76.09 ns | 0.805 ns | 0.753 ns |  1.14 |    0.02 | 0.1204 |     504 B |        0.89 |

## Concatenation9Parts

.NET 4.8.1

| Method                       | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|----------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 283.1 ns | 5.64 ns | 9.58 ns |  1.00 |    0.00 | 0.4320 |   1.77 KB |        1.00 |
| ConcatenateWithStringBuilder | 502.2 ns | 6.35 ns | 5.94 ns |  1.77 |    0.09 | 0.8278 |   3.39 KB |        1.92 |
| ConcatenateWithInterpolation | 250.9 ns | 4.33 ns | 3.38 ns |  0.88 |    0.04 | 0.4320 |   1.77 KB |        1.00 |

.NET 7

| Method                       | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|----------------------------- |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 192.1 ns | 3.31 ns | 3.25 ns |  1.00 |    0.00 | 0.3939 |   1.61 KB |        1.00 |
| ConcatenateWithStringBuilder | 286.1 ns | 5.12 ns | 4.79 ns |  1.49 |    0.04 | 0.8283 |   3.38 KB |        2.10 |
| ConcatenateWithInterpolation | 240.6 ns | 3.55 ns | 3.32 ns |  1.25 |    0.03 | 0.3557 |   1.45 KB |        0.90 |

## Concatenation30Parts

.NET 4.8.1

| Method                       | Mean       | Error    | StdDev    | Median     | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|----------------------------- |-----------:|---------:|----------:|-----------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 2,353.5 ns | 38.67 ns |  36.17 ns | 2,356.5 ns |  1.00 |    0.00 | 1.4114 |   5.79 KB |        1.00 |
| ConcatenateWithStringBuilder | 1,763.8 ns | 77.57 ns | 216.22 ns | 1,660.0 ns |  0.72 |    0.04 | 2.8839 |  11.83 KB |        2.04 |
| ConcatenateWithInterpolation |   941.3 ns | 17.81 ns |  18.29 ns |   939.7 ns |  0.40 |    0.01 | 1.4114 |   5.79 KB |        1.00 |

.NET 7

| Method                       | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|----------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 665.6 ns | 10.77 ns | 10.08 ns |  1.00 |    0.00 | 1.2913 |   5.28 KB |        1.00 |
| ConcatenateWithStringBuilder | 902.8 ns | 17.93 ns | 15.90 ns |  1.36 |    0.04 | 2.8839 |  11.79 KB |        2.23 |
| ConcatenateWithInterpolation | 722.5 ns |  9.49 ns |  8.42 ns |  1.09 |    0.02 | 1.1730 |    4.8 KB |        0.91 |

## Concatenation300Parts

.NET 4.8.1

| Method                       | Mean      | Error     | StdDev    | Median    | Ratio | RatioSD | Gen0    | Allocated | Alloc Ratio |
|----------------------------- |----------:|----------:|----------:|----------:|------:|--------:|--------:|----------:|------------:|
| ConcatenateWithAddition      | 21.930 us | 0.4378 us | 0.4096 us | 21.907 us |  1.00 |    0.00 | 13.8855 |  57.33 KB |        1.00 |
| ConcatenateWithStringBuilder | 16.259 us | 0.9682 us | 2.6010 us | 15.027 us |  0.78 |    0.18 | 25.8179 | 106.34 KB |        1.85 |
| ConcatenateWithInterpolation |  8.183 us | 0.0445 us | 0.0347 us |  8.186 us |  0.37 |    0.01 | 13.8855 |  57.33 KB |        1.00 |

.NET 7

| Method                       | Mean     | Error     | StdDev    | Ratio | RatioSD | Gen0    | Allocated | Alloc Ratio |
|----------------------------- |---------:|----------:|----------:|------:|--------:|--------:|----------:|------------:|
| ConcatenateWithAddition      | 6.483 us | 0.0894 us | 0.0792 us |  1.00 |    0.00 | 12.8174 |  52.57 KB |        1.00 |
| ConcatenateWithStringBuilder | 8.186 us | 0.0970 us | 0.0859 us |  1.26 |    0.02 | 25.8484 | 106.09 KB |        2.02 |
| ConcatenateWithInterpolation | 7.612 us | 0.0611 us | 0.0541 us |  1.17 |    0.02 | 11.6272 |  47.87 KB |        0.91 |