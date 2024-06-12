using si730pc2u20201b380.API.Shared.Domain.Repositories;
using si730pc2u20201b380.API.Subscriptions.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Subscriptions.Domain.Model.ValueObjects;

namespace si730pc2u20201b380.API.Subscriptions.Domain.Repositories;

public interface IPlanRepository : IBaseRepository<Plan>
{
    Task<Plan?> FindPlanByNameAsync(PlanName name);
}