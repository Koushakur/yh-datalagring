
using Shared.Entities;
using Shared.Repositories;
using System.Diagnostics;

namespace Shared.Services;

public class ImagesService(ImagesRepository imagesRepository) {
    private readonly ImagesRepository _imagesRepository = imagesRepository;

    public bool Create(string contentURL) {

        try {
            if (!_imagesRepository.Exists(x => x.Id == id)) {


                var tImage = new ImagesEntity {
                    ContentURL = contentURL
                };

                _imagesRepository.Create(tImage);

                return true;
            }

        } catch (Exception e) { Debug.WriteLine(e); }

        return false;
    }

    public IEnumerable<ImagesEntity> GetAll() {
        return _imagesRepository.GetAll();
    }

    public ImagesEntity GetOne(int id) {
        return _imagesRepository.GetOne(x => x.Id == id);
    }

    public bool UpdateImage(int id, ImagesEntity updatedEntity) {
        return _imagesRepository.UpdateEntity(x => x.Id == id, updatedEntity);
    }

    public bool RemoveImage(int id) {
        return _imagesRepository.RemoveEntity(x => x.Id == id);
    }
}