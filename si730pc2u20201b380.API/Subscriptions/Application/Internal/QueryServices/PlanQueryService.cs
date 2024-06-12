using si730pc2u20201b380.API.Subscriptions.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Subscriptions.Domain.Model.Queries;
using si730pc2u20201b380.API.Subscriptions.Domain.Repositories;
using si730pc2u20201b380.API.Subscriptions.Domain.Services;

namespace si730pc2u20201b380.API.Subscriptions.Application.Internal.QueryServices;

public class PlanQueryService(IPlanRepository planRepository) : IPlanQueryService
{
    public async Task<IEnumerable<Plan>> Handle(GetAllPlansQuery query)
    {
        return await planRepository.ListAsync();
    }

    public async Task<Plan?> Handle(GetPlanByIdQuery query)
    {
        return await planRepository.FindByIdAsync(query.PlanId);
    }

    public async Task<Plan?> Handle(GetPlanByName query)
    {
        return await planRepository.FindPlanByNameAsync(query.Name);
    }
}