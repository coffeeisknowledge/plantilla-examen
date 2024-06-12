using si730pc2u20201b380.API.Publishing.Domain.Model.Commands;
using si730pc2u20201b380.API.Publishing.Domain.Model.Entities;

namespace si730pc2u20201b380.API.Publishing.Domain.Services;

public interface ICategoryCommandService
{
    public Task<Category?> Handle(CreateCategoryCommand command);
}