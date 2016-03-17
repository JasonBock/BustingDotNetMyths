using System;
using System.Numerics;

namespace Recursion
{
	public sealed class CollatzConjecture
	{
		public CollatzConjecture(BigInteger value)
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
			var iterations = BigInteger.Zero;

			if(value > 1)
			{
				return this.GetIterations(value, iterations);
			}
			else
			{
				return 0;
			}
		}

		private BigInteger GetIterations(BigInteger currentValue, BigInteger iterations)
		{
			iterations++;

			currentValue = this.GetNextValue(currentValue);

			if(currentValue == BigInteger.One)
			{
				return iterations;
			}
			else
			{
				return this.GetIterations(currentValue, iterations);
			}
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
