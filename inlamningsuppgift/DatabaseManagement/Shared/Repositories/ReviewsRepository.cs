using Shared.Contexts;
using Shared.Entities;

namespace Shared.Repositories;

public class ReviewsRepository(DataContext dbContext) : AbstractRepository<ReviewsEntity>(dbContext) {

    private readonly DataContext _dbContext = dbContext;
}