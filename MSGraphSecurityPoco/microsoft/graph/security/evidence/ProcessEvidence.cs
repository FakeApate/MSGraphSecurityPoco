namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record ProcessEvidence : AlertEvidence
{
    public DetectionStatus? DetectionStatus { get; init; }

    public FileDetails? ImageFile { get; init; }

    public string? MdeDeviceId { get; init; }

    public DateTimeOffset? ParentProcessCreationDateTime { get; init; }

    public long? ParentProcessId { get; init; }

    public FileDetails? ParentProcessImageFile { get; init; }

    public string? ProcessCommandLine { get; init; }

    public DateTimeOffset? ProcessCreationDateTime { get; init; }

    public long? ProcessId { get; init; }

    public UserAccount? UserAccount { get; init; }



}
