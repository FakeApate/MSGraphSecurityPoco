namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public enum DefenderAvStatus
{
    notReporting = 0,
    disabled = 1,
    notUpdated = 2,
    updated = 3,
    unknown = 4,
    notSupported = 1000,
    unknownFutureValue = 1023
}
