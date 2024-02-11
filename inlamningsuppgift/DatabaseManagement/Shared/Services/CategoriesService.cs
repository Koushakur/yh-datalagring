
using Shared.Entities;
using Shared.Repositories;
using System.Diagnostics;

namespace Shared.Services;

public class CategoriesService(CategoriesRepository categoriesRepository) {
    private readonly CategoriesRepository _categoriesRepository = categoriesRepository;

    public bool Create(string name, int? parentCategoryId) {

        try {

            var tCategory = new CategoriesEntity {
                Name = name,
                ParentCategoryId = parentCategoryId ?? null
            };

            _categoriesRepository.Create(tCategory);

            return true;


        } catch (Exception e) { Debug.WriteLine(e); }

        return false;
    }

    public IEnumerable<CategoriesEntity> GetAll() {
        return _categoriesRepository.GetAll();
    }

    public CategoriesEntity GetOne(int id) {
        return _categoriesRepository.GetOne(x => x.Id == id);
    }

    public bool UpdateImage(int id, CategoriesEntity updatedEntity) {
        return _categoriesRepository.UpdateEntity(x => x.Id == id, updatedEntity);
    }

    public bool RemoveImage(int id) {
        return _categoriesRepository.RemoveEntity(x => x.Id == id);
    }
}

