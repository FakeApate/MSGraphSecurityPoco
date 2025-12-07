namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Incident;

public enum IncidentStatus
{
    active = 1,
    resolved = 2,
    inProgress = 4,
    redirected = 64,
    unknownFutureValue = 127,
    awaitingAction = 128
}
