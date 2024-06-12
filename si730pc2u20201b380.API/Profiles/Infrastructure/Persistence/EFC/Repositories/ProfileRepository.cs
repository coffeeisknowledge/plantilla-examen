using si730pc2u20201b380.API.Profiles.Domain.Model.Aggregates;
using si730pc2u20201b380.API.Profiles.Domain.Model.ValueObjects;
using si730pc2u20201b380.API.Profiles.Domain.Repositories;
using si730pc2u20201b380.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using si730pc2u20201b380.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using Microsoft.EntityFrameworkCore;

namespace si730pc2u20201b380.API.Profiles.Infrastructure.Persistence.EFC.Repositories;

public class ProfileRepository(AppDbContext context) : BaseRepository<Profile>(context), IProfileRepository
{
    public Task<Profile?> FindProfileByEmailAsync(EmailAddress email)
    {
        return Context.Set<Profile>().Where(p => p.Email == email).FirstOrDefaultAsync();
    }
}