using si730pc2u20201b380.API.Publishing.Domain.Model.Entities;
using si730pc2u20201b380.API.Publishing.Domain.Repositories;
using si730pc2u20201b380.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using si730pc2u20201b380.API.Shared.Infrastructure.Persistence.EFC.Repositories;

namespace si730pc2u20201b380.API.Publishing.Infrastructure.Persistence.EFC.Repositories;

public class CategoryRepository(AppDbContext context) : BaseRepository<Category>(context), ICategoryRepository;