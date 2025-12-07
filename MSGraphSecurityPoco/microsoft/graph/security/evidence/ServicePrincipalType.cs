namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public enum ServicePrincipalType
{
    unknown = 0,
    application = 1,
    managedIdentity = 2,
    legacy = 3,
    unknownFutureValue = 4
}
