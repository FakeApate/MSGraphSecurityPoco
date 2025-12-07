namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record FileEvidence : AlertEvidence
{
    public DetectionStatus? DetectionStatus { get; init; }

    public FileDetails? FileDetails { get; init; }

    public string? MdeDeviceId { get; init; }



}
