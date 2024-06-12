using si730pc2u20201b380.API.Publishing.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Publishing.Domain.Model.Commands;
using si730pc2u20201b380.API.Publishing.Domain.Repositories;
using si730pc2u20201b380.API.Publishing.Domain.Services;
using si730pc2u20201b380.API.Shared.Domain.Repositories;

namespace si730pc2u20201b380.API.Publishing.Application.Internal.CommandServices;

public class TutorialCommandService(ITutorialRepository tutorialRepository, ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    : ITutorialCommandService
{

    public async Task<Tutorial?> Handle(AddVideoAssetToTutorialCommand command)
    {
        var tutorial = await tutorialRepository.FindByIdAsync(command.TutorialId);
        if (tutorial is null) throw new Exception("Tutorial not found");
        tutorial.AddVideo(command.VideoUrl);
        await unitOfWork.CompleteAsync();
        return tutorial;
    }

    public async Task<Tutorial?> Handle(CreateTutorialCommand command)
    {
        var tutorial = new Tutorial(command.Title, command.Summary, command.CategoryId);
        await tutorialRepository.AddAsync(tutorial);
        await unitOfWork.CompleteAsync();
        var category = await categoryRepository.FindByIdAsync(command.CategoryId);
        tutorial.Category = category;
        return tutorial;
    }   
}