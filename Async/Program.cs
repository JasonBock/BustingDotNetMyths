using Nito.AsyncEx;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Async
{
	class Program
	{
		static void Main(string[] args)
		{
			AsyncContext.Run(async () =>
			{
				await Program.WriteAsync();
				await Program.RunNewTask();
				Console.Out.WriteLine("Finished");
			});
		}

		private static async Task WriteAsync()
		{
			var client = new HttpClient();
			var vsLiveData = await client.GetStringAsync("http://www.vslive.com");

			await Console.Out.WriteLineAsync(vsLiveData);
		}

		private static async Task RunNewTask()
		{
			await Task.Run(() => Task.Delay(1000));
		}
	}
}
