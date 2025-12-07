namespace MSGraphSecurityPoco.Microsoft.Graph.Security.Evidence;

public partial record FileHash
{
    public FileHash() { }

    public FileHash(FileHashAlgorithm algorithm) => this.Algorithm = algorithm;

    public FileHashAlgorithm Algorithm { get; init; }

    public string? Value { get; init; }



}
