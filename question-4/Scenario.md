# Question

Users are occasionally getting very slow response times. What can be done to improve this?

# Tips and tricks

The `ManagedIdentityCredential` cache implemented so that tokens are renewed synchronously when used. This can cause the application to be slow when the cache is empty or expired.

The fix is to update the cache on a background thread before the token expires.

https://github.com/ClassonConsultingAB/Identity
