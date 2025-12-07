namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record GitHubRepoEvidence : AlertEvidence
{
    public string? BaseUrl { get; init; }

    public string? Login { get; init; }

    public string? Owner { get; init; }

    public string? OwnerType { get; init; }

    public string? RepoId { get; init; }



}
