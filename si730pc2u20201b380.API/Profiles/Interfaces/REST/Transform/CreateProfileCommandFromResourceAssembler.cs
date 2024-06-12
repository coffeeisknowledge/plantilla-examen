using si730pc2u20201b380.API.Profiles.Domain.Model.Commands;
using si730pc2u20201b380.API.Profiles.Interfaces.REST.Resources;

namespace si730pc2u20201b380.API.Profiles.Interfaces.REST.Transform;

public static class CreateProfileCommandFromResourceAssembler
{
    public static CreateProfileCommand ToCommandFromResource(CreateProfileResource resource)
    {
        return new CreateProfileCommand(resource.FirstName, resource.LastName, resource.Email, resource.Street,
            resource.Number, resource.City, resource.PostalCode, resource.Country);
    }
}