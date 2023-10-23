namespace Variance;

public interface IVariantList<in TIn, out TOut>
	where TIn : TOut
{
	TOut Get(int index);
	void Set(int index, TIn value);
	int IndexOf(TIn item);
}
