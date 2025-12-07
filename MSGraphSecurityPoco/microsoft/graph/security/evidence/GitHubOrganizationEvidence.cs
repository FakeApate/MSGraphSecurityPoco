namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record GitHubOrganizationEvidence : AlertEvidence
{
    public string? Company { get; init; }

    public string? DisplayName { get; init; }

    public string? Email { get; init; }

    public string? Login { get; init; }

    public string? OrgId { get; init; }

    public string? WebUrl { get; init; }



}
