﻿using System.Runtime.InteropServices;

namespace Disposables;

public class UsesResourcesWithMembers
	: IDisposable
{
	private bool isDisposed;
	private IntPtr nativeResource = Marshal.AllocHGlobal(10);
	private UnmanageableResource? resource = new();

	public UsesResourcesWithMembers() =>
		this.resource = new UnmanageableResource();

	public void Dispose()
	{
		this.Dispose(true);
		GC.SuppressFinalize(this);
	}

	~UsesResourcesWithMembers() =>
		this.Dispose(false);

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (this.resource is not null)
			{
				this.resource.Free();
				this.resource = null;
			}
		}

		if (this.nativeResource != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(this.nativeResource);
			this.nativeResource = IntPtr.Zero;
		}

		this.isDisposed = true;
	}

	// Original way
	//public string Data => "Data";

	//public void MarshalData(int value)
	//{
	//	Marshal.WriteInt32(this.nativeResource, value);
	//}

	public string Data
	{
		get
		{
			ObjectDisposedException.ThrowIf(this.isDisposed, this);
			return "Data";
		}
	}

	public void MarshalData(int value)
	{
		ObjectDisposedException.ThrowIf(this.isDisposed, this);
		Marshal.WriteInt32(this.nativeResource, value);
	}
}
