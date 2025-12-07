namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record IoTDeviceEvidence : AlertEvidence
{
    public string? DeviceId { get; init; }

    public string? DeviceName { get; init; }

    public string? DevicePageLink { get; init; }

    public string? DeviceSubType { get; init; }

    public string? DeviceType { get; init; }

    public IoTDeviceImportanceType? Importance { get; init; }

    public AzureResourceEvidence? IoTHub { get; init; }

    public string? IoTSecurityAgentId { get; init; }

    public IpEvidence? IpAddress { get; init; }

    public bool? IsAuthorized { get; init; }

    public bool? IsProgramming { get; init; }

    public bool? IsScanner { get; init; }

    public string? MacAddress { get; init; }

    public string? Manufacturer { get; init; }

    public string? Model { get; init; }

    public List<NicEvidence>? Nics { get; init; }

    public string? OperatingSystem { get; init; }

    public List<string>? Owners { get; init; }

    public List<string>? Protocols { get; init; }

    public string? PurdueLayer { get; init; }

    public string? Sensor { get; init; }

    public string? SerialNumber { get; init; }

    public string? Site { get; init; }

    public string? Source { get; init; }

    public UrlEvidence? SourceRef { get; init; }

    public string? Zone { get; init; }



}
