namespace ReferencesAndValues
{
	public sealed class ReferenceData
	{
		public ReferenceData(int data) => this.Data = data;

		public void Increment() => this.Data++;

		public int Data { get; private set; }
	}
}
