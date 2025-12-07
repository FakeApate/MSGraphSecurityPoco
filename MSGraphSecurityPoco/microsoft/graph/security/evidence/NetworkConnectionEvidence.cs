namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record NetworkConnectionEvidence : AlertEvidence
{
    public IpEvidence? DestinationAddress { get; init; }

    public int? DestinationPort { get; init; }

    public ProtocolType? Protocol { get; init; }

    public IpEvidence? SourceAddress { get; init; }

    public int? SourcePort { get; init; }



}
