namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record BlobContainerEvidence : AlertEvidence
{
    public string? Name { get; init; }

    public AzureResourceEvidence? StorageResource { get; init; }

    public string? Url { get; init; }



}
