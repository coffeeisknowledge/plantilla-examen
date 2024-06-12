using si730pc2u20201b380.API.Publishing.Domain.Model.Commands;
using si730pc2u20201b380.API.Publishing.Interfaces.REST.Resources;

namespace si730pc2u20201b380.API.Publishing.Interfaces.REST.Transform;

public static class AddVideoAssetToTutorialCommandFromResourceAssembler
{
    public static AddVideoAssetToTutorialCommand ToCommandFromResource(AddVideoAssetToTutorialResource addVideoAssetToTutorialResource, int tutorialId)
    {
        return new AddVideoAssetToTutorialCommand(addVideoAssetToTutorialResource.VideoUrl, tutorialId);
    }
}