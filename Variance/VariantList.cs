namespace Variance;

public sealed class VariantList<TIn, TOut>
	: IVariantList<TIn, TOut>
	where TIn : TOut
{
	private readonly List<TIn> items = new List<TIn>();

	public TOut Get(int index) => this.items[index];

	public int IndexOf(TIn item) => this.items.IndexOf(item);

	public void Set(int index, TIn value) => this.items[index] = value;
}
