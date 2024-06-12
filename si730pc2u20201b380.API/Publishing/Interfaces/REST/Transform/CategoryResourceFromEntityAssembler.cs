using si730pc2u20201b380.API.Publishing.Domain.Model.Entities;
using si730pc2u20201b380.API.Publishing.Interfaces.REST.Resources;

namespace si730pc2u20201b380.API.Publishing.Interfaces.REST.Transform;

public static class CategoryResourceFromEntityAssembler
{
    public static CategoryResource ToResourceFromEntity(Category entity)
    {
        Console.WriteLine("Category Name is " + entity.Name);
        return new CategoryResource(entity.Id, entity.Name);
    }
}