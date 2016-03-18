using System;
using System.Runtime.InteropServices;

namespace Disposables
{
	public class UsesUnmanageableResourceAndImplementsIDisposableCorrectly
		: IDisposable
	{
		private IntPtr nativeResource = Marshal.AllocHGlobal(10);
		private UnmanageableResource resource =
			new UnmanageableResource();

		public UsesUnmanageableResourceAndImplementsIDisposableCorrectly()
		{
			this.resource = new UnmanageableResource();
		}

		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		~UsesUnmanageableResourceAndImplementsIDisposableCorrectly()
		{
			this.Dispose(false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.resource != null)
				{
					this.resource.Free();
					this.resource = null;
				}
			}

			if (nativeResource != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(nativeResource);
				nativeResource = IntPtr.Zero;
			}
		}
	}
}
