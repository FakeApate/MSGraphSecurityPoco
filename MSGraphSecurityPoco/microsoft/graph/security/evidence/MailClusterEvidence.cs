namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record MailClusterEvidence : AlertEvidence
{
    public string? ClusterBy { get; init; }

    public string? ClusterByValue { get; init; }

    public long? EmailCount { get; init; }

    public List<string>? NetworkMessageIds { get; init; }

    public string? Query { get; init; }

    public string? Urn { get; init; }



}
