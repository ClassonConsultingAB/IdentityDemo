// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Azure.Core;
using Azure.Identity;

Environment.SetEnvironmentVariable("IDENTITY_ENDPOINT", "");
Console.WriteLine("IDENTITY_ENDPOINT: " + Environment.GetEnvironmentVariable("IDENTITY_ENDPOINT"));
await DoStuff();
await DoStuff();
return;

async Task DoStuff()
{
    var watch = Stopwatch.StartNew();
    await new DefaultAzureCredential().GetTokenAsync(new TokenRequestContext([
        "https://management.azure.com/.default"
    ]));
    watch.Stop();
    Console.WriteLine($"Duration: {watch.Elapsed.TotalMilliseconds}ms");
}

