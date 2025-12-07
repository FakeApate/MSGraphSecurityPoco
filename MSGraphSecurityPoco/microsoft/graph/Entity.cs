namespace MSGraphSecurityPoco.Microsoft.Graph;

public abstract partial record Entity
{
    public Entity() { }

    public Entity(string id) => this.Id = id;

    public required string Id { get; init; }

}
