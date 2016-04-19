namespace ReferencesAndValues
{
	public struct ValueData
	{
		public ValueData(int data)
		{
			this.Data = data;
		}

		public void Increment()
		{
			this.Data++;
		}

		public int Data { get; private set; }
	}
}
