namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record RegistryKeyEvidence : AlertEvidence
{
    public string? RegistryHive { get; init; }

    public string? RegistryKey { get; init; }



}
