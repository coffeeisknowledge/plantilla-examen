using si730pc2u20201b380.API.Subscriptions.Domain.Model.Commands;
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

    public Plan(string name, int maxUsers, int defaultValue)
    {
        Name = new PlanName(name);
        MaxUsers = new PlanMaxUsers(maxUsers);
        Default = new PlanDefault(defaultValue);
    }

    public Plan(CreatePlanCommand command)
    {
        Name = new PlanName(command.Name);
        MaxUsers = new PlanMaxUsers(command.MaxUsers);
        Default = new PlanDefault(command.Default);
    }

    public string GetName => Name.GetName;
    public int GetMaxUsers => MaxUsers.GetMaxUsers;
    public int GetDefault => Default.GetDefault;
}