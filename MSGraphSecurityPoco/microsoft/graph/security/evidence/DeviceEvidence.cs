namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record DeviceEvidence : AlertEvidence
{
    public string? AzureAdDeviceId { get; init; }

    public DefenderAvStatus? DefenderAvStatus { get; init; }

    public string? DeviceDnsName { get; init; }

    public string? DnsDomain { get; init; }

    public DateTimeOffset? FirstSeenDateTime { get; init; }

    public DeviceHealthStatus? HealthStatus { get; init; }

    public string? HostName { get; init; }

    public List<string>? IpInterfaces { get; init; }

    public string? LastExternalIpAddress { get; init; }

    public string? LastIpAddress { get; init; }

    public List<LoggedOnUser>? LoggedOnUsers { get; init; }

    public string? MdeDeviceId { get; init; }

    public string? NtDomain { get; init; }

    public OnboardingStatus? OnboardingStatus { get; init; }

    public long? OsBuild { get; init; }

    public string? OsPlatform { get; init; }

    public int? RbacGroupId { get; init; }

    public string? RbacGroupName { get; init; }

    public DeviceRiskScore? RiskScore { get; init; }

    public string? Version { get; init; }

    public VmMetadata? VmMetadata { get; init; }



}
