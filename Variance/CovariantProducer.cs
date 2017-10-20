namespace Variance
{
	public sealed class CovariantProducer<T>
		: ICovariantProducer<T> where T : new()
	{
		public T Produce() => new T();
	}
}
