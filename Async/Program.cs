using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Async
{
	public static class Program
	{
		public static async Task Main(string[] args)
		{
			await Program.WriteAsync();
			await Program.RunNewTaskAsync();
			await Console.Out.WriteLineAsync("Finished");
		}

		private static async Task WriteAsync()
		{
			var client = new HttpClient();
			var vsLiveData = await client.GetStringAsync("http://www.vslive.com");

			await Console.Out.WriteLineAsync(vsLiveData);
		}

		private static async Task RunNewTaskAsync() =>
			await Task.Run(() => Task.Delay(1000));
	}
}
