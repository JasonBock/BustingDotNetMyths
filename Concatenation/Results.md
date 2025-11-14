# Concatenation Results

## Concatenation3Parts

.NET 4.8.1

| Method                       | Mean      | Error    | StdDev   | Ratio | Gen0   | Gen1   | Allocated | Alloc Ratio |
|----------------------------- |----------:|---------:|---------:|------:|-------:|-------:|----------:|------------:|
| ConcatenateWithAddition      |  51.21 ns | 0.140 ns | 0.131 ns |  1.00 | 0.1020 |      - |     642 B |        1.00 |
| ConcatenateWithStringBuilder | 109.38 ns | 0.367 ns | 0.325 ns |  2.14 | 0.2512 | 0.0010 |    1581 B |        2.46 |
| ConcatenateWithInterpolation |  49.71 ns | 0.171 ns | 0.152 ns |  0.97 | 0.1020 |      - |     642 B |        1.00 |

.NET 9

| Method                       | Mean     | Error    | StdDev   | Ratio |  Gen0   | Gen1   | Allocated | Alloc Ratio |
|----------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 31.04 ns | 0.422 ns | 0.394 ns |  1.00 |  0.0329 |      - |     568 B |        1.00 |
| ConcatenateWithStringBuilder | 71.55 ns | 0.317 ns | 0.281 ns |  2.31 |  0.0908 | 0.0004 |    1568 B |        2.76 |
| ConcatenateWithInterpolation | 35.28 ns | 0.220 ns | 0.195 ns |  1.14 |  0.0292 |      - |     504 B |        0.89 |

.NET 10

| Method                       | Mean     | Error    | StdDev   | Ratio |  Gen0   | Gen1   | Allocated | Alloc Ratio |
|----------------------------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 29.04 ns | 0.381 ns | 0.338 ns |  1.00 |  0.0329 |      - |     568 B |        1.00 |
| ConcatenateWithStringBuilder | 68.98 ns | 0.310 ns | 0.274 ns |  2.38 |  0.0908 | 0.0004 |    1568 B |        2.76 |
| ConcatenateWithInterpolation | 32.21 ns | 0.123 ns | 0.115 ns |  1.11 |  0.0292 |      - |     504 B |        0.89 |

## Concatenation9Parts

.NET 4.8.1

| Method                       | Mean     | Error   | StdDev  | Ratio | Gen0   | Gen1   | Allocated | Alloc Ratio |
|----------------------------- |---------:|--------:|--------:|------:|-------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 154.4 ns | 0.62 ns | 0.55 ns |  1.00 | 0.2880 |      - |   1.77 KB |        1.00 |
| ConcatenateWithStringBuilder | 278.5 ns | 0.82 ns | 0.69 ns |  1.80 | 0.5522 | 0.0038 |   3.39 KB |        1.92 |
| ConcatenateWithInterpolation | 149.3 ns | 0.35 ns | 0.33 ns |  0.97 | 0.2880 |      - |   1.77 KB |        1.00 |

.NET 9

| Method                       | Mean      | Error    | StdDev   | Ratio |  Gen0   | Gen1   | Allocated | Alloc Ratio |
|----------------------------- |----------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      |  87.91 ns | 1.505 ns | 1.407 ns |  1.00 |  0.0955 |      - |   1.61 KB |        1.00 |
| ConcatenateWithStringBuilder | 149.99 ns | 0.977 ns | 0.866 ns |  1.71 |  0.2007 | 0.0014 |   3.38 KB |        2.10 |
| ConcatenateWithInterpolation | 116.21 ns | 0.676 ns | 0.599 ns |  1.32 |  0.0862 |      - |   1.45 KB |        0.90 |

.NET 10

| Method                       | Mean      | Error    | StdDev   | Ratio |  Gen0   | Gen1   | Allocated | Alloc Ratio |
|----------------------------- |----------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      |  86.81 ns | 0.642 ns | 0.536 ns |  1.00 |  0.0955 |      - |   1.61 KB |        1.00 |
| ConcatenateWithStringBuilder | 150.73 ns | 1.549 ns | 1.449 ns |  1.74 |  0.2007 | 0.0014 |   3.38 KB |        2.10 |
| ConcatenateWithInterpolation | 107.97 ns | 0.593 ns | 0.526 ns |  1.24 |  0.0862 |      - |   1.45 KB |        0.90 |

## Concatenation30Parts

.NET 4.8.1

| Method                       | Mean     | Error   | StdDev  | Ratio | Gen0   | Gen1   | Allocated | Alloc Ratio |
|----------------------------- |---------:|--------:|--------:|------:|-------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 524.8 ns | 1.59 ns | 1.32 ns |  1.00 | 0.9413 | 0.0010 |   5.79 KB |        1.00 |
| ConcatenateWithStringBuilder | 915.6 ns | 2.81 ns | 2.49 ns |  1.74 | 1.9245 | 0.0505 |  11.83 KB |        2.04 |
| ConcatenateWithInterpolation | 506.1 ns | 1.28 ns | 1.20 ns |  0.96 | 0.9413 | 0.0010 |   5.79 KB |        1.00 |

.NET 9

| Method                       | Mean     | Error   | StdDev  | Ratio | Gen0   | Gen1   | Allocated | Alloc Ratio |
|----------------------------- |---------:|--------:|--------:|------:|-------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 289.3 ns | 1.91 ns | 1.69 ns |  1.00 | 0.3133 | 0.0005 |   5.28 KB |        1.00 |
| ConcatenateWithStringBuilder | 458.3 ns | 0.87 ns | 0.77 ns |  1.58 | 0.7000 | 0.0186 |  11.79 KB |        2.23 |
| ConcatenateWithInterpolation | 297.2 ns | 1.10 ns | 1.03 ns |  1.03 | 0.2847 |      - |    4.8 KB |        0.91 |

.NET 10

| Method                       | Mean     | Error   | StdDev  | Ratio | Gen0   | Gen1   | Allocated | Alloc Ratio |
|----------------------------- |---------:|--------:|--------:|------:|-------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 288.4 ns | 2.69 ns | 2.52 ns |  1.00 | 0.3133 | 0.0005 |   5.28 KB |        1.00 |
| ConcatenateWithStringBuilder | 456.1 ns | 1.74 ns | 1.45 ns |  1.58 | 0.7000 | 0.0186 |  11.79 KB |        2.23 |
| ConcatenateWithInterpolation | 279.0 ns | 2.80 ns | 2.62 ns |  0.97 | 0.2847 |      - |    4.8 KB |        0.91 |

## Concatenation300Parts

.NET 4.8.1

| Method                       | Mean     | Error     | StdDev    | Ratio | Gen0    | Gen1   | Allocated | Alloc Ratio |
|----------------------------- |---------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 5.084 us | 0.0268 us | 0.0250 us |  1.00 |  9.2850 | 0.1068 |  57.34 KB |        1.00 |
| ConcatenateWithStringBuilder | 8.840 us | 0.0219 us | 0.0194 us |  1.74 | 17.2272 | 2.8687 | 106.24 KB |        1.85 |
| ConcatenateWithInterpolation | 4.797 us | 0.0136 us | 0.0114 us |  0.94 |  9.2850 | 0.1068 |  57.34 KB |        1.00 |

.NET 9

| Method                       | Mean     | Error     | StdDev    | Ratio |  Gen0   | Gen1   | Allocated | Alloc Ratio |
|----------------------------- |---------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 2.941 us | 0.0314 us | 0.0294 us |  1.00 |  3.1128 | 0.0534 |  52.57 KB |        1.00 |
| ConcatenateWithStringBuilder | 4.361 us | 0.0261 us | 0.0232 us |  1.48 |  6.2866 | 1.0452 | 106.09 KB |        2.02 |
| ConcatenateWithInterpolation | 4.060 us | 0.0260 us | 0.0243 us |  1.38 |  2.8305 |      - |  47.87 KB |        0.91 |

.NET 10

| Method                       | Mean     | Error     | StdDev    | Ratio |  Gen0   | Gen1   | Allocated | Alloc Ratio |
|----------------------------- |---------:|----------:|----------:|------:|--------:|-------:|----------:|------------:|
| ConcatenateWithAddition      | 2.906 us | 0.0562 us | 0.0578 us |  1.00 |  3.1128 | 0.0534 |  52.57 KB |        1.00 |
| ConcatenateWithStringBuilder | 4.323 us | 0.0416 us | 0.0389 us |  1.49 |  6.2866 | 1.0452 | 106.09 KB |        2.02 |
| ConcatenateWithInterpolation | 3.999 us | 0.0198 us | 0.0165 us |  1.38 |  2.8305 |      - |  47.87 KB |        0.91 |