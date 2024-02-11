using Shared.Contexts;
using Shared.Entities;

namespace Shared.Repositories;

public class ImagesRepository(DataContext dbContext) : AbstractRepository<ImagesEntity>(dbContext) {

    private readonly DataContext _dbContext = dbContext;
}
