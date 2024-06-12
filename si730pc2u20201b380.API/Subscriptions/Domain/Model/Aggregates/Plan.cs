using si730pc2u20201b380.API.Subscriptions.Domain.Model.ValueObjects;

namespace si730pc2u20201b380.API.Subscriptions.Domain.Model.Aggregates;

public partial class Plan
{
    public int Id { get; }
    public PlanName Name { get; private set; }
    public PlanDefault Default { get; private set;  }
    public PlanMaxUsers MaxUsers { get; private set; }
    
    
    public Plan()
    {
        Name = new PlanName();
        Default = new PlanDefault();
        MaxUsers = new PlanMaxUsers();
    }
    
}