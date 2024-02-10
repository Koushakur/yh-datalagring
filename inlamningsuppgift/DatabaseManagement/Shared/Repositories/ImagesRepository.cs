using Shared.Contexts;
using Shared.Entities;

namespace Shared.Repositories;

internal class ImagesRepository(DataContext dbContext) : AbstractRepository<ImagesEntity>(dbContext) {

    private readonly DataContext _dbContext = dbContext;
}
