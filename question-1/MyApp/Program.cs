// See https://aka.ms/new-console-template for more information

using Azure.Core;
using Azure.Identity;

var response = await new DefaultAzureCredential()
    .GetTokenAsync(new TokenRequestContext([
        "https://management.azure.com/.default"
    ]));

Console.WriteLine(response.Token);
