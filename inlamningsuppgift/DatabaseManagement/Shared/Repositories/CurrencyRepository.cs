using Shared.Contexts;
using Shared.Entities;

namespace Shared.Repositories;

internal class CurrencyRepository(DataContext dbContext) : AbstractRepository<CurrencyEntity>(dbContext) {

    private readonly DataContext _dbContext = dbContext;
}
