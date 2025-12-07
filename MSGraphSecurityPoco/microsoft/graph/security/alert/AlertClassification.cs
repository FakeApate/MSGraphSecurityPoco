namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Alert;

public enum AlertClassification
{
    unknown = 0,
    falsePositive = 10,
    truePositive = 20,
    informationalExpectedActivity = 30,
    unknownFutureValue = 39
}
