using si730pc2u20201b380.API.Profiles.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Profiles.Domain.Model.Queries;
using si730pc2u20201b380.API.Profiles.Domain.Repositories;
using si730pc2u20201b380.API.Profiles.Domain.Services;

namespace si730pc2u20201b380.API.Profiles.Application.Internal.QueryServices;

public class ProfileQueryService(IProfileRepository profileRepository) : IProfileQueryService
{
    public async Task<IEnumerable<Profile>> Handle(GetAllProfilesQuery query)
    {
        return await profileRepository.ListAsync();
    }

    public async Task<Profile?> Handle(GetProfileByEmailQuery query)
    {
        return await profileRepository.FindProfileByEmailAsync(query.Email);
    }

    public async Task<Profile?> Handle(GetProfileByIdQuery query)
    {
        return await profileRepository.FindByIdAsync(query.ProfileId);
    }
}