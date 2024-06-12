using si730pc2u20201b380.API.Profiles.Domain.Model.ValueObjects;

namespace si730pc2u20201b380.API.Profiles.Domain.Model.Queries;

public record GetProfileByEmailQuery(EmailAddress Email);