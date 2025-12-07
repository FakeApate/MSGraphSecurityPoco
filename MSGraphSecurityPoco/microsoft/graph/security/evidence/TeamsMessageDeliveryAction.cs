namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public enum TeamsMessageDeliveryAction
{
    unknown = 0,
    deliveredAsSpam = 1,
    delivered = 2,
    blocked = 3,
    replaced = 4,
    unknownFutureValue = 31
}
