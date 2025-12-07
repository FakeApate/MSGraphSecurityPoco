namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record MailboxEvidence : AlertEvidence
{
    public string? DisplayName { get; init; }

    public string? PrimaryAddress { get; init; }

    public string? Upn { get; init; }

    public UserAccount? UserAccount { get; init; }



}
