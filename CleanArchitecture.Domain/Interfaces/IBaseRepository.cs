using CleanArchitecture.Domain.Entities;


namespace CleanArchitecture.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellation);
        void Save(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
