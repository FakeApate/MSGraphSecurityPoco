namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record RegistryValueEvidence : AlertEvidence
{
    public string? MdeDeviceId { get; init; }

    public string? RegistryHive { get; init; }

    public string? RegistryKey { get; init; }

    public string? RegistryValue { get; init; }

    public string? RegistryValueName { get; init; }

    public string? RegistryValueType { get; init; }



}
