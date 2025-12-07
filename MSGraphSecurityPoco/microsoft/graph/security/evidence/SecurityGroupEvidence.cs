namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record SecurityGroupEvidence : AlertEvidence
{
    public Guid? ActiveDirectoryObjectGuid { get; init; }

    public string? DisplayName { get; init; }

    public string? DistinguishedName { get; init; }

    public string? FriendlyName { get; init; }

    public string? SecurityGroupId { get; init; }

    public string? Sid { get; init; }



}
