// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Azure.Core;
using Azure.Identity;
using Classon.Identity;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddCachingTokenCredential(new DefaultAzureCredential());
var sp = services.BuildServiceProvider();
var credential = sp.GetRequiredService<TokenCredential>();

Environment.SetEnvironmentVariable("IDENTITY_ENDPOINT", "");
Console.WriteLine("IDENTITY_ENDPOINT: " + Environment.GetEnvironmentVariable("IDENTITY_ENDPOINT"));
await DoStuff();
await DoStuff();
return;

async Task DoStuff()
{
    var watch = Stopwatch.StartNew();
    await credential.GetTokenAsync("https://management.azure.com/.default");
    watch.Stop();
    Console.WriteLine($"Duration: {watch.Elapsed.TotalMilliseconds}ms");
}
