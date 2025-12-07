namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record ResourceAccessEvent
{
    public DateTimeOffset? AccessDateTime { get; init; }

    public string? AccountId { get; init; }

    public string? IpAddress { get; init; }

    public string? ResourceIdentifier { get; init; }



}
