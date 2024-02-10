using Shared.Contexts;
using Shared.Entities;

namespace Shared.Repositories;
public class ProductRepository(DataContext dbContext) : AbstractRepository<ProductEntity>(dbContext) {

    private readonly DataContext _dbContext = dbContext;
}

//internal class ProductCategoryRepository(DataContext dbContext) : AbstractRepository<ProductEntity>(dbContext) {

//    private readonly DataContext _dbContext = dbContext;
//}
//internal class ProductPricesRepository(DataContext dbContext) : AbstractRepository<ProductEntity>(dbContext) {

//    private readonly DataContext _dbContext = dbContext;
//}
//internal class ProductReviewRepository(DataContext dbContext) : AbstractRepository<ProductEntity>(dbContext) {

//    private readonly DataContext _dbContext = dbContext;
//}