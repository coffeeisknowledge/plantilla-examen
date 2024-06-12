using si730pc2u20201b380.API.Publishing.Domain.Model.Commands;
using si730pc2u20201b380.API.Publishing.Domain.Model.Entities;
using si730pc2u20201b380.API.Publishing.Domain.Repositories;
using si730pc2u20201b380.API.Publishing.Domain.Services;
using si730pc2u20201b380.API.Shared.Domain.Repositories;

namespace si730pc2u20201b380.API.Publishing.Application.Internal.CommandServices;

public class CategoryCommandService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
    : ICategoryCommandService
{
    /**
     * Create Category Command Handler
     * <summary>
     *     This method is responsible for handling the command and executing the business logic for creating a category.
     *     It is also responsible for calling the repository to persist the data.
     * </summary>
     * <param name="command">The command containing the name for the category</param>
     * <returns>The category entity.</returns>
     */
    public async Task<Category?> Handle(CreateCategoryCommand command)
    {
        var category = new Category(command.Name);
        await categoryRepository.AddAsync(category);
        await unitOfWork.CompleteAsync();
        return category;
    }
}