using si730pc2u20201b380.API.Publishing.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Publishing.Domain.Model.Queries;

namespace si730pc2u20201b380.API.Publishing.Domain.Services;

public interface ITutorialQueryService
{
    Task<Tutorial?> Handle(GetTutorialByIdQuery query);
    Task<IEnumerable<Tutorial>> Handle(GetAllTutorialsQuery query);
    Task<IEnumerable<Tutorial>> Handle(GetAllTutorialsByCategoryIdQuery query);
}