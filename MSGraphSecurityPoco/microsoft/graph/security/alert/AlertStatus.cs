namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Alert;

public enum AlertStatus
{
    unknown = 0,
    New = 2,
    inProgress = 4,
    resolved = 8,
    unknownFutureValue = 31
}
