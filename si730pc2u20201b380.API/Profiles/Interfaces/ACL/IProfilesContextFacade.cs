namespace si730pc2u20201b380.API.Profiles.Interfaces.ACL;

public interface IProfilesContextFacade
{
    Task<int> CreateProfile(string firstName, string lastName, string email, string street, string number, string city,
        string postalCode, string country);

    Task<int> FetchProfileIdByEmail(string email);
}