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
			this.Iterations = value == 1 ? 0 : this.GetIterations(value);
		}

		private BigInteger GetIterations(BigInteger value) =>
			value > 1 ? this.GetIterations(value, BigInteger.Zero) : 0;

		private BigInteger GetIterations(BigInteger currentValue, BigInteger iterations)
		{
			iterations++;
			currentValue = this.GetNextValue(currentValue);
			return currentValue == BigInteger.One ? 
				iterations : this.GetIterations(currentValue, iterations);
		}

		private BigInteger GetNextValue(BigInteger value) =>
			value % 2 == 0 ? value / 2 : (3 * value) + 1;

		public BigInteger Iterations { get; }
		public BigInteger Value { get; }
	}
}
