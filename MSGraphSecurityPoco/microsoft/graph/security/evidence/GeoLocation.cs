namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record GeoLocation
{
    public string? City { get; init; }

    public string? CountryName { get; init; }

    public double? Latitude { get; init; }

    public double? Longitude { get; init; }

    public string? State { get; init; }



}
