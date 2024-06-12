using si730pc2u20201b380.API.Subscriptions.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Subscriptions.Domain.Model.Commands;

namespace si730pc2u20201b380.API.Subscriptions.Domain.Services;

public interface IPlanCommandService
{
    Task<Plan> Handle(CreatePlanCommand command);
}