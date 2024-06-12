using si730pc2u20201b380.API.Profiles.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Profiles.Domain.Model.Commands;

namespace si730pc2u20201b380.API.Profiles.Domain.Services;

public interface IProfileCommandService
{
    Task<Profile?> Handle(CreateProfileCommand command);
}