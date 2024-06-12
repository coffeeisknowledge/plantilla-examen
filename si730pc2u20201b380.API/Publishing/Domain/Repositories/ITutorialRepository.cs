using si730pc2u20201b380.API.Publishing.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Shared.Domain.Repositories;

namespace si730pc2u20201b380.API.Publishing.Domain.Repositories;

public interface ITutorialRepository : IBaseRepository<Tutorial>
{
    Task<IEnumerable<Tutorial>> FindByCategoryIdAsync(int categoryId);
}