// See https://aka.ms/new-console-template for more information

using Azure.Core;
using Azure.Identity;

var options = new DefaultAzureCredentialOptions
{
    ExcludeManagedIdentityCredential = IsCodeRunningOnTheBuildServer()
};

var response = await new DefaultAzureCredential(options)
    .GetTokenAsync(new TokenRequestContext([
        "https://management.azure.com/.default"
    ]));

Console.WriteLine(response.Token);
return;

bool IsCodeRunningOnTheBuildServer()
{
    // Dummy implementation
    return true;
}
