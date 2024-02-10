
using Shared.Entities;
using Shared.Repositories;
using System.Diagnostics;

namespace Shared.Services {
    public class ProductService(ProductRepository productRepository, CategoriesRepository categoryRepository) {
        private readonly ProductRepository _productRepository = productRepository;
        private readonly CategoriesRepository _categoryRepository = categoryRepository;

        public bool Create(
            string articleNumber,
            string name,
            decimal price,
            string categoryName,
            int thumbnailImageId = -1,
            string ingress = null!,
            string description = null!,
            string detailedSpecsJson = null!
        ) {

            try {
                if (!_productRepository.Exists(x => x.ArticleNumber == articleNumber)) {
                    var tCategory = _categoryRepository.GetOne(x => x.Name == categoryName);
                    tCategory ??= _categoryRepository.Create(new CategoriesEntity { Name = categoryName });

                    var tProduct = new ProductEntity {
                        ArticleNumber = articleNumber,
                        Name = name,
                        ThumbnailImageId = thumbnailImageId,
                        Ingress = ingress,
                        Description = description,
                        DetailedSpecsJSON = detailedSpecsJson,
                        //Category = tCategory
                    };
                }

                return true;
            } catch (Exception e) { Debug.WriteLine(e); }

            return false;
        }
    }
}
