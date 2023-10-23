namespace Variance;

public interface ICovariantProducer<out T>
	where T : new()
{
	T Produce();
}
