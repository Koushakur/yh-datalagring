using Shared.Contexts;
using Shared.Entities;

namespace Shared.Repositories;

public class CurrencyRepository(DataContext dbContext) : AbstractRepository<CurrencyEntity>(dbContext) {

    private readonly DataContext _dbContext = dbContext;
}
