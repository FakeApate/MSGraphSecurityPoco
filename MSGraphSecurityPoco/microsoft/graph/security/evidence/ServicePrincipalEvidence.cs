namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record ServicePrincipalEvidence : AlertEvidence
{
    public string? AppId { get; init; }

    public string? AppOwnerTenantId { get; init; }

    public string? ServicePrincipalName { get; init; }

    public string? ServicePrincipalObjectId { get; init; }

    public ServicePrincipalType? ServicePrincipalType { get; init; }

    public string? TenantId { get; init; }



}
