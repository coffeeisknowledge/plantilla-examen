using si730pc2u20201b380.API.Profiles.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Profiles.Domain.Model.Commands;
using si730pc2u20201b380.API.Profiles.Domain.Repositories;
using si730pc2u20201b380.API.Profiles.Domain.Services;
using si730pc2u20201b380.API.Shared.Domain.Repositories;

namespace si730pc2u20201b380.API.Profiles.Application.Internal.CommandServices;

public class ProfileCommandService(IProfileRepository profileRepository, IUnitOfWork unitOfWork) : IProfileCommandService
{
    public async Task<Profile?> Handle(CreateProfileCommand command)
    {
        var profile = new Profile(command);
        try
        {
            await profileRepository.AddAsync(profile);
            await unitOfWork.CompleteAsync();
            return profile;
        } catch (Exception e)
        {
            Console.WriteLine($"An error occurred while creating the profile: {e.Message}");
            return null;
        }
    }
}