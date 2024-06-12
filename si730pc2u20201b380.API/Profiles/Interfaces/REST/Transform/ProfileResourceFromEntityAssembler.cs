using si730pc2u20201b380.API.Profiles.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Profiles.Interfaces.REST.Resources;

namespace si730pc2u20201b380.API.Profiles.Interfaces.REST.Transform;

public static class ProfileResourceFromEntityAssembler
{
    public static ProfileResource ToResourceFromEntity(Profile entity)
    {
        return new ProfileResource(entity.Id, entity.FullName, entity.EmailAddress, entity.StreetAddress);
    }
}