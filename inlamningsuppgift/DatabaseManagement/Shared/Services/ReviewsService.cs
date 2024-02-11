
using Shared.Entities;
using Shared.Repositories;
using System.Diagnostics;

namespace Shared.Services;

public class ReviewsService(ReviewsRepository reviewsRepository) {
    private readonly ReviewsRepository _reviewsRepository = reviewsRepository;

    public bool Create(int customerId, int rating, string? title, string? content) {

        try {
            var tReview = new ReviewsEntity {
                CustomerId = customerId,
                Rating = rating,
                Title = title ?? null,
                Content = content ?? null
            };

            _reviewsRepository.Create(tReview);

            return true;

        } catch (Exception e) { Debug.WriteLine(e); }

        return false;
    }

    public IEnumerable<ReviewsEntity> GetAll() {
        return _reviewsRepository.GetAll();
    }

    public ReviewsEntity GetOne(int id) {
        return _reviewsRepository.GetOne(x => x.Id == id);
    }

    public bool UpdateImage(int id, ReviewsEntity updatedEntity) {
        return _reviewsRepository.UpdateEntity(x => x.Id == id, updatedEntity);
    }

    public bool RemoveImage(int id) {
        return _reviewsRepository.RemoveEntity(x => x.Id == id);
    }
}
