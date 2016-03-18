using System;

namespace Disposables
{
	public class UsesUnmanageableResourceCorrectly
		: IDisposable
	{
		private readonly UnmanageableResource resource =
			new UnmanageableResource();

		public void Dispose()
		{
			this.resource.Free();
		}
	}
}
