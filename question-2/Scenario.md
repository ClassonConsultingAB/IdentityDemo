# Question

I get access denied when running on the build server. What can be wrong?

# Tips and tricks

The build server have a system assigned managed identity assigned to it to be able to report metrics.

It does not matter if you execute the azure/login action, as `DefaultAzureCredential` will use the `ManagedIdentityCredential` before it even tries to use the `AzureCliCredential`.

The fix is to either disable the managed identity when running on the build server, or to use `AzCliCredential` instead of `DefaultAzureCredential`.
