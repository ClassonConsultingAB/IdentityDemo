# Question

I get access denied when running locally. What can be wrong?

# Tips and tricks

Normally, the error messages are not that informative, but rather is just that you do not have access. Since `DefaultAzureCredential` can pick up the identity from so many sources it is important to understand what identity that is used.

I normally debug this by setting a break point inside DefaultAzureCredential to lookup the access token, which I paste into https://jwt.ms to for example see the `upn` claim.

If your IDE cannot do this, you can try to request a token manually.

```csharp
var response = await new DefaultAzureCredential().GetTokenAsync(new TokenRequestContext([
    "https://management.azure.com/.default"
]));
```
