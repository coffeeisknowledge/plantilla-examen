namespace si730pc2u20201b380.API.Subscriptions.Domain.Model.ValueObjects;

public record PlanName(string Name)
{
    public PlanName() : this(string.Empty)
    {
    }

    public string GetName => $"{Name}";
}

