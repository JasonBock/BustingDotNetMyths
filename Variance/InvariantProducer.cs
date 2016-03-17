namespace Variance
{
	public sealed class InvariantProducer<T>
		: IInvariantProducer<T> where T : new()
	{
		public T Produce()
		{
			return new T();
		}
	}
}
