namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public enum DeviceRiskScore
{
    none = 0,
    informational = 5,
    low = 10,
    medium = 20,
    high = 30,
    unknownFutureValue = 31
}
