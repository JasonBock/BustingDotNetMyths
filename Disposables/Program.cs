using Disposables;

using (var uses = new UsesUnmanageableResourceCorrectly())
{
	// Use uses here...
}

#pragma warning disable CA2000 // Dispose objects before losing scope
#pragma warning disable IDISP001 // Dispose created
var uses2 = new UsesUnmanageableResourceCorrectly();
#pragma warning restore IDISP001 // Dispose created
#pragma warning restore CA2000 // Dispose objects before losing scope

UsesResourcesWithMembers? usesWithMembers = null;

using (usesWithMembers = new UsesResourcesWithMembers())
{
   // Use uses here...
}

var data = usesWithMembers.Data;
usesWithMembers.MarshalData(10);