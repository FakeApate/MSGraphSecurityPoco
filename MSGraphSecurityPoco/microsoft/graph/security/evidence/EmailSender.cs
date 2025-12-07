namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record EmailSender
{
    public string? DisplayName { get; init; }

    public string? DomainName { get; init; }

    public string? EmailAddress { get; init; }



}
