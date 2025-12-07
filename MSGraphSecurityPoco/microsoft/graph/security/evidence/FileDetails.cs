namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record FileDetails
{
    public string? FileName { get; init; }

    public string? FilePath { get; init; }

    public string? FilePublisher { get; init; }

    public long? FileSize { get; init; }

    public string? Issuer { get; init; }

    public string? Md5 { get; init; }

    public string? Sha1 { get; init; }

    public string? Sha256 { get; init; }

    public string? Sha256Ac { get; init; }

    public string? Signer { get; init; }



}
