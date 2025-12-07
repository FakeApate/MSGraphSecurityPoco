namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record FileHashEvidence : AlertEvidence
{
    public FileHashEvidence() { }

    public FileHashEvidence(FileHashAlgorithm algorithm) => this.Algorithm = algorithm;

    public FileHashAlgorithm Algorithm { get; init; }

    public string? Value { get; init; }



}
