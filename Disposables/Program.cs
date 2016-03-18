namespace Disposables
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var uses = new UsesUnmanageableResourceCorrectly())
			{
				// Use uses here...
			}

			var uses2 = new UsesUnmanageableResourceCorrectly();

			UsesResourcesWithMembers usesWithMembers = null;

			using (usesWithMembers = new UsesResourcesWithMembers())
			{
				// Use uses here...
			}

			var data = usesWithMembers.Data;
			usesWithMembers.MarshalData(10);
		}
	}
}
