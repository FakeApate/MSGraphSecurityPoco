namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record CloudLogonSessionEvidence : AlertEvidence
{
    public UserEvidence? Account { get; init; }

    public string? Browser { get; init; }

    public string? DeviceName { get; init; }

    public string? OperatingSystem { get; init; }

    public DateTimeOffset? PreviousLogonDateTime { get; init; }

    public string? Protocol { get; init; }

    public string? SessionId { get; init; }

    public DateTimeOffset? StartUtcDateTime { get; init; }

    public string? UserAgent { get; init; }



}
