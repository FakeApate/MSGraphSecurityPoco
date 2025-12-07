namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Incident;

using MSGraphSecurityPoco.Microsoft.Graph.Security.Alert;

public partial record Incident : Entity
{
    public Incident() { }

    public Incident(DateTimeOffset createdDateTime, DateTimeOffset lastUpdateDateTime, AlertSeverity severity, IncidentStatus status)
    {
        this.CreatedDateTime = createdDateTime;
        this.LastUpdateDateTime = lastUpdateDateTime;
        this.Severity = severity;
        this.Status = status;
    }

    public string? AssignedTo { get; init; }

    public AlertClassification? Classification { get; init; }

    public List<AlertComment>? Comments { get; init; }

    public DateTimeOffset CreatedDateTime { get; init; }

    public List<string>? CustomTags { get; init; }

    public string? Description { get; init; }

    public AlertDetermination? Determination { get; init; }

    public string? DisplayName { get; init; }

    public string? IncidentWebUrl { get; init; }

    public string? LastModifiedBy { get; init; }

    public DateTimeOffset LastUpdateDateTime { get; init; }

    public string? RedirectIncidentId { get; init; }

    public string? ResolvingComment { get; init; }

    public AlertSeverity Severity { get; init; }

    public IncidentStatus Status { get; init; }

    public string? Summary { get; init; }

    public List<string>? SystemTags { get; init; }

    public string? TenantId { get; init; }



}
