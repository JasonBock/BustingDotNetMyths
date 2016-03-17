namespace Variance
{
	public interface IInvariantProducer<T>
		where T : new()
	{
		T Produce();
	}
}
