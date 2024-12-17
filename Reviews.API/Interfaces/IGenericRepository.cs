using Reviews.API.Models;
using System.Linq.Expressions;

namespace Reviews.API.Interfaces;

public interface IGenericRepository <Model> where Model : BaseModel
{
    Task<Model> Create(Model entity, CancellationToken cancellationToken);
    Task<Model> Delete(Guid id, CancellationToken cancellationToken);
    Task<Model> Update(Model entity, Guid id, CancellationToken cancellationToken);
    Task<List<Model>> GetAll(CancellationToken cancellationToken);
    Task<Model> GetById(Guid id, CancellationToken cancellationToken);
    Task<List<Model>> GetByPredicate(Expression<Func<Model, bool>> predicate, CancellationToken cancellationToken);
}
