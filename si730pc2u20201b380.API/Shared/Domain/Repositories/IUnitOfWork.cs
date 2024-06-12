namespace si730pc2u20201b380.API.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}