namespace Disposables;

#pragma warning disable CA1063 // Implement IDisposable Correctly
#pragma warning disable IDISP025 // Class with no virtual dispose method should be sealed
public class UsesUnmanageableResourceCorrectly
#pragma warning restore IDISP025 // Class with no virtual dispose method should be sealed
#pragma warning restore CA1063 // Implement IDisposable Correctly
	: IDisposable
{
	private readonly UnmanageableResource resource = new();

#pragma warning disable CA1063 // Implement IDisposable Correctly
#pragma warning disable CA1816 // Dispose methods should call SuppressFinalize
   public void Dispose() =>
		this.resource.Free();
#pragma warning restore CA1816 // Dispose methods should call SuppressFinalize
#pragma warning restore CA1063 // Implement IDisposable Correctly
}
