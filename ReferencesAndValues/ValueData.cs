namespace ReferencesAndValues;

#pragma warning disable CA1815 // Override equals and operator equals on value types
public struct ValueData
#pragma warning restore CA1815 // Override equals and operator equals on value types
{
	public ValueData(int data) => this.Data = data;

	public void Increment() => this.Data++;

	public int Data { get; private set; }
}
