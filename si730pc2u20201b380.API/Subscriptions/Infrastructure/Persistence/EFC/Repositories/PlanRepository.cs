using Microsoft.EntityFrameworkCore;
using si730pc2u20201b380.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using si730pc2u20201b380.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using si730pc2u20201b380.API.Subscriptions.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Subscriptions.Domain.Model.ValueObjects;
using si730pc2u20201b380.API.Subscriptions.Domain.Repositories;

namespace si730pc2u20201b380.API.Subscriptions.Infrastructure.Persistence.EFC.Repositories;

public class PlanRepository(AppDbContext context) : BaseRepository<Plan>(context), IPlanRepository
{
   public Task<Plan?> FindPlanByNameAsync(PlanName name)
   { 
      return Context.Set<Plan>().Where(p => p.Name == name).FirstOrDefaultAsync();
   }
}