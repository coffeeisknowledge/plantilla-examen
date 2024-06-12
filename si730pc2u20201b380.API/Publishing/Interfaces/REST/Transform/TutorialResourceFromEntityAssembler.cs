using si730pc2u20201b380.API.Publishing.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Publishing.Interfaces.REST.Resources;
using Microsoft.OpenApi.Extensions;

namespace si730pc2u20201b380.API.Publishing.Interfaces.REST.Transform;

public static class TutorialResourceFromEntityAssembler
{
    public static TutorialResource ToResourceFromEntity(Tutorial tutorial)
    {
        return new TutorialResource(
            tutorial.Id,
            tutorial.Title,
            tutorial.Summary,
            CategoryResourceFromEntityAssembler.ToResourceFromEntity(tutorial.Category),
            tutorial.Status.GetDisplayName());
    }
}