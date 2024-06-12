using si730pc2u20201b380.API.Profiles.Domain.Model.ValueObjects;
using si730pc2u20201b380.API.Profiles.Interfaces.ACL;
using si730pc2u20201b380.API.Publishing.Domain.Model.ValueObjects;


namespace si730pc2u20201b380.API.Publishing.Application.Internal.OutboundServices.ACL;

public class ExternalProfileService(IProfilesContextFacade profilesContextFacade)
{

    public async Task<ProfileId?> FetchProfileIdByEmail(string email)
    {
        var profileId = await profilesContextFacade.FetchProfileIdByEmail(email);
        if (profileId == 0) return await Task.FromResult<ProfileId?>(null);
        return new ProfileId(profileId);
    }

    public async Task<ProfileId?> CreateProfile(string firstName, string lastName, string email, string street,
        string number, string city, string postalCode, string country)
    {
        var profileId = await profilesContextFacade.CreateProfile(firstName, lastName, email, street, number, city,
            postalCode, country);
        if (profileId == 0) return await Task.FromResult<ProfileId?>(null);
        return new ProfileId(profileId);
    }
    
}