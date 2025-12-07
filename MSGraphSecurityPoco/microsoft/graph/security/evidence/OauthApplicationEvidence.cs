namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record OauthApplicationEvidence : AlertEvidence
{
    public string? AppId { get; init; }

    public string? DisplayName { get; init; }

    public string? ObjectId { get; init; }

    public string? Publisher { get; init; }



}
