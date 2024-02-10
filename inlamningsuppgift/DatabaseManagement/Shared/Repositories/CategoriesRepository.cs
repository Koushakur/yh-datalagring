using Shared.Contexts;
using Shared.Entities;

namespace Shared.Repositories;

public class CategoriesRepository(DataContext dbContext) : AbstractRepository<CategoriesEntity>(dbContext) {

    private readonly DataContext _dbContext = dbContext;
}
