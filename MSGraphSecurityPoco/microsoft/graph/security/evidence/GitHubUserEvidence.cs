namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record GitHubUserEvidence : AlertEvidence
{
    public string? Email { get; init; }

    public string? Login { get; init; }

    public string? Name { get; init; }

    public string? UserId { get; init; }

    public string? WebUrl { get; init; }



}
