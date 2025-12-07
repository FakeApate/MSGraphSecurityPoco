namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record UserEvidence : AlertEvidence
{
    public StreamName? Stream { get; init; }

    public UserAccount? UserAccount { get; init; }



}
