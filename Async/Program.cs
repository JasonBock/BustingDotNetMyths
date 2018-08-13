using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Async
{
	public static class Program
	{
		public static async Task Main(string[] args)
		{
			await Program.RunNewTaskAsync();
			await Program.WriteAsync();
			await Console.Out.WriteLineAsync("Finished");
		}

		private static async Task WriteAsync()
		{
			await Console.Out.WriteLineAsync($"{nameof(Program.WriteAsync)} - started...");
			var client = new HttpClient();
			var vsLiveData = await client.GetStringAsync("http://www.vslive.com");

			await Console.Out.WriteLineAsync(vsLiveData);
			await Console.Out.WriteLineAsync($"{nameof(Program.WriteAsync)} - finished.");
		}

		private static async Task RunNewTaskAsync()
		{
			await Console.Out.WriteLineAsync($"{nameof(Program.RunNewTaskAsync)} - started...");
			await Task.Run(() => Task.Delay(1000));
			await Console.Out.WriteLineAsync($"{nameof(Program.RunNewTaskAsync)} - finished.");
		}
	}
}