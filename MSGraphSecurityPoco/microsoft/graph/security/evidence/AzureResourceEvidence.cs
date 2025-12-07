namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record AzureResourceEvidence : AlertEvidence
{
    public string? ResourceId { get; init; }

    public string? ResourceName { get; init; }

    public string? ResourceType { get; init; }



}
