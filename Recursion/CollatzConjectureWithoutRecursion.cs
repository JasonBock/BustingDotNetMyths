using System;
using System.Numerics;

namespace Recursion
{
	public sealed class CollatzConjectureWithoutRecursion
	{
		public CollatzConjectureWithoutRecursion(BigInteger value)
		{
			if (value <= 0)
			{
				throw new NotSupportedException("Value must be greater than 0.");
			}

			this.Value = value;

			if (value == 1)
			{
				this.Iterations = 0;
			}
			else
			{
				this.Iterations = this.GetIterations(value);
			}
		}

		private BigInteger GetIterations(BigInteger value)
		{
			var iterations = 0;

			var currentValue = value;

			while(currentValue > 1)
			{
				currentValue = this.GetNextValue(currentValue);
				iterations++;
			}

			return iterations;
		}

		private BigInteger GetNextValue(BigInteger value)
		{
			return value % 2 == 0 ?
				value / 2 : (3 * value) + 1;
		}

		public BigInteger Iterations { get; }
		public BigInteger Value { get; }
	}
}
