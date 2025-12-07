namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record UserAccount
{
    public string? AccountName { get; init; }

    public Guid? ActiveDirectoryObjectGuid { get; init; }

    public string? AzureAdUserId { get; init; }

    public string? DisplayName { get; init; }

    public string? DomainName { get; init; }

    public List<ResourceAccessEvent>? ResourceAccessEvents { get; init; }

    public string? UserPrincipalName { get; init; }

    public string? UserSid { get; init; }



}
