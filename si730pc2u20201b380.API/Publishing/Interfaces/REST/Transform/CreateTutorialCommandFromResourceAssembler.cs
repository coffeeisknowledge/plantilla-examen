using si730pc2u20201b380.API.Publishing.Domain.Model.Commands;
using si730pc2u20201b380.API.Publishing.Interfaces.REST.Resources;

namespace si730pc2u20201b380.API.Publishing.Interfaces.REST.Transform;

public static class CreateTutorialCommandFromResourceAssembler
{
    public static CreateTutorialCommand ToCommandFromResource(CreateTutorialResource resource)
    {
        return new CreateTutorialCommand(resource.Title, resource.Summary, resource.CategoryId);
    }
}