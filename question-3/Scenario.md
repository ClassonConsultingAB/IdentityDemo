# Question

Running locally is slow. What can be done to speed things up?

# Tips and tricks

Only the `ManagedIdentityCredential` have a cache implemented, and that cache is reset if the application is restarted. Application restarts are common during development.

The fix is to cache the access tokens. This can be done either with a custom implementation of `TokenCredential` or by using the managed identity local development proxy.

https://github.com/ClassonConsultingAB/Identity

https://github.com/CABGroupAB/Corporate.Mercury.CoreHub/tree/main/services/container-image/azure-cli-credential-proxy
