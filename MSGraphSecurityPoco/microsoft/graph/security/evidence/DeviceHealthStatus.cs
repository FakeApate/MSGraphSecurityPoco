namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public enum DeviceHealthStatus
{
    active = 0,
    inactive = 1,
    impairedCommunication = 2,
    noSensorData = 3,
    noSensorDataImpairedCommunication = 4,
    unknown = 5,
    unknownFutureValue = 31
}
