namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public enum EvidenceVerdict
{
    unknown = 0,
    suspicious = 1,
    malicious = 2,
    noThreatsFound = 3,
    unknownFutureValue = 4
}
