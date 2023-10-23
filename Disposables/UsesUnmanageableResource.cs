namespace Disposables;

public class UsesUnmanageableResource
{
#pragma warning disable CA1823 // Avoid unused private fields
   private readonly UnmanageableResource resource = new();
#pragma warning restore CA1823 // Avoid unused private fields
}
