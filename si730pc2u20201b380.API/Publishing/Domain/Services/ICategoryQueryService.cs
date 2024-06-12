using si730pc2u20201b380.API.Publishing.Domain.Model.Entities;
using si730pc2u20201b380.API.Publishing.Domain.Model.Queries;

namespace si730pc2u20201b380.API.Publishing.Domain.Services;

public interface ICategoryQueryService
{
    Task<Category?> Handle(GetCategoryByIdQuery query);
    Task<IEnumerable<Category>> Handle(GetAllCategoriesQuery query);
}