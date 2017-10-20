namespace Disposables
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			using (var uses = new UsesUnmanageableResourceCorrectly())
			{
				// Use uses here...
			}

#pragma warning disable IDISP001 // Dispose created.
			var uses2 = new UsesUnmanageableResourceCorrectly();
#pragma warning restore IDISP001 // Dispose created.

			UsesResourcesWithMembers usesWithMembers = null;

#pragma warning disable IDISP003 // Dispose previous before re-assigning.
			using (usesWithMembers = new UsesResourcesWithMembers())
#pragma warning restore IDISP003 // Dispose previous before re-assigning.
			{
				// Use uses here...
			}

			var data = usesWithMembers.Data;
			usesWithMembers.MarshalData(10);
		}
	}
}
