namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Alert;

using MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record Alert : Entity
{
    public Alert() { }

    public Alert(ServiceSource serviceSource, AlertSeverity severity, AlertStatus status)
    {
        this.ServiceSource = serviceSource;
        this.Severity = severity;
        this.Status = status;
    }

    public string? ActorDisplayName { get; init; }

    public EvidenceDataStore? AdditionalData { get; init; }

    public string? AlertPolicyId { get; init; }

    public string? AlertWebUrl { get; init; }

    public string? AssignedTo { get; init; }

    public string? Category { get; init; }

    public AlertClassification? Classification { get; init; }

    public List<AlertComment>? Comments { get; init; }

    public DateTimeOffset? CreatedDateTime { get; init; }

    public EvidenceDataStore? CustomDetails { get; init; }

    public string? Description { get; init; }

    public DetectionSource? DetectionSource { get; init; }

    public string? DetectorId { get; init; }

    public AlertDetermination? Determination { get; init; }

    public List<AlertEvidence>? Evidence { get; init; }

    public DateTimeOffset? FirstActivityDateTime { get; init; }

    public string? IncidentId { get; init; }

    public string? IncidentWebUrl { get; init; }

    public InvestigationState? InvestigationState { get; init; }

    public DateTimeOffset? LastActivityDateTime { get; init; }

    public DateTimeOffset? LastUpdateDateTime { get; init; }

    public List<string>? MitreTechniques { get; init; }

    public string? ProductName { get; init; }

    public string? ProviderAlertId { get; init; }

    public string? RecommendedActions { get; init; }

    public DateTimeOffset? ResolvedDateTime { get; init; }

    public ServiceSource ServiceSource { get; init; }

    public AlertSeverity Severity { get; init; }

    public AlertStatus Status { get; init; }

    public List<string>? SystemTags { get; init; }

    public string? TenantId { get; init; }

    public string? ThreatDisplayName { get; init; }

    public string? ThreatFamilyName { get; init; }

    public string? Title { get; init; }



}
