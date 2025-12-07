namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record BlobEvidence : AlertEvidence
{
    public BlobContainerEvidence? BlobContainer { get; init; }

    public string? Etag { get; init; }

    public List<FileHash>? FileHashes { get; init; }

    public string? Name { get; init; }

    public string? Url { get; init; }



}
