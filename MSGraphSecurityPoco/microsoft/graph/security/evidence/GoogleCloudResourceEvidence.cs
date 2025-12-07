namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record GoogleCloudResourceEvidence : AlertEvidence
{
    public string? FullResourceName { get; init; }

    public string? Location { get; init; }

    public GoogleCloudLocationType? LocationType { get; init; }

    public string? ProjectId { get; init; }

    public long? ProjectNumber { get; init; }

    public string? ResourceName { get; init; }

    public string? ResourceType { get; init; }



}
