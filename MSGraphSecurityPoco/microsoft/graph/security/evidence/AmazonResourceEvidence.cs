namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record AmazonResourceEvidence : AlertEvidence
{
    public string? AmazonAccountId { get; init; }

    public string? AmazonResourceId { get; init; }

    public string? ResourceName { get; init; }

    public string? ResourceType { get; init; }



}
