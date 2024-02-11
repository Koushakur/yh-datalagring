
using Shared.Contexts;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Shared.Repositories;

public abstract class AbstractRepository<TEntity> where TEntity : class {

    private readonly DataContext _dbContext;

    protected AbstractRepository(DataContext dbContext) {
        _dbContext = dbContext;
    }

    public virtual TEntity Create(TEntity entity) {
        try {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;

        } catch (Exception e) { Debug.WriteLine(e); }

        return null!;
    }

    public virtual TEntity GetOne(Expression<Func<TEntity, bool>> exp) {
        try {
            var tEntity = _dbContext.Set<TEntity>().FirstOrDefault(exp)!;

            return tEntity ?? null!;

        } catch (Exception e) { Debug.WriteLine(e); }
        return null!;
    }
    public virtual ICollection<TEntity> GetAll() {
        try {
            var tEntities = _dbContext.Set<TEntity>().ToList();

            return tEntities ?? null!;

        } catch (Exception e) { Debug.WriteLine(e); }
        return null!;
    }

    public virtual bool UpdateEntity(Expression<Func<TEntity, bool>> exp, TEntity updatedEntity) {
        try {
            var tEntity = _dbContext.Set<TEntity>().FirstOrDefault(exp)!;
            if (tEntity != null) {
                _dbContext.Entry(tEntity).CurrentValues.SetValues(updatedEntity);
                _dbContext.SaveChanges();
                return true;
            }

        } catch (Exception e) { Debug.WriteLine(e); }
        return false;
    }

    public virtual bool RemoveEntity(Expression<Func<TEntity, bool>> exp) {
        try {
            var tEntity = _dbContext.Set<TEntity>().FirstOrDefault(exp!, null);
            if (tEntity != null) {
                _dbContext.Set<TEntity>().Remove(tEntity);
                _dbContext.SaveChanges();

                return true;
            }

        } catch (Exception e) { Debug.WriteLine(e); }
        return false;
    }


    public bool Exists(Expression<Func<TEntity, bool>> exp) {
        try {
            return _dbContext.Set<TEntity>().Any(exp);

        } catch (Exception e) { Debug.WriteLine(e); }
        return false;
    }
}
