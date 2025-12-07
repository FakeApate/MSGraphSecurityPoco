namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record HostLogonSessionEvidence : AlertEvidence
{
    public UserEvidence? Account { get; init; }

    public DateTimeOffset? EndUtcDateTime { get; init; }

    public DeviceEvidence? Host { get; init; }

    public string? SessionId { get; init; }

    public DateTimeOffset? StartUtcDateTime { get; init; }



}
