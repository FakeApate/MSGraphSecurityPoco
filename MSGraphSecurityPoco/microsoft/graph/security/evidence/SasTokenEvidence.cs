namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record SasTokenEvidence : AlertEvidence
{
    public string? AllowedIpAddresses { get; init; }

    public List<string>? AllowedResourceTypes { get; init; }

    public List<string>? AllowedServices { get; init; }

    public DateTimeOffset? ExpiryDateTime { get; init; }

    public List<string>? Permissions { get; init; }

    public string? Protocol { get; init; }

    public string? SignatureHash { get; init; }

    public string? SignedWith { get; init; }

    public DateTimeOffset? StartDateTime { get; init; }

    public AzureResourceEvidence? StorageResource { get; init; }



}
