namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record IpEvidence : AlertEvidence
{
    public string? CountryLetterCode { get; init; }

    public string? IpAddress { get; init; }

    public GeoLocation? Location { get; init; }

    public StreamName? Stream { get; init; }



}
