await RunNewTaskAsync();
await WriteAsync();
await Console.Out.WriteLineAsync("Finished");

static async Task WriteAsync()
{
	await Console.Out.WriteLineAsync($"{nameof(WriteAsync)} - started...");
	using var client = new HttpClient();
	var vsLiveData = await client.GetStringAsync(new Uri("http://www.vslive.com"));

	await Console.Out.WriteLineAsync(vsLiveData);
	await Console.Out.WriteLineAsync($"{nameof(WriteAsync)} - finished.");
}

static async Task RunNewTaskAsync()
{
	await Console.Out.WriteLineAsync($"{nameof(RunNewTaskAsync)} - started...");
	await Task.Run(() => Task.Delay(1000));
	await Console.Out.WriteLineAsync($"{nameof(RunNewTaskAsync)} - finished.");
}