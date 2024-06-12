using si730pc2u20201b380.API.Publishing.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Publishing.Domain.Model.Commands;

namespace si730pc2u20201b380.API.Publishing.Domain.Services;

public interface ITutorialCommandService
{
    Task<Tutorial?> Handle(AddVideoAssetToTutorialCommand command);
    Task<Tutorial?> Handle(CreateTutorialCommand command);
}